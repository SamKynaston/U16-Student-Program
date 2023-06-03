using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16._3.Classes
{
    public class Student : Person
    {
        public Course Course;
        public GCSE[] GCSEs;
        public void setCourse(Course newCourse)
        {
            this.Course = newCourse;
        }
        public void addGCSE(GCSE GCSEToAdd)
        {
            GCSE[] temp = new GCSE[] { };
            temp.Append(GCSEToAdd).ToArray();
            GCSEs = temp;   
        }

        public int getGCSECount()
        {
            if (GCSEs != null)
            {
                return GCSEs.Length;
            } else
            {
                return 0;
            }
        }

        public Course getCourse()
        { return this.Course; }

        public GCSE[] GetGCSEs()
        {
            return this.GCSEs;
        }
    }
}
