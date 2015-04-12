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
    public partial class evntForm : Form
    {
        public static bool eventAddTest = false;
        
        public evntForm()
        {
            InitializeComponent();
            eventAddTest = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.evntList.Add(new Evnt());
            Form1.evntList[Form1.k].EvntTitle = titleBox.Text;
            Form1.evntList[Form1.k].EvntDesc = descBox.Text;
            Form1.evntList[Form1.k].StartEvnt = startEvntSelect.Value;
            Form1.evntList[Form1.k].EndEvnt = endEvntSelect.Value;
            Form1.evntList[Form1.k].StartTime = startTimeSelect.Value;
            Form1.evntList[Form1.k].EndTime = endTimeSelect.Value;

            eventAddTest = true;
            this.Close();
        }
    }
}
