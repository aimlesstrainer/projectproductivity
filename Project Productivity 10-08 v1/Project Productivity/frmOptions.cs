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
    public partial class frmOptions : Form
    {
        string strCurrentPassword;
        string strPasswordToRead;
        private frmMain main;
        public frmOptions(frmMain ParentForm)
        {
            InitializeComponent();
            main = ParentForm;
        }
        
        private void frmOptions_Load(object sender, EventArgs e)
        {
            // Input: Booleans from frmMain (all except boolMonitoringOn).
            // Output: Checked/unchecked boxes and radio buttons according to preset preferences by the user.
            if (main.bool24Hours)
            { chkTimeFormat.Checked = true; }
            else
            { chkTimeFormat.Checked = false; }

            if (main.boolShortDate)
            { chkDateLength.Checked = true; }
            else
            { chkDateLength.Checked = false; }

            if (main.boolMDY)
            { chkMonthPos.Checked = true; }
            else
            { chkMonthPos.Checked = false; }

            switch (main.byteDateSeparator)
            {
                case 0:
                    radDateSlash.Checked = true;
                    break;
                case 1:
                    radDateSlash.Checked = false;
                    radDateDash.Checked = true;
                    break;
                case 2:
                    radDateSlash.Checked = false;
                    radDateDot.Checked = true;
                    break;
            }

            if (main.boolShortYear)
            { chkYearLength.Checked = true; }
            else
            { chkYearLength.Checked = false; }

            if (main.boolYearFirst)
            { chkYearPos.Checked = true; }
            else
            { chkYearPos.Checked = false; }
        }

        private void chkDateLength_CheckedChanged(object sender, EventArgs e)
        {
            // Enables/disables chkYearLength, YearPos, MonthPos and the Radio Buttons based on its checked state.
            if (chkDateLength.Checked == true)
            {
                chkYearLength.Enabled = true;
                chkYearPos.Enabled = true;
                chkMonthPos.Enabled = true;

                radDateDash.Enabled = true;
                radDateDot.Enabled = true;
                radDateSlash.Enabled = true;

            }
            else
            {
                chkYearLength.Enabled = false;
                chkYearLength.Checked = false;
                chkYearPos.Enabled = false;
                chkYearPos.Checked = false;
                chkMonthPos.Enabled = false;
                chkMonthPos.Checked = false;

                radDateDash.Enabled = false;
                radDateDash.Checked = false;
                radDateDot.Enabled = false;
                radDateDot.Checked = false;
                radDateSlash.Enabled = false;
                radDateSlash.Checked = false;

            }
        }

        private void chkYearLength_CheckedChanged(object sender, EventArgs e)
        {
            // Disables/enables the 'year before month/day' checkbox.
            if (chkYearLength.Checked)
            {
                chkYearPos.Enabled = false;
                chkYearPos.Checked = false;
            }
            else
            {
                chkYearPos.Enabled = true;
            }
        }

        // Tooltips for each control except for the separators and 24 hour time.
        private void chkDateLength_MouseHover(object sender, EventArgs e)
        {
            tolDateLength.Show("If checked, the date on the main screen will look like: 20/05/2018." + "If not, then it will look like: Sunday, 20 May 2018.", chkDateLength);
        }
        private void chkMonthPos_MouseHover(object sender, EventArgs e)
        {
            tolMonthPos.Show("If checked, the date will look like: 05/20/2018." + "If not, then it will look like: 20/05/2018.", chkMonthPos);
        }
        private void chkYearLength_MouseHover(object sender, EventArgs e)
        {
            tolYearLength.Show("If checked, the date will look like: 05/20/18." + "If not, then it will look like: 05/20/2018.", chkYearLength);
        }
        private void chkYearPos_MouseHover(object sender, EventArgs e)
        {
            tolYearPos.Show("If checked, the date will look like: 2018/20/05." + "If not, then it will look like: 20/05/2018.", chkYearPos);
        }

        private void txtCurrentPass_TextChanged(object sender, EventArgs e)
        {
            // Hides the current password.
            txtCurrentPass.UseSystemPasswordChar = true;
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            // Hides the new password.
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            // Hides the new password.
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void btnOptionsReturn_Click(object sender, EventArgs e)
        {
            // Writes the configurations to a text file (config.txt) and updates the time displayed in frmMain to suit the new preferences.
            // If the password has been changed, the solution validates the inputs and changes the password if everything is fine.
            if (chkDateLength.Checked)
            { main.boolShortDate = true; }
            else
            { main.boolShortDate = false; }

            if (chkMonthPos.Checked)
            { main.boolMDY = true; }
            else
            { main.boolMDY = false; }

            if (chkYearLength.Checked)
            { main.boolShortYear = true; }
            else
            { main.boolShortYear = false; }

            if (chkYearPos.Checked)
            { main.boolYearFirst = true; }
            else
            { main.boolYearFirst = false; }

            if (chkTimeFormat.Checked)
            { main.bool24Hours = true; }
            else
            { main.bool24Hours = false; }

            if (radDateSlash.Checked)
            { main.byteDateSeparator = 0; }
            else if (radDateDash.Checked)
            { main.byteDateSeparator = 1; }
            else if (radDateDot.Checked)
            { main.byteDateSeparator = 2; }

            using (StreamWriter ConfigWriter = new StreamWriter("config.txt"))
            {
                ConfigWriter.WriteLine(main.bool24Hours);
                ConfigWriter.WriteLine(main.boolShortDate);
                ConfigWriter.WriteLine(main.boolMDY);
                ConfigWriter.WriteLine(main.byteDateSeparator);
                ConfigWriter.WriteLine(main.boolShortYear);
                ConfigWriter.WriteLine(main.boolYearFirst);
            }
            main.frmMain_Load(sender, e);
            Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // Changes the password.
            using (StreamReader LoginReader = new StreamReader("login.txt"))
            {
                strPasswordToRead = LoginReader.ReadLine();
                if (strPasswordToRead == "")
                {
                    strCurrentPassword = "pass";
                }
                else
                {
                    strCurrentPassword = strPasswordToRead;
                }
            }
            if (txtCurrentPass.Text != strCurrentPassword)
            {
                MessageBox.Show("The current password is incorrect. Please re-enter the password and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtNewPass.Text != txtConfirmPass.Text && txtCurrentPass.Text == strCurrentPassword)
            {
                MessageBox.Show("The new password does not match the confirmation. Please re-enter the passwords and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNewPass.Text == txtConfirmPass.Text)
            {
                using (StreamWriter LoginWriter = new StreamWriter("login.txt"))
                {
                    LoginWriter.WriteLine(txtNewPass.Text);
                }
                lblPassChanged.Visible = true;
            }
        }
    }
}
