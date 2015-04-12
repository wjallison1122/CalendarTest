using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DueForm : Form
    {
        public static bool dueformtest = false;

        public DueForm()
        {
            InitializeComponent();
            dueformtest = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.dueList.Add(new TaskDue());
            Form1.dueList[Form1.j].Tasktitle = textBox1.Text;
            Form1.dueList[Form1.j].TaskDesc = textBox2.Text;
            Form1.dueList[Form1.j].Duedate = dateTimePicker1.Value;
            dueformtest = true;

            this.Close();
        }
    }
}
