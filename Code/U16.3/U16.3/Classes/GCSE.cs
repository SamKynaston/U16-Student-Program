using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16._3.Classes
{
    public class GCSE : Course
    {
        public new void setGrade(int newGrade)
        {
            if (newGrade > 0 && newGrade < 10)
            {
                this.Grade = newGrade.ToString();
            } else
            {
                this.Grade = "0";
            }
        }
    }
}
