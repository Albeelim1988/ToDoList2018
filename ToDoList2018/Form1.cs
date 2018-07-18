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
            ToDo newToDoListItem = new ToDo();
            newToDoListItem.TaskID = DateTime.Now.ToString("YYYYMMDD-HHmmssfff");
            newToDoListItem.TaskDescription = textBox1.Text;
            newToDoListItem.CreatedDate = DateTime.Now;
            newToDoListItem.ExpiryDate = dateTimePicker1.Value;

            listView1.Columns.Add("Task ID");
            listView1.Columns.Add("Task Description");
            listView1.Columns.Add("Task Created Date");
            listView1.Columns.Add("Task Expiry Date");

            listView1.Items.Add()
        }
    }
}
