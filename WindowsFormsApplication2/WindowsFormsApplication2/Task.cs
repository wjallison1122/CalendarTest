using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ListStorage
    {
        private string title;
        private string type;
        private int outerIndex;

        public ListStorage() { }


        public ListStorage(string title, string type, int outerIndex)
        {
            this.title = title;
            this.type = type;
            this.outerIndex = outerIndex;
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int OuterIndex
        {
            get
            {
                return outerIndex;
            }
            set
            {
                outerIndex = value;
            }
        }
    }
    
    public class Note
    {
        private string notetitle;
        private string description;

        public Note() { }

        public Note(string notetitle, string description)
        {
            this.description = description;
            this.notetitle = notetitle;
        }

        public string Notetitle
        {
            get
            {
                return notetitle;
            }
            set
            {
                notetitle = value;
            }
        }

        public string Notedesc
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }
    
    public class Task
    {
        private string tasktitle;
        private string description;

        public Task() { }

        public Task(string tasktitle, string description)
        {
            this.description = description;
            this.tasktitle = tasktitle;
        }

        public string Tasktitle
        {
            get
            {
                return tasktitle;
            }
            set
            {
                tasktitle = value;
            }
        }
        public string TaskDesc
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

    }

    public class TaskDue
    {
        private string tasktitle;
        private string description;
        private DateTime duedate;

        public TaskDue() { }

        public TaskDue(string tasktitle, string description, DateTime duedate)
        {
            this.description = description;
            this.tasktitle = tasktitle;
            this.duedate = duedate;
        }

        public string Tasktitle
        {
            get
            {
                return tasktitle;
            }
            set
            {
                tasktitle = value;
            }
        }
        public string TaskDesc
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public DateTime Duedate
        {
            get
            {
                return duedate;
            }
            set
            {
                duedate = value;
            }
        }
    }

    public class TaskRep
    {

    }

    public class Evnt
    {
        private string evntTitle;
        private string evntDesc;
        private DateTime startEvnt;
        private DateTime endEvnt;
        private DateTime startTime;
        private DateTime endTime;
        // add skip days functionality
        public Evnt() { }
        public Evnt(string evntTitle, string evntDesc, DateTime startEvnt, DateTime endEvnt, DateTime startTime, DateTime endTime)
        {
            this.evntTitle = evntTitle;
            this.evntDesc = evntDesc;
            this.startEvnt = startEvnt;
            this.endEvnt = endEvnt;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public string EvntTitle
        {
            get
            {
                return evntTitle;
            }
            set
            {
                evntTitle = value;
            }
        }
        public string EvntDesc
        {
            get
            {
                return evntDesc;
            }
            set
            {
                evntDesc = value;
            }
        }
        public DateTime StartEvnt
        {
            get
            {
                return startEvnt;
            }
            set
            {
                startEvnt = value;
            }
        }
        public DateTime EndEvnt
        {
            get
            {
                return endEvnt;
            }
            set
            {
                endEvnt = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
    }
}
