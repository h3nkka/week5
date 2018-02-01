using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Teacher : Person
    {
        private double salary;

        public Teacher(string n, string r, int a, string c, double s)
        {
            Name = n;
            Role = r;
            Age = a;
            Classroom = c;
            Salary = s;
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Teacher:\nName: {0} Role: {1} Age: {2} Classroom: {3} Salary: {4}", Name, Role, Age, Classroom, Salary);
        }
    }
}
