using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Student : Person
    {
        public Student(string n, string r, int a, string c)
        {
            Name = n;
            Role = r;
            Age = a;
            Classroom = c;
        }
   
        public override void PrintInfo()
        {
            Console.WriteLine("Student:\nName: {0} Role: {1} Age: {2} Classroom: {3}", Name, Role, Age, Classroom);
        }
    }
}
