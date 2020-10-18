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
    public partial class frmReminder : Form
    {
        public List<string> listReminders = new List<string>();
        frmStatistics statistics = new frmStatistics();
        private frmMain main;
        string strReminderToAdd;
        public frmReminder(frmMain ParentForm)
        {
            InitializeComponent();
            main = ParentForm;
            // Reads every line in reminders.txt and adds it to the list box and listReminders if it is not the end string (thisistheendofthefile).
            using (StreamReader ReminderReader = new StreamReader("reminders.txt"))
            {
                while ((strReminderToAdd = ReminderReader.ReadLine()) != "thisistheendofthefile")
                {
                    if (DateTime.Compare(Convert.ToDateTime(strReminderToAdd.Remove(10, strReminderToAdd.Length - 10)), DateTime.Today) >= 0)
                    {
                        // Removes reminders previous to the current date.
                        listReminders.Add(strReminderToAdd);
                    }
                }
            }
            AddListElements();
        }

        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            // Adds the reminder to the lists, displays it on the list box, and increments the 'Reminders Made' statistic.
            if (txtReminder.Text != "" && dtpickerReminder.Value.AddMinutes(1) > DateTime.Now)
            {
                listReminders.Add(dtpickerReminder.Value.ToString("dd/MM/yyyy: ") + txtReminder.Text);
                txtReminder.Text = "";
                AddListElements();
                main.IncrementStat("reminder");
            }
            else if (dtpickerReminder.Value.AddMinutes(1) < DateTime.Now)
            {
                MessageBox.Show("You cannot add a reminder for a previous date!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpickerReminder.Value = DateTime.Now;
            }
        }

        private void btnReminderRemove_Click(object sender, EventArgs e)
        {
            // Removes the selected reminder from the lists and the list box.
            if (lstboxReminders.SelectedIndex != -1)
            {
                int intReminderSelectedIndex = lstboxReminders.SelectedIndex;
                lstboxReminders.Items.RemoveAt(intReminderSelectedIndex);
                listReminders.RemoveAt(intReminderSelectedIndex);
                if (listReminders.Count != 0)
                {
                    AddListElements();
                }
            }
        }

        private void btnReminderReturn_Click(object sender, EventArgs e)
        {
            // Closes the form and writes every element in the list to a text file.
            using (StreamWriter ReminderWriter = new StreamWriter("reminders.txt"))
            {
                foreach (string reminder in listReminders)
                {
                    ReminderWriter.WriteLine(reminder);
                }
                ReminderWriter.WriteLine("thisistheendofthefile");
            }
            Close();
        }

        private void AddListElements()
        {
            // Sorts the list (via method QuickSort) and adds the elements to lstboxReminders.
            if (listReminders.Count > 0)
            {
                QuickSort(listReminders, 0, 0, listReminders.Count);
            }
            lstboxReminders.Items.Clear();
            foreach (string reminder in listReminders)
            {
                lstboxReminders.Items.Add(reminder);
            }
        }

        private void QuickSort(List<string> list, int intStart, int intFinal, int intPartitionLength)
        {
            // Inputs: List to be sorted, starting index for the partition, final index, and the length of the partition.
            // Output: Sorted list.
            // Sorts the list by date.
            int intListLength = list.Count;
            DateTime dtPivot = Convert.ToDateTime(list.ElementAt(intStart).Remove(10, list.ElementAt(intStart).Length - 10));
            if (intFinal == 0)
            {
                intFinal = intListLength - 1;
            }
            int intPartition1 = intStart; int intPartition2 = intFinal;
            if (intPartitionLength >= 1)
            {
                while (intStart <= intFinal)
                {
                    while (DateTime.Compare(Convert.ToDateTime(list.ElementAt(intStart).Remove(10, list.ElementAt(intStart).Length - 10)), dtPivot) < 0)
                    {
                        intStart++;
                    }
                    while (DateTime.Compare(Convert.ToDateTime(list.ElementAt(intFinal).Remove(10, list.ElementAt(intFinal).Length - 10)), dtPivot) > 0)
                    {
                        intFinal--;
                    }
                    if (intStart <= intFinal)
                    {
                        // Swaps the two strings that need to be swapped.
                        string strReminder1 = list.ElementAt(intStart);
                        string strReminder2 = list.ElementAt(intFinal);
                        if (DateTime.Compare(Convert.ToDateTime(strReminder1.Remove(10, strReminder1.Length - 10)), Convert.ToDateTime(strReminder2.Remove(10, strReminder2.Length - 10))) != 0)
                        {
                            // If the recorded dates are the same, nothing will be swapped.
                            list[intStart] = strReminder2;
                            list[intFinal] = strReminder1;
                        }
                        intStart++;
                        intFinal--;
                    }
                }
                // Calls more QuickSorts from the created partitions.
                if (intStart < intPartition2)
                {
                    QuickSort(list, intStart, intPartition2, intPartition2 - intStart);
                }
                if (intPartition1 < intFinal)
                {
                    QuickSort(list, intPartition1, intFinal, intFinal - intPartition1);
                }
            }
        }
    }
}
