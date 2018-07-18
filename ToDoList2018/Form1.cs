using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ToDo newToDoListItem = new ToDo();

            newToDoListItem.TaskID = "TASK" + DateTime.Now.ToString("YYYYMMDD-HHmmssfff");
=======
            /*//ToDo newToDoListItem = new ToDo();
            newToDoListItem.TaskID = DateTime.Now.ToString("YYYYMMDD-HHmmssfff");
>>>>>>> 3abcb111ac3ddda55a2635581e555ee41e35cc30
            newToDoListItem.TaskDescription = textBox1.Text;
            newToDoListItem.CreatedDate = DateTime.Now;
            newToDoListItem.ExpiryDate = dateTimePicker1.Value;
            newToDoListItem.Status = "Pending";

            listView1.View = View.Details;

            ListViewItem lvItem = new ListViewItem();
            lvItem.Text = "TASK" + DateTime.Now.ToString("YYYYMMDD-HHmmssfff");
            lvItem.SubItems.Add(textBox1.Text);
            lvItem.SubItems.Add(newToDoListItem.CreatedDate.ToString());
            lvItem.SubItems.Add(newToDoListItem.ExpiryDate.ToString());
            lvItem.SubItems.Add(newToDoListItem.Status.ToString());

            listView1.Items.Add(lvItem);
        }

        private void amendBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[3].Text = dateTimePicker1.Value.ToString();
                listView1.SelectedItems[0].SubItems[4].Text = statusDrpDown.SelectedItem.ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusDrpDown.Text = "";

            if (listView1.SelectedItems.Count > 0)
            {
                string selectedID = listView1.SelectedItems[0].Text;
                string selectedTaskDesc = listView1.SelectedItems[0].SubItems[1].Text;
                string dueDateSelected = listView1.SelectedItems[0].SubItems[3].Text;
                string statusSelected = listView1.SelectedItems[0].SubItems[4].Text;

                textBox1.Text = selectedTaskDesc;
                dateTimePicker1.Value = DateTime.Parse(dueDateSelected);
                statusDrpDown.SelectedText = statusSelected;
            }
        }

<<<<<<< HEAD
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusDrpDown.SelectedIndex = 0;
=======
            listView1.Items.Add()*/
>>>>>>> 3abcb111ac3ddda55a2635581e555ee41e35cc30
        }
    }
}
