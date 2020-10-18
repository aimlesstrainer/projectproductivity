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

namespace Project_Productivity
{
    public partial class frmSchedule : Form
    {
        public List<string> listSchedules = new List<string>();
        bool boolNoExceptions = true;
        string strPeriodType, strStartTime, strEndTime, strScheduleToRead;
        public frmSchedule()
        {
            InitializeComponent();
        }


        public void frmSchedule_Load(object sender, EventArgs e)
        {
            // Loads the schedules from schedules.txt and displays them in the list box.
            listSchedules.Clear();
            ScheduleLists.listScheduleDay.Clear();
            ScheduleLists.listScheduleStart.Clear();
            ScheduleLists.listScheduleEnd.Clear();
            using (StreamReader ScheduleReader = new StreamReader("schedules.txt"))
            {
                while ((strScheduleToRead = ScheduleReader.ReadLine()) != "thisblockoftexthasended")
                {
                    listSchedules.Add(strScheduleToRead);
                }
                while ((strScheduleToRead = ScheduleReader.ReadLine()) != "thisblockoftexthasended")
                {
                    ScheduleLists.listScheduleDay.Add(strScheduleToRead);
                }
                while ((strScheduleToRead = ScheduleReader.ReadLine()) != "thisblockoftexthasended")
                {
                    ScheduleLists.listScheduleStart.Add(strScheduleToRead);
                }
                while ((strScheduleToRead = ScheduleReader.ReadLine()) != "thisblockoftexthasended")
                {
                    ScheduleLists.listScheduleEnd.Add(strScheduleToRead);
                }
            }
            UpdateListBoxes();
        }

        private void btnScheduleAdd_Click(object sender, EventArgs e)
        {
            // Adds the schedule to the lists and displays it in the list box.
            ValidateTimes();
            if (boolNoExceptions)
            {
                if (radWork.Checked)
                {
                    strPeriodType = "Work";
                }
                else if (radBreak.Checked)
                {
                    strPeriodType = "Break";
                }
                listSchedules.Add("(" + strPeriodType + ") " + comDay.Text + ", " + strStartTime + "-" + strEndTime);
                ScheduleLists.listScheduleDay.Add(comDay.Text);
                ScheduleLists.listScheduleStart.Add(strStartTime);
                ScheduleLists.listScheduleEnd.Add(strEndTime);
                UpdateListBoxes();
            }
        }

        private void btnScheduleRemove_Click(object sender, EventArgs e)
        {
            // Removes the selected schedule from the lists and the list box.
            if (lstboxScheduled.SelectedIndex != -1)
            {
                int intScheduleSelectedIndex = lstboxScheduled.SelectedIndex;
                listSchedules.RemoveAt(intScheduleSelectedIndex);
                ScheduleLists.listScheduleDay.RemoveAt(intScheduleSelectedIndex);
                ScheduleLists.listScheduleStart.RemoveAt(intScheduleSelectedIndex);
                ScheduleLists.listScheduleEnd.RemoveAt(intScheduleSelectedIndex);
                UpdateListBoxes();
            }
        }

        private void btnScheduleReturn_Click(object sender, EventArgs e)
        {
            // Returns to frmMain after writing the schedules to schedules.txt.
            using (StreamWriter ScheduleWriter = new StreamWriter("schedules.txt"))
            {
                foreach (string strSchedule in listSchedules)
                {
                    ScheduleWriter.WriteLine(strSchedule);
                }
                ScheduleWriter.WriteLine("thisblockoftexthasended");

                foreach (string strScheduleDay in ScheduleLists.listScheduleDay)
                {
                        ScheduleWriter.WriteLine(strScheduleDay);
                }
                ScheduleWriter.WriteLine("thisblockoftexthasended");

                foreach (string strScheduleStart in ScheduleLists.listScheduleStart)
                {
                        ScheduleWriter.WriteLine(strScheduleStart);
                }
                ScheduleWriter.WriteLine("thisblockoftexthasended");

                foreach (string strScheduleEnd in ScheduleLists.listScheduleEnd)
                {
                        ScheduleWriter.WriteLine(strScheduleEnd);
                }
                ScheduleWriter.WriteLine("thisblockoftexthasended");

            }
            Close();
        }

        private void ValidateTimes()
        {
            // Validates the inputs in the text boxes.
            boolNoExceptions = true;

            if (txtStartTime.Text.Length == 4)
            { strStartTime = "0" + txtStartTime.Text; }
            else
            { strStartTime = txtStartTime.Text; }

            if (txtEndTime.Text.Length == 4)
            { strEndTime = "0" + txtEndTime.Text; }
            else
            { strEndTime = txtEndTime.Text; }

            if (txtStartTime.Text != "" && txtEndTime.Text != "")
            {
                try
                {
                    DateTime dtStartTry = DateTime.ParseExact(strStartTime, "HH:mm", null);
                    DateTime dateTimeEndTry = DateTime.ParseExact(strEndTime, "HH:mm", null);
                }
                catch (FormatException)
                {
                    boolNoExceptions = false;
                    MessageBox.Show("Input is invalid. Acceptable inputs are 24-hour times from 00:00 up until 23:59," +
                        " with the end time being later than the start time.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (boolNoExceptions)
                {
                    DateTime dtStart = DateTime.ParseExact(strStartTime, "HH:mm", null);
                    DateTime dateTimeEnd = DateTime.ParseExact(strEndTime, "HH:mm", null);
                    if (dateTimeEnd - dtStart < new TimeSpan(0, 0, 1))
                    {
                        boolNoExceptions = false;
                        MessageBox.Show("Input is invalid. Acceptable inputs are 24-hour times from 00:00 up until 23:59, " +
                            "with the end time being later than the start time.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                boolNoExceptions = false;
            }
        }

        private void UpdateListBoxes()
        {
            // Displays the schedules in the list box.
            lstboxScheduled.Items.Clear();
            foreach (string strSchedule in listSchedules)
            {
                lstboxScheduled.Items.Add(strSchedule);
            }
        }       

        public class ScheduleLists
        {
            public static List<string> listScheduleDay = new List<string>();
            public static List<string> listScheduleStart = new List<string>();
            public static List<string> listScheduleEnd = new List<string>();
        }
    }
}
