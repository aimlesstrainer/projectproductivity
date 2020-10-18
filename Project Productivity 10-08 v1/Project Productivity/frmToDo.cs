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
    public partial class frmToDo : Form
    {
        public List<string> listToDo = new List<string>();
        frmStatistics statistics = new frmStatistics();
        private frmMain main;
        string strToDoToAdd;
        public frmToDo(frmMain ParentForm)
        {
            InitializeComponent();
            main = ParentForm;
            // Reads every line in todos.txt and adds it to the list box and listToDo if it is not the end string (thisistheendofthefile).
            using (StreamReader ToDoReader = new StreamReader("todos.txt"))
            {
                while ((strToDoToAdd = ToDoReader.ReadLine()) != "thisistheendofthefile")
                {
                    listToDo.Add(strToDoToAdd);
                }
            }
            UpdateListBoxes();
        }

        private void btnToDoAdd_Click(object sender, EventArgs e)
        {
            // Adds the to-do to the lists, displays it on the list box, and increments the 'To-Dos Made' statistic.
            if (txtToDo.Text != "")
            {
                listToDo.Add(txtToDo.Text);
                txtToDo.Text = "";
                UpdateListBoxes();
                main.IncrementStat("todo");
            }
        }

        private void btnToDoRemove_Click(object sender, EventArgs e)
        {
            // Removes the selected to-do from the lists and the list box.
            if (lstboxToDos.SelectedIndex != -1)
            {
                int intToDoSelectedIndex = lstboxToDos.SelectedIndex;
                lstboxToDos.Items.RemoveAt(intToDoSelectedIndex);
                listToDo.RemoveAt(intToDoSelectedIndex);
            }
        }

        private void btnToDoReturn_Click(object sender, EventArgs e)
        {
            // Closes the form and writes every element in the list to a text file.
            using (StreamWriter ToDoWriter = new StreamWriter("todos.txt"))
            {
                foreach (string ToDo in listToDo)
                {
                    ToDoWriter.WriteLine(ToDo);
                }
                ToDoWriter.WriteLine("thisistheendofthefile");
            }
            Close();
        }

        private void UpdateListBoxes()
        {
            // Sorts the list (via method QuickSort) and adds the elements to lstboxToDos.
            if (listToDo.Count > 0)
            {
                QuickSort(listToDo, 0, 0, listToDo.Count);
            }
            lstboxToDos.Items.Clear();
            foreach (string ToDo in listToDo)
            {
                lstboxToDos.Items.Add(ToDo);
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
    }
}
