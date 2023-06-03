using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16._3.Classes
{
    public class Course
    {
        public string Title;
        public string Grade;

        public void setTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public void setGrade(string newGrade)
        {
            this.Grade = newGrade;
        }

        public string getTitle()
        { return this.Title; }

        public string getGrade()
        { return this.Grade; }
    }
}
