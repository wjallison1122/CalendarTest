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
    public partial class NoteForm : Form
    {
        public static bool noteformtest = false;

        public NoteForm()
        {
            InitializeComponent();
            noteformtest = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.noteList.Add(new Note());
            Form1.noteList[Form1.i].Notetitle = nTitleBox.Text;
            Form1.noteList[Form1.i].Notedesc = nDesBox.Text;
            noteformtest = true;
            this.Close();
        }
    }
}
