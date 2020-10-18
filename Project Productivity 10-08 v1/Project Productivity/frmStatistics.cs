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
    public partial class frmStatistics : Form
    {
        public uint uintAttemptUnproductive, uintBreaksUsed, uintRemindersMade, uintToDosMade, uintTimeProductive, uintTimeUnproductive, uintTimeMonitored,
           uintTimeOnBreak, uintSessionLength, uintTotalTime;
        public DateTime dtInitialUse = new DateTime();
        public bool boolIsInitialDay = true;
        public frmStatistics()
        {
            InitializeComponent();
        }

        public void frmStatistics_Load(object sender, EventArgs e)
        {
            // Loads all the statistics into a readable format.
            tmrStatsUpdater.Enabled = true;
            UpdateStats();
        }

        private void btnStatisticsReturn_Click(object sender, EventArgs e)
        {
            // Writes the stats to a text file and closes the form.
            WriteStats();
            Close();
        }

        private void tmrStatsUpdater_Tick(object sender, EventArgs e)
        {
            // Updates statistics once every 0.25 seconds.
            UpdateStats();
        }

        private void UpdateStats()
        {
            // Updates statistics.
            lblTimeProductive.Text = TimeSpan.FromSeconds(uintTimeProductive).ToString();
            lblTimeUnproductive.Text = TimeSpan.FromSeconds(uintTimeUnproductive).ToString();
            lblAttemptUnproductive.Text = uintAttemptUnproductive.ToString();
            lblTimeMonitored.Text = TimeSpan.FromSeconds(uintTimeMonitored).ToString();
            lblBreakPeriodsUsed.Text = uintBreaksUsed.ToString();
            lblTimeOnBreak.Text = TimeSpan.FromSeconds(uintTimeOnBreak).ToString();
            lblRemindersMade.Text = uintRemindersMade.ToString();
            lblToDosMade.Text = uintToDosMade.ToString();
            lblDaysSinceUse.Text = Math.Floor(DateTime.Now.Subtract(dtInitialUse).TotalDays).ToString();
            lblSessionLength.Text = TimeSpan.FromSeconds(uintSessionLength).ToString();
            lblTotalTime.Text = TimeSpan.FromSeconds(uintTotalTime).ToString();
        }

        public void WriteStats()
        {
            // Writes statistics to a text file (as a backup in case the user may quit the main form via the 'X'.)
            using (StreamWriter StatsWriter = new StreamWriter("stats.txt"))
            {
                StatsWriter.WriteLine(boolIsInitialDay);
                StatsWriter.WriteLine(uintTimeProductive);
                StatsWriter.WriteLine(uintTimeUnproductive);
                StatsWriter.WriteLine(uintAttemptUnproductive);
                StatsWriter.WriteLine(uintTimeMonitored);
                StatsWriter.WriteLine(uintBreaksUsed);
                StatsWriter.WriteLine(uintTimeOnBreak);
                StatsWriter.WriteLine(uintRemindersMade);
                StatsWriter.WriteLine(uintToDosMade);
                StatsWriter.WriteLine(dtInitialUse.ToString());
                StatsWriter.WriteLine(uintTotalTime);
            }
        }

        public void ReadStats()
        {
            // Not used here; read in frmMain at startup to load all the statistics.
            using (StreamReader StatsReader = new StreamReader("stats.txt"))
            {
                boolIsInitialDay = Convert.ToBoolean(StatsReader.ReadLine());
                uintTimeProductive = Convert.ToUInt32(StatsReader.ReadLine());
                uintTimeUnproductive = Convert.ToUInt32(StatsReader.ReadLine());
                uintAttemptUnproductive = Convert.ToUInt32(StatsReader.ReadLine());
                uintTimeMonitored = Convert.ToUInt32(StatsReader.ReadLine());
                uintBreaksUsed = Convert.ToUInt32(StatsReader.ReadLine());
                uintTimeOnBreak = Convert.ToUInt32(StatsReader.ReadLine());
                uintRemindersMade = Convert.ToUInt32(StatsReader.ReadLine());
                uintToDosMade = Convert.ToUInt32(StatsReader.ReadLine());
                dtInitialUse = Convert.ToDateTime(StatsReader.ReadLine());
                uintTotalTime = Convert.ToUInt32(StatsReader.ReadLine());
            }
        }
    }
}
