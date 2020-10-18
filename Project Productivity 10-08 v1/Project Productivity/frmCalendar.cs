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
    public partial class frmCalendar : Form
    {
        int intDay = 0;
        int intDateOffset;
        DateTime dtCalendar = DateTime.Today;
        public frmCalendar()
        {
            InitializeComponent();
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {
            // Loads the calendar month of the current one.
            UpdateCalendar();
        }

        private void btnCalendarReturn_Click(object sender, EventArgs e)
        {
            // Returns to frmMain.
            Close();
        }

        private void btnMonthLeft_Click(object sender, EventArgs e)
        {
            // Moves back one month.
            dtCalendar = dtCalendar.AddMonths(-1);
            UpdateCalendar();
            
        }

        private void btnMonthRight_Click(object sender, EventArgs e)
        {
            // Moves forward one month.
            dtCalendar = dtCalendar.AddMonths(1);
            UpdateCalendar();
        }

        private void UpdateCalendar()
        {
            // Updates the calendar for the given month and year.
            string strReminderToCheck;
            foreach (var picDayToClear in Controls)
            {
                // Clears all the images.
                var picDay = picDayToClear as PictureBox;
                if (picDay is PictureBox)
                {
                    picDay.Image = null;
                }
            }
            foreach (var lblDayToClear in Controls)
            {
                // Clears all the text off of every label (except the top label, and the top labels of each column).
                var lblDay = lblDayToClear as Label;
                if (lblDay is Label)
                {
                    if (lblDay.Tag != null)
                    {
                        lblDay.Text = "";
                    }
                }
            }
            bool boolDateOffsetted = false;
            lblCalendarMonth.Text = dtCalendar.ToString("MMMM yyyy");
            for (intDay = 1; intDay <= DateTime.DaysInMonth(dtCalendar.Year, dtCalendar.Month); intDay++)
            {
                DateTime dtDay = new DateTime(dtCalendar.Year, dtCalendar.Month, intDay);
                if (!boolDateOffsetted)
                {
                    // Offsets the dates on the calendar by a certain amount depending on the first day of the month.
                    intDateOffset = (int)dtDay.DayOfWeek;
                    boolDateOffsetted = true;
                }
                foreach (var picDayToFill in Controls)
                {
                    // Fills in every (valid) PictureBox with an image.
                    var picDay = picDayToFill as PictureBox;
                    if (picDay is PictureBox)
                    {
                        if (intDay + intDateOffset == Convert.ToInt32(picDay.Tag))
                        {
                            foreach (var lblDayToWrite in Controls)
                            {
                                // Writes the date of the calendar month in the top-left of the PictureBox.
                                var lblDay = lblDayToWrite as Label;
                                if (lblDay is Label)
                                {
                                    if (lblDay.Tag == picDay.Tag)
                                    {
                                        lblDay.Text = (Convert.ToInt32(picDay.Tag) - intDateOffset).ToString();
                                        break;
                                    }
                                }
                            }
                            using (StreamReader ReminderReader = new StreamReader("reminders.txt"))
                            {
                                // If a reminder is found on that day, the image will reflect it.
                                while ((strReminderToCheck = ReminderReader.ReadLine()) != "thisistheendofthefile")
                                {
                                    if (strReminderToCheck.Remove(10, strReminderToCheck.Length - 10) == dtDay.ToString("dd/MM/yyyy"))
                                    {
                                        picDay.Image = Properties.Resources.calendar_reminder;
                                        break;
                                    }
                                    else
                                    {
                                        picDay.Image = null;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
