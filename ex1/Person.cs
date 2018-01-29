using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class Person
    {
        private string name;
        private string profession;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public virtual void PrintInfo()
        {

        }
    }
}
