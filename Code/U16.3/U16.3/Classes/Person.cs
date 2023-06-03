using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace U16._3.Classes
{
    public class Person
    {
        public string Name;
        public string ID;
        public string DoB;

        public void setName(string newName)
        {
            this.Name = newName;
        }

        public void setID(string newID)
        {
            this.ID = newID;
        }

        public void setDoB(string newDoB)
        {
            this.DoB = newDoB;
        }

        public string getName()
        { return this.Name; }

        public string getID()
        { return this.ID; }

        public string getDoB()
        { return this.DoB; }
    }
}
