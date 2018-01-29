using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Employee : Person
    {
        public Employee(string n, string p, double s)
        {
            Name = n;
            Profession = p;
            Salary = s;
        }
   
        public override void PrintInfo()
        {
            Console.WriteLine("Employee:\nName: {0} Profession: {1} Salary: {2}", Name, Profession, Salary);
        }
    }
}
