using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Productivity
{
    public partial class frmMonitor : Form
    {
        int intHour, intMin;
        bool boolNoExceptions;
        public TimeSpan tsMonitorTime;
        private frmMain main;
        public frmMonitor(frmMain ParentForm)
        {
            InitializeComponent();
            main = ParentForm;
        }

        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            // Displays the timer or hides it from view depending on the checked status.
            if (chkTimer.Checked)
            {
                txtHour.Visible = true;
                txtMin.Visible = true;
                lblColon1.Visible = true;
                lblHour.Visible = true;
                lblMin.Visible = true;
            }
            else
            {
                txtHour.Visible = false;
                txtMin.Visible = false;
                lblColon1.Visible = false;
                lblHour.Visible = false;
                lblMin.Visible = false;
            }
        }

        private void btnMonitorReturn_Click(object sender, EventArgs e)
        {
            // Returns to frmMain.
            main.boolManualMonitor = false;
            Close();
        }

        private void btnMonitorStart_Click(object sender, EventArgs e)
        {
            // Starts the monitoring function.
            if (chkTimer.Checked && txtHour.Text + txtMin.Text != "0000")
            {
                // Starts the monitoring function with a timer.
                boolNoExceptions = true;
                try
                {
                    intHour = Convert.ToInt32(txtHour.Text);
                    intMin = Convert.ToInt32(txtMin.Text);
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException)
                {
                    boolNoExceptions = false;
                    MessageBox.Show("The input is invalid." + Environment.NewLine + "Acceptable inputs are whole numbers from 0 hours and 1 minute up to 71 hours and 59 minutes.", "Error!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if ((intHour > 71 || intMin > 59 || intHour + intMin == 0) && boolNoExceptions == true)
                {
                    MessageBox.Show("The input is invalid." + Environment.NewLine + "Acceptable inputs are whole numbers from 0 hours and 1 minute up to 71 hours and 59 minutes.", "Error!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (boolNoExceptions == true)
                {
                    main.boolMonitoringOn = true;
                    main.boolManualMonitor = true;
                    main.boolManualTimerEnded = false;
                    tsMonitorTime = new TimeSpan(intHour, intMin, 0);
                    main.dtMonitorEnd = DateTime.Now;
                    main.dtMonitorAddedEnd = main.dtMonitorEnd.Add(tsMonitorTime);
                    Close();
                }
            }
            else if (!chkTimer.Checked)
            {
                // Starts the monitoring function without a timer.
                main.boolMonitoringOn = true;
                main.boolManualMonitor = true;
                main.lblMonitoringStatus.Text = "Monitoring Active";
                Close();
            }
        }
    }
}
