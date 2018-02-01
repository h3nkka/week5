using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Vehicle
    {
        private string name;
        private string model;
        private int year;
        private string color;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual void PrintInfo()
        {
            
        }
    }
}
