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
    public static class Globals
    {
        

    }
    
    public class Class1
    {
        public static void XMLWriter(object item, string t, string filein)
        {
                       
            System.Xml.Serialization.XmlSerializer writerNoteList = new System.Xml.Serialization.XmlSerializer(typeof(List<Note>));
            System.Xml.Serialization.XmlSerializer writerDueList = new System.Xml.Serialization.XmlSerializer(typeof(List<TaskDue>));
            System.Xml.Serialization.XmlSerializer writerCombList = new System.Xml.Serialization.XmlSerializer(typeof(List<ListStorage>));
            System.Xml.Serialization.XmlSerializer writerevntList = new System.Xml.Serialization.XmlSerializer(typeof(List<Evnt>));

            System.Xml.Serialization.XmlSerializer writerdateList = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            System.Xml.Serialization.XmlSerializer writertitleList = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));


            //System.Xml.Serialization.XmlSerializer collList = new System.Xml.Serialization.XmlSerializer(typeof(object));


            System.IO.StreamWriter file = new System.IO.StreamWriter(@filein + @"\calendarsave"+t+".xml");

            if (t == "N")
            {
                writerNoteList.Serialize(file, item);
            }
            else if (t == "D")
            {
                writerDueList.Serialize(file, item);
            }
            else if (t == "C")
            {
                writerCombList.Serialize(file, item);
            }
            else if (t == "E")
            {
                writerevntList.Serialize(file, item);
            }
            //else if (t == "d")
            //{
            //    writerdateList.Serialize(file, item);
            //}
            //else if (t == "t")
            //{
            //    writertitleList.Serialize(file, item);
            //}
            //else if (t == "test")
            //{
            //    collList.Serialize(file, item);
            //}

            file.Close();

        }

        public static void XMLReader(string t, string filein)
        {
            
            //System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Book));

            System.Xml.Serialization.XmlSerializer readNoteList = new System.Xml.Serialization.XmlSerializer(typeof(List<Note>));
            System.Xml.Serialization.XmlSerializer readDueList = new System.Xml.Serialization.XmlSerializer(typeof(List<TaskDue>));
            System.Xml.Serialization.XmlSerializer readCombList = new System.Xml.Serialization.XmlSerializer(typeof(List<ListStorage>));
            System.Xml.Serialization.XmlSerializer readevntList = new System.Xml.Serialization.XmlSerializer(typeof(List<Evnt>));

            System.Xml.Serialization.XmlSerializer readdateList = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            System.Xml.Serialization.XmlSerializer readtitleList = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));

            System.IO.StreamReader file = new System.IO.StreamReader(@filein + @"\calendarsave" + t + ".xml");

            if (t == "N")
            {
                Form1.noteList = (List<Note>)readNoteList.Deserialize(file);
            }
            else if (t == "D")
            {
                Form1.dueList = (List<TaskDue>)readDueList.Deserialize(file);
            }
            else if (t == "C")
            {
                Form1.combList = (List<ListStorage>)readCombList.Deserialize(file);
            }
            else if (t == "E")
            {
                Form1.combList = (List<Evnt>)readCombList.Deserialize(file);
            }
            //else if (t == "d")
            //{
            //    Form1.dateList = (List<string>)readdateList.Deserialize(file);
            //}
            //else if (t == "t")
            //{
            //    //readtitleList.Serialize(file, item);
            //    Form1.titleList = (List<string>)readtitleList.Deserialize(file);
            //}

            file.Close();
        }
        
        public int daysAdjust(string day)
        {
            //TextBox[] tempTArr;
            int dVar = 0;
            if (day == "Sunday")
            {
                dVar = 0;
            }

            else if (day == "Monday")
            {
                dVar = 1;
            }

            else if (day == "Tuesday")
            {
                dVar = 2;
            }

            else if (day == "Wednesday")
            {
                dVar = 3;
            }

            else if (day == "Thursday")
            {
                dVar = 4;
            }

            else if (day == "Friday")
            {
                dVar = 5;
            }

            else if (day == "Saturday")
            {
                dVar = 6;
            }


            return dVar;
        }
    }
}
