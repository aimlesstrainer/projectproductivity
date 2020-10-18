// ***Project Productivity***
// Creator: Arbab Ahmed
// Version: 1.00
// Date: 10th August, 2018

// Outstanding bugs:
// List boxes don't wrap lines if the strings are too long (not a coding bug, but still fix this).
// Schedule doesn't yet check for conflicting times. (sort of fixed with the foreach break in CheckForSchedules)
// Schedule runtime addition crash.
// Features to add:
// frmReminder date in list box adapting to the user's settings, same with frmSchedule.
// frmCalendar checking for scheduled days and graying out any unused days.
// Website monitoring.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using SchedLists = Project_Productivity.frmSchedule.ScheduleLists;

namespace Project_Productivity
{
    public partial class frmMain : Form
    {
        public bool bool24Hours, boolMDY, boolShortYear, boolShortDate, boolYearFirst, boolManualMonitor = false, boolMonitoringOn = false, boolManualTimerEnded = true;
        public byte byteDateSeparator;
        string strDateSeparator, strTime, strYear, strCurrentReminderToAdd, strToDoToAdd;
        bool boolBreakPeriod = false, boolUnproductive = false, boolAttemptUnproductive = false;
        public string strDateFormat;
        public DateTime dtMonitorEnd, dtMonitorAddedEnd;
        frmSchedule schedule = new frmSchedule();
        frmStatistics statistics = new frmStatistics();
        frmLists lists = new frmLists();
        frmLogin login = new frmLogin();
        TimeSpan tsTimeLeft = new TimeSpan(), tsManualTimeLeft = new TimeSpan();
        public frmMain()
        {
            InitializeComponent();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            // Starts the timer that most functions run off of (then ticks it so everything loads), then, through other methods, checks for reminders and to-dos, loads the schedules from 
            // frmSchedule, checks for them, loads the statistics (and sets the initial date if not set), and checks if the user is being unproductive.
            // Input (this method): Configuration file detailing what options the user selected in frmOptions.
            // Output (this method): Strings strDateSeparator until strDateFormat altered according to the user's preferences and displayed as per them.
            tmrTime.Start();
            using (StreamReader ConfigReader = new StreamReader("config.txt"))
            {
                if (ConfigReader.ReadLine() == "True")
                {
                    bool24Hours = true;
                    strTime = "HH:mm";
                }
                else
                {
                    bool24Hours = false;
                    strTime = "hh:mm tt";
                }
                if (ConfigReader.ReadLine() == "True")
                {
                    boolShortDate = true;
                    if (ConfigReader.ReadLine() == "True")
                    {
                        boolMDY = true;
                    }
                    else
                    {
                        boolMDY = false;
                    }
                    switch (ConfigReader.ReadLine())
                    {
                        case "0":
                            strDateSeparator = "/";
                            byteDateSeparator = 0;
                            break;
                        case "1":
                            strDateSeparator = "-";
                            byteDateSeparator = 1;
                            break;
                        case "2":
                            strDateSeparator = ".";
                            byteDateSeparator = 2;
                            break;
                    }
                    if (ConfigReader.ReadLine() == "True")
                    {
                        strYear = "yy";
                        boolShortYear = true;
                    }
                    else
                    {
                        strYear = "yyyy";
                        boolShortYear = false;
                    }
                    if (ConfigReader.ReadLine() == "True")
                    {
                        boolYearFirst = true;
                    }
                    else
                    {
                        boolYearFirst = false;
                    }
                }
                else
                {
                    boolShortDate = false;
                }
            }
            statistics.ReadStats();
            tmrTime_Tick(sender, e);
            UpdateReminders();
            UpdateToDos();
            schedule.frmSchedule_Load(sender, e);
            CheckForSchedules(sender, e);
            if (statistics.boolIsInitialDay)
            {
                statistics.dtInitialUse = DateTime.Now;
                statistics.boolIsInitialDay = false;
            }
            lists.frmLists_Load(sender, e);
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            // Opens frmOptions.
            frmOptions options = new frmOptions(this);
            options.ShowDialog();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            // Quits the application after writing the statistics to a text file.
            statistics.WriteStats();
            Application.Exit();
        }

        private void mnuMonitor_Click(object sender, EventArgs e)
        {
            // Opens frmMonitor, unless:
            // Monitoring is already on, in which case a warning will pop up.
            // A break period is active, in which case a different warning will pop up.
            if (boolMonitoringOn == false && boolBreakPeriod == false)
            {
                frmMonitor monitor = new frmMonitor(this);
                monitor.ShowDialog();
            }
            else if (boolMonitoringOn == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to stop monitoring?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes && !boolManualMonitor)
                {
                    boolMonitoringOn = false;
                    boolManualMonitor = true;
                }
                else if (result == DialogResult.Yes && boolManualMonitor)
                {
                    boolMonitoringOn = false;
                    boolManualMonitor = false;
                }
            }
            else if (boolBreakPeriod == true)
            {
                if (MessageBox.Show("A break period is currently active." + Environment.NewLine + "Are you sure you want to proceed?", "Warning!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    boolBreakPeriod = false;
                    boolManualMonitor = true;
                    frmMonitor monitor = new frmMonitor(this);
                    monitor.ShowDialog();
                }
            }
        }

        private void mnuReminder_Click(object sender, EventArgs e)
        {
            // Opens frmReminder.
            frmReminder reminder = new frmReminder(this);
            reminder.ShowDialog();
        }

        private void mnuToDo_Click(object sender, EventArgs e)
        {
            // Opens frmToDo.
            frmToDo todo = new frmToDo(this);
            todo.ShowDialog();
        }

        private void mnuStatistics_Click(object sender, EventArgs e)
        {
            // Opens frmStatistics.
            statistics.ShowDialog();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            // Opens frmHelp.
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void mnuCalendar_Click(object sender, EventArgs e)
        {
            // Opens frmCalendar.
            frmCalendar calendar = new frmCalendar();
            calendar.ShowDialog();
        }

        private void mnuSchedule_Click(object sender, EventArgs e)
        {
            // Opens frmSchedule.
            frmSchedule schedule = new frmSchedule();
            schedule.ShowDialog();
        }

        private void mnuLists_Click(object sender, EventArgs e)
        {
            // Opens frmLists.
            lists.ShowDialog();
        }

        public void tmrTime_Tick(object sender, EventArgs e)
        {
            // Updates the time, and, through other methods, reminders, to-dos, checks for scheduled work and break periods, and checks for manually-timed monitoring.
            // Input (this method): Strings that were allocated values/updated from the 'Load' method.
            // Output (this method): The current date and time displayed on the main screen, according to the user's settings.
            frmReminder reminder = new frmReminder(this);
            frmToDo todo = new frmToDo(this);
            if (boolShortDate)
            {
                if (boolMDY)
                {
                    if (boolYearFirst)
                    { strDateFormat = "ddd, " + "yyyy" + strDateSeparator + "MM" + strDateSeparator + "dd, " + strTime; }
                    else
                    { strDateFormat = "ddd, " + "MM" + strDateSeparator + "dd" + strDateSeparator + strYear + ", " + strTime; }

                }
                else
                {
                    if (boolYearFirst)
                    { strDateFormat = "ddd, " + "yyyy" + strDateSeparator + "dd" + strDateSeparator + "MM, " + strTime; }
                    else
                    { strDateFormat = "ddd, " + "dd" + strDateSeparator + "MM" + strDateSeparator + strYear + ", " + strTime; }
                }
            }
            else
            { strDateFormat = "dddd, dd MMMM yyyy, " + strTime; }
            lblDate.Text = DateTime.Now.ToString(strDateFormat);
            statistics.uintSessionLength++;
            statistics.uintTotalTime++;
            UpdateReminders();
            UpdateToDos();
            CheckForSchedules(sender, e);
            ManualMonitor();
            CheckIfUnproductive();
            TickStatTimes();
        }

        private void UpdateReminders()
        {
            // Input: Everything from 'reminders.txt' save for the string marking the end of the file.
            // Output: Reminders for today displayed on the main screen.
            lstboxCurrentReminders.Items.Clear();
            using (StreamReader ReminderReader = new StreamReader("reminders.txt"))
            {
                while ((strCurrentReminderToAdd = ReminderReader.ReadLine()) != "thisistheendofthefile")
                {
                    if (strCurrentReminderToAdd.Remove(10, strCurrentReminderToAdd.Length - 10) == DateTime.Today.ToString("dd/MM/yyyy"))
                    {
                        lstboxCurrentReminders.Items.Add(strCurrentReminderToAdd.Remove(0, 12));
                    }
                }
            }
        }

        private void UpdateToDos()
        {
            // Input: Everything from 'todos.txt' save for the string marking the end of the file.
            // Output: To-dos displayed on the main screen.
            lstboxToDoList.Items.Clear();
            using (StreamReader ToDoReader = new StreamReader("todos.txt"))
            {
                while ((strToDoToAdd = ToDoReader.ReadLine()) != "thisistheendofthefile")
                {
                    lstboxToDoList.Items.Add(strToDoToAdd);
                }
            }
        }

        private void CheckForSchedules(object sender, EventArgs e)
        {
            // Input: All the lists from frmSchedule.
            // Output: boolMonitoringOn turned to true, or boolBreakPeriod turned to true.
            // Checks for the first scheduled work/break period which matches the current day and time period, and then turns monitoring on or forces monitoring to stay off if monitoring
            // isn't manual.
            int intScheduleLocation = 0;
            foreach (string ScheduleDay in SchedLists.listScheduleDay)
            {
                if (DateTime.Today.ToString("dddd") == ScheduleDay)
                {
                    int intSchedStartHour = Convert.ToInt32(SchedLists.listScheduleStart.ElementAt(intScheduleLocation).Remove(2, 3));
                    int intSchedStartMin = Convert.ToInt32(SchedLists.listScheduleStart.ElementAt(intScheduleLocation).Remove(0, 3));
                    int intSchedEndHour = Convert.ToInt32(SchedLists.listScheduleEnd.ElementAt(intScheduleLocation).Remove(2, 3));
                    int intSchedEndMin = Convert.ToInt32(SchedLists.listScheduleEnd.ElementAt(intScheduleLocation).Remove(0, 3));
                    DateTime dtSchedStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, intSchedStartHour, intSchedStartMin, 0);
                    DateTime dtSchedEnd = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, intSchedEndHour, intSchedEndMin, 0);
                    if (DateTime.Compare(DateTime.Now, dtSchedStart) > 0 && DateTime.Compare(DateTime.Now, dtSchedEnd) < 0)
                    {
                        tsTimeLeft = new TimeSpan(intSchedEndHour - DateTime.Now.Hour, intSchedEndMin - DateTime.Now.Minute, 0 - DateTime.Now.Second);
                        // Schedules added in runtime that pass the schedule day conditional
                        // and the start/end schedule conditional throw an ArgumentOutOfRangeException. Fix that.
                        if (schedule.listSchedules.ElementAt(intScheduleLocation).StartsWith("(Work)") && !boolManualMonitor)
                        {
                            lblMonitoringStatus.Text = "Monitoring Active";
                            boolBreakPeriod = false;
                            boolMonitoringOn = true;
                        }
                        else if (schedule.listSchedules.ElementAt(intScheduleLocation).StartsWith("(Break)") && !boolManualMonitor)
                        {
                            if (!boolBreakPeriod)
                            {
                                statistics.uintBreaksUsed++;
                            }
                            lblMonitoringStatus.Text = "Break Period Active";
                            boolBreakPeriod = true;
                            boolMonitoringOn = false;
                            statistics.uintTimeOnBreak++;
                        }
                        lblTimer.Visible = true;
                        lblTimer.Text = tsTimeLeft.ToString() + " left";
                        break;
                    }
                    else if (!boolManualMonitor)
                    {
                        lblMonitoringStatus.Text = "Monitoring Inactive";
                        boolBreakPeriod = false;
                        boolMonitoringOn = false;
                        lblTimer.Visible = false;
                    }
                }
                else if (!boolManualMonitor)
                {
                    lblMonitoringStatus.Text = "Monitoring Inactive";
                    boolBreakPeriod = false;
                    boolMonitoringOn = false;
                    lblTimer.Visible = false;
                }
                intScheduleLocation++;
            }
        }

        private void ManualMonitor()
        {
            // Input: Validated timer from frmMonitor.
            // Output: Timed monitoring.
            if (boolManualMonitor && boolMonitoringOn && !boolManualTimerEnded)
            {
                tsManualTimeLeft = dtMonitorAddedEnd.Subtract(DateTime.Now);
                if (DateTime.Compare(dtMonitorAddedEnd, DateTime.Now) > 0)
                {
                    lblMonitoringStatus.Text = "Monitoring Active";
                    lblTimer.Visible = true;
                    tsManualTimeLeft = TimeSpan.FromSeconds(Math.Round(tsManualTimeLeft.TotalSeconds));
                    lblTimer.Text = tsManualTimeLeft.ToString() + " left";
                }
                else
                {
                    lblMonitoringStatus.Text = "Monitoring Inactive";
                    lblTimer.Visible = false;
                    boolManualMonitor = false;
                    boolMonitoringOn = false;
                    boolManualTimerEnded = true;
                }
            }
        }

        private void CheckIfUnproductive()
        {
            // Checks if the user is being unproductive (with accordance to listAppBlacklist in frmLists).
            Process[] ProcessArray = Process.GetProcesses();
            if (boolMonitoringOn)
            {
                foreach (Process ProcessToCheck in ProcessArray)
                {
                    foreach (string strApplicationToCheck in lists.listAppBlacklist)
                    {
                        if (ProcessToCheck.ProcessName.ToLower().Contains(strApplicationToCheck))
                        {
                            boolUnproductive = true;
                            break;
                        }
                        else if (strApplicationToCheck == lists.listAppBlacklist.ElementAt(lists.listAppBlacklist.Count - 1))
                        {
                            // If none of the blacklisted applications are running (i.e. the string reaches the end of the list), boolUnproductive returns false.
                            boolUnproductive = false;
                        }
                    }
                    if (boolUnproductive)
                    {
                        break;
                    }
                }
            }
            else
            {
                boolUnproductive = false;
            }
        }

        public void TickStatTimes()
        {
            // Ticks the amount of time being monitored (productive, unproductive and total).
            if (boolMonitoringOn)
            {
                if (!boolUnproductive)
                {
                    // Ticks productive time.
                    statistics.uintTimeProductive++;
                    boolAttemptUnproductive = false;
                }
                else if (boolUnproductive)
                {
                    // Ticks unproductive time.
                    if (!boolAttemptUnproductive)
                    {
                        // Increments number of attempts to be unproductive if it hasn't been incremented already.
                        boolAttemptUnproductive = true;
                        statistics.uintAttemptUnproductive++;
                        MessageBox.Show("An unproductive action has been detected. Please close the blacklisted application.", "You are being unproductive!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    statistics.uintTimeUnproductive++;
                }
                statistics.uintTimeMonitored = statistics.uintTimeProductive + statistics.uintTimeUnproductive;
            }
            else
            {
                boolAttemptUnproductive = false;
            }
        }

        public void IncrementStat(string strSender)
        {
            // Increments frmStatistics's uintRemindersMade or ToDosMade.
            if (strSender == "reminder")
            {
                statistics.uintRemindersMade++;
            }
            else if (strSender == "todo")
            {
                statistics.uintToDosMade++;
            }
        }
    }
}
