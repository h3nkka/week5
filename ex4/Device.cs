using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Device : Item
    {
        private float batteryLength;
        private string manufacturer;

        public Device(string n, string t, int q, float bl, string m)
        {
            Name = n;
            Type = t;
            Quantity = q;
            BatteryLength = bl;
            Manufacturer = m;
        }

        public float BatteryLength
        {
            get { return batteryLength; }
            set { batteryLength = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Device:\nName: {0} Type: {1} Quantity: {2} Battery length: {3} Manufacturer: {4}", Name, Type, Quantity, BatteryLength, Manufacturer);
        }
    }
}
