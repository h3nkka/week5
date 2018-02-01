using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class Person
    {
        private string name;
        private string role;
        private string classroom;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Classroom
        {
            get { return classroom; }
            set { classroom = value; }
        }

        public virtual void PrintInfo()
        {

        }
    }
}
