using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Console.WriteLine("Turning the radio on. Changing volume to 5 and frequency to 8000.");
            radio.IsOn = true;
            radio.Volume = 5;
            radio.Frequency = 8000.0F;
            Console.WriteLine("Radio is on: {0}\nRadio volume: {1}\nRadio frequency: {2}\n",radio.IsOn,radio.Volume,radio.Frequency);

            Console.WriteLine("Turning the radio off. Attempting to change volume to 10 and frequency to 20000.");
            radio.IsOn = false;
            radio.Volume = 10; //value out of bounds, notifies the user
            radio.Frequency = 20000.0F;
            Console.WriteLine("Radio is on: {0}\nRadio volume: {1}\nRadio frequency: {2}\n", radio.IsOn, radio.Volume, radio.Frequency);
            Console.WriteLine("Turning the radio off (again).");
            radio.IsOn = false; //trying to turn off the radio when it's already off, informs the user that it's already off
            Console.ReadKey(true);
        }
    }
}
