using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class CD : Item
    {
        private float cdLength;
        private int year;

        public CD(string n, string t, int q, float cl, int y)
        {
            Name = n;
            Type = t;
            Quantity = q;
            CDLength = cl;
            Year = y;
        }

        public float CDLength
        {
            get { return cdLength; }
            set { cdLength = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("CD:\nName: {0} Type: {1} Quantity: {2} Length: {3} Year: {4}", Name, Type, Quantity, CDLength, Year);
        }       
    }
}
