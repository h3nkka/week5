using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Radio
    {
        private bool isOn = false;
        private int volume;
        private float frequency;

        public bool IsOn
        {
            get { return isOn; }
            set
            {
                if (value == true && isOn == true)
                    Console.WriteLine("The radio is already on!\n");
                else if (value == true && isOn == false)
                    isOn = value;
                else if (value == false && isOn == false)
                    Console.WriteLine("The radio is already off!\n");
                else
                    isOn = value;
            }
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 9)
                    volume = value;
                else
                    Console.WriteLine("Volume setting was out of bounds!\n");
            }
        }

        public float Frequency
        {
            get { return frequency; }
            set
            {
                if (value >= 2000.0 && value <= 26000.0)
                    frequency = value;
                else
                    Console.WriteLine("Frequency setting was out of bounds!\n");
            }
        }
    }
}
