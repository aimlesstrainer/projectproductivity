using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Project_Productivity
{
    public partial class frmLists : Form
    {
        public List<string> listAppBlacklist = new List<string>();
        public List<string> listWebsites = new List<string>();
        string strItemToAdd;
        public frmLists()
        {
            InitializeComponent();
            txtSearchBlacklist.TextChanged += SearchQueryChanged;
        }

        public void frmLists_Load(object sender, EventArgs e)
        {
            // Loads everything from lists.txt and displays it in the list boxes.
            listAppBlacklist.Clear();
            listWebsites.Clear();
            using (StreamReader ListReader = new StreamReader("lists.txt"))
            {
                while ((strItemToAdd = ListReader.ReadLine()) != "thisblockoftexthasended")
                {
                    listAppBlacklist.Add(strItemToAdd);
                }
                while ((strItemToAdd = ListReader.ReadLine()) != "thisblockoftexthasended")
                {
                    listWebsites.Add(strItemToAdd);
                }
            }
            UpdateListBoxes();
        }

        private void btnWebsiteAdd_Click(object sender, EventArgs e)
        {
            // Adds a website to lstboxWebsites and listWebsites.
            if (txtWebsite.Text != "")
            {
                listWebsites.Add(txtWebsite.Text);
                txtWebsite.Text = "";
                QuickSort(listWebsites, 0, 0, listWebsites.Count);
                UpdateListBoxes();
            }
        }

        private void btnWebsiteRemove_Click(object sender, EventArgs e)
        {
            // Removes a website from lstboxWebsites and listWebsites.
            if (lstboxWebsites.SelectedIndex != -1)
            {
                int intSelectedIndex = lstboxWebsites.SelectedIndex;
                listWebsites.RemoveAt(intSelectedIndex);
                UpdateListBoxes();
            }
        }

        private void btnListsReturn_Click(object sender, EventArgs e)
        {
            // Writes all the lists to lists.txt, then closes the form.
            using (StreamWriter ListWriter = new StreamWriter("lists.txt"))
            {
                foreach (string strBlacklist in listAppBlacklist)
                {
                    ListWriter.WriteLine(strBlacklist);
                }
                ListWriter.WriteLine("thisblockoftexthasended");

                foreach (string strWebsite in listWebsites)
                {
                    ListWriter.WriteLine(strWebsite);
                }
                ListWriter.WriteLine("thisblockoftexthasended");
            }
            Close();
        }

        private void UpdateListBoxes()
        {
            // Updates the list boxes when a change has been made.
            lstboxAppBlacklist.Items.Clear();
            lstboxWebsites.Items.Clear();
            foreach (string strBlackList in listAppBlacklist)
            {
                lstboxAppBlacklist.Items.Add(strBlackList);
            }
            foreach (string strWebsite in listWebsites)
            {
                lstboxWebsites.Items.Add(strWebsite);
            }
        }

        private void QuickSort(List<string> list, int intStart, int intFinal, int intPartitionLength)
        {
            // Inputs: List to be sorted, starting index for the partition, final index, and the length of the partition.
            // Output: Sorted list.
            // Sorts the list by alphabetical order.
            int intListLength = list.Count;
            string strPivot = list.ElementAt(intStart);
            if (intFinal == 0)
            {
                intFinal = intListLength - 1;
            }
            int intPartition1 = intStart; int intPartition2 = intFinal;
            if (intPartitionLength >= 1)
            {
                while (intStart <= intFinal)
                {
                    while (String.Compare(list.ElementAt(intStart), strPivot) < 0)
                    {
                        intStart++;
                    }
                    while (String.Compare(list.ElementAt(intFinal), strPivot) > 0)
                    {
                        intFinal--;
                    }
                    if (intStart <= intFinal)
                    {
                        // Swaps the two strings that need to be swapped.
                        string strToDo1 = list.ElementAt(intStart);
                        string strToDo2 = list.ElementAt(intFinal);
                        list[intStart] = strToDo2;
                        list[intFinal] = strToDo1;
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

        private void SearchQueryChanged(object sender, EventArgs e)
        {
            // Event handler to execute a linear search algorithm.
            LinearSearch(listAppBlacklist, lstboxAppBlacklist, txtSearchBlacklist.Text);
        }

        private void LinearSearch(List<string> list, ListBox listbox, string strQuery)
        {
            // Linear search algorithm.
            // Input: List to be sorted, ListBox to which the results will be outputted, and search query as string.
            // Output: Search results into a ListBox.
            List<string> listTempList = new List<string>();
            foreach (string strSearchResult in list)
            {
                if (strSearchResult.Contains(strQuery))
                {
                    listTempList.Add(strSearchResult);
                }
            }
            listbox.Items.Clear();
            foreach (string strItemToAdd in listTempList)
            {
                listbox.Items.Add(strItemToAdd);
            }
        }

        private void btnBlacklistAdd_Click(object sender, EventArgs e)
        {
            // Adds the to-do to the lists and displays it on the list box.
            if (txtBlacklist.Text != "")
            {
                listAppBlacklist.Add(txtBlacklist.Text);
                txtBlacklist.Text = "";
                QuickSort(listAppBlacklist, 0, 0, listAppBlacklist.Count);
                UpdateListBoxes();
            }
        }

        private void btnBlacklistRemove_Click(object sender, EventArgs e)
        {
            // Removes the selected to-do from the lists and the list box.
            if (lstboxAppBlacklist.SelectedIndex != -1)
            {
                int intToDoSelectedIndex = lstboxAppBlacklist.SelectedIndex;
                lstboxAppBlacklist.Items.RemoveAt(intToDoSelectedIndex);
                listAppBlacklist.RemoveAt(intToDoSelectedIndex);
                QuickSort(listAppBlacklist, 0, 0, listAppBlacklist.Count);
            }
        }
    }
}
