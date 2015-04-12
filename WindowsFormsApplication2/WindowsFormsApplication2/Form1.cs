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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
                
        public static List<Note> noteList = new List<Note>();
        public static List<TaskDue> dueList = new List<TaskDue>();
        public static List<ListStorage> combList = new List<ListStorage>();
        public static List<Evnt> evntList = new List<Evnt>();

        public static List<string> dateList = new List<string>(100);
        public static string[] dateArr = new string[100];

        public static int i = 0;
        public static int j = 0;
        public static int k = 0;

        public static List<string> titleList = new List<string>();

        public static DateTime dateNow = DateTime.Now;
        public static int dMonth = dateNow.Month;
        public static DateTime dateFirst = dateNow.AddDays(-dateNow.Day + 1);
        public static string dayFirst = Convert.ToString(dateFirst.DayOfWeek);
        public static TextBox[] calDays = new TextBox[35];

        public static Class1 classOne = new Class1();
        public static int dayFNum = classOne.daysAdjust(dayFirst);

        

        public Form1()
        {
            InitializeComponent();

            
            calDays[0] = textBox1;
            calDays[1] = textBox2;
            calDays[2] = textBox3;
            calDays[3] = textBox4;
            calDays[4] = textBox5;
            calDays[5] = textBox6;
            calDays[6] = textBox7;
            calDays[7] = textBox8;
            calDays[8] = textBox9;
            calDays[9] = textBox10;
            calDays[10] = textBox11;
            calDays[11] = textBox12;
            calDays[12] = textBox13;
            calDays[13] = textBox14;
            calDays[14] = textBox15;
            calDays[15] = textBox16;
            calDays[16] = textBox17;
            calDays[17] = textBox18;
            calDays[18] = textBox19;
            calDays[19] = textBox20;
            calDays[20] = textBox21;
            calDays[21] = textBox22;
            calDays[22] = textBox23;
            calDays[23] = textBox24;
            calDays[24] = textBox25;
            calDays[25] = textBox26;
            calDays[26] = textBox27;
            calDays[27] = textBox28;
            calDays[28] = textBox29;
            calDays[29] = textBox30;
            calDays[30] = textBox31;
            calDays[31] = textBox32;
            calDays[32] = textBox33;
            calDays[33] = textBox34;
            calDays[34] = textBox35;


            for (int i = 0; i < DateTime.DaysInMonth(dateNow.Year, dateNow.Month); i++)
            {
                calDays[i + dayFNum].Text = Convert.ToString(1+i);

            }

            calDays[dateNow.Day+dayFNum-1].BackColor = System.Drawing.Color.AliceBlue;


            
            

        }

        private void AddEvnt(int k)
        {
                     
            int evntMonth = evntList[k].StartEvnt.Month;
            int evntStartDay = evntList[k].StartEvnt.Day;
            int evntEndDay = evntList[k].EndEvnt.Day;
            if (evntMonth == dMonth)
            {
                for (int h = 0; h <= evntEndDay - evntStartDay; h++)
                {
                    List<string> tempSLis = new List<string>();
                    tempSLis.Add(calDays[evntStartDay + dayFNum - 1 + h].Text);
                    tempSLis.Add(evntList[k].EvntTitle);
                    tempSLis.Add("(" + evntList[k].StartTime.Hour.ToString() + ":" + evntList[k].StartTime.Minute.ToString() + ")");
                    string[] tempSArr = tempSLis.ToArray();
                    calDays[evntStartDay + dayFNum - 1 + h].Lines = tempSArr;
                }
                
            }
        }

        private void AddDue(int j)
        {
            titleList.Add(dueList[j].Tasktitle);
            checkedListBox1.Items.Add(dueList[j].Tasktitle);
            combList.Add(new ListStorage(dueList[j].Tasktitle, "due", j));
            //int inPos = titleList.Count();
            dateList.Add(dueList[j].Duedate.ToString("d"));
            dateArr = dateList.ToArray();
            textBox36.Lines = dateArr;

            //Add to Calendar
            int duemonth = dueList[j].Duedate.Month;
            int dueday = dueList[j].Duedate.Day;
            if (duemonth == dMonth)
            {
                List<string> tempSLis = new List<string>();
                tempSLis.Add(calDays[dueday + dayFNum - 1].Text);
                tempSLis.Add(dueList[j].Tasktitle);
                string[] tempSArr = tempSLis.ToArray();
                calDays[dueday + dayFNum - 1].Lines = tempSArr;

                //-> add removal of task to remove checked event!!!!!!!!!!!!!!!!!!!!
            }

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //else ()
            //{

            //}
        }

        private void LoadDues()
        {
            int tempj = 0;
            foreach (TaskDue due in dueList)
            {
                titleList.Add(due.Tasktitle);
                checkedListBox1.Items.Add(due.Tasktitle);
                combList.Add(new ListStorage(due.Tasktitle, "due", tempj));

                dateList.Add(due.Duedate.ToString("d"));
                dateArr = dateList.ToArray();
                textBox36.Lines = dateArr;
                int duemonth = due.Duedate.Month;
                int dueday = due.Duedate.Day;
                if (duemonth == dMonth)
                {
                    List<string> tempSLis = new List<string>();
                    tempSLis.Add(calDays[dueday + dayFNum - 1].Text);
                    tempSLis.Add(due.Tasktitle);
                    string[] tempSArr = tempSLis.ToArray();
                    calDays[dueday + dayFNum - 1].Lines = tempSArr;

                    //-> add removal of task to remove checked event!!!!!!!!!!!!!!!!!!!!
                }
                tempj += 1;
            }
        }

        private void LoadEvnts()
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!In Progress
            int tempk = 0;
            foreach (Evnt evnt in evntList)
            {

            }
        }

        private void AddNote(int i)
        {
            titleList.Add(noteList[i].Notetitle);
            checkedListBox1.Items.Add(noteList[i].Notetitle);
            combList.Add(new ListStorage(noteList[i].Notetitle, "note", i));
            dateList.Add("");
        }

        private void LoadNotes()
        {
            int tempi = 0;
            foreach (Note note in noteList)
            {                
                titleList.Add(note.Notetitle);
                checkedListBox1.Items.Add(note.Notetitle);
                combList.Add(new ListStorage(note.Notetitle, "note", tempi));
                dateList.Add("");
                tempi += 1;
            }
        }

        private void NoteButton_Click(object sender, EventArgs e)
        {

            NoteForm newForm = new NoteForm();
            newForm.ShowDialog();

            if (NoteForm.noteformtest == true)
            {
                AddNote(i);
                i += 1;
            }
            
            
        }

        private void clearChecked_Click(object sender, EventArgs e)
        {
            List<int> checkedarr = new List<int>();
            foreach (int index in checkedListBox1.CheckedIndices)
            {
                checkedarr.Add(Convert.ToInt16(index));
            }
            foreach (int indexchecked in checkedarr.Reverse<int>())
            {
                checkedListBox1.Items.RemoveAt(indexchecked);
                if (combList[indexchecked].Type == "note")
                {
                    noteList.RemoveAt(combList[indexchecked].OuterIndex);
                    i += -1;
                }
                else if (combList[indexchecked].Type == "due")
                {
                    dueList.RemoveAt(combList[indexchecked].OuterIndex);
                    j += -1;
                }

                combList.RemoveAt(indexchecked);
                dateList.RemoveAt(indexchecked);
                dateArr = dateList.ToArray();
                textBox36.Lines = dateArr;
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void DueTaskButton_Click(object sender, EventArgs e)
        {
            DueForm newForm = new DueForm();
            newForm.ShowDialog();

            if (DueForm.dueformtest == true)
            {
                AddDue(j);

                j += 1;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            string filepath = folderBrowserDialog1.SelectedPath;


            Class1.XMLWriter(noteList, "N", filepath);
            Class1.XMLWriter(dueList, "D", filepath);
            Class1.XMLWriter(evntList, "E", filepath);
            //Class1.XMLWriter(combList, "C", filepath);
            //Class1.XMLWriter(dateList, "d", filepath);
            //Class1.XMLWriter(titleList, "t", filepath);

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string filepath = folderBrowserDialog1.SelectedPath;

            Class1.XMLReader("N", filepath);
            Class1.XMLReader("D", filepath);
            Class1.XMLReader("E", filepath);
            //Class1.XMLReader("C", filepath);
            //Class1.XMLReader("d", filepath);
            //Class1.XMLReader("t", filepath);

            LoadDues();
            LoadNotes();
            LoadEvnts();
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            evntForm newForm = new evntForm();
            newForm.ShowDialog();
            if (evntForm.eventAddTest == true)
            {
                AddEvnt(k);

                k += 1;
            }
        }
    }
}
