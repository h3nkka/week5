using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Boss : Person
    {
        private string car;
        private double bonus;

        public Boss(string n, string p, double s, string c, double b)
        {
            Name = n;
            Profession = p;
            Salary = s;
            Car = c;
            Bonus = b;
        }
        public string Car
        {
            get { return car; }
            set { car = value; }
        }

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Boss:\nName: {0} Profession: {1} Salary: {2} Car: {3} Bonus: {4}", Name, Profession, Salary, Car, Bonus);
        }
    }
}
