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
            string uniqueTaskID = DateTime.Now.ToString("YYYYMMDD-HHmmssfff");

            string taskDescription = textBox1.Text;

            DateTime dateCreated = DateTime.Now;

            DateTime dateExpiry = dateTimePicker1.Value;
        }
    }
}
