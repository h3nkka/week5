using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlist = new List<Person>();
            Person teacher = new Teacher("Sensei", "English teacher", 45, "420C", 2350.50);
            Person student1 = new Student("Henri", "ICT student", 22, "330A");
            Person student2 = new Student("Matti", "English student", 18, "420C");
            personlist.Add(teacher);
            personlist.Add(student1);
            personlist.Add(student2);

            foreach (Person person in personlist)
            {
                person.PrintInfo();
            }
            Console.ReadKey(true);
        }
    }
}
