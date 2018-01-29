using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personlist = new List<Person>();
            Person derBoss = new Boss("Kollegah","Der Boss",13337,"Mercedes Benz",420);
            Person employee1 = new Employee("Michele", "Hacker", 4200);
            Person employee2 = new Employee("Jinxy", "Breakdancer", 1337);
            personlist.Add(derBoss);
            personlist.Add(employee1);
            personlist.Add(employee2);

            foreach (Person person in personlist)
            {
                person.PrintInfo();
                employee1.Salary += 200;
            }
            Console.ReadKey(true);
        }
    }
}
