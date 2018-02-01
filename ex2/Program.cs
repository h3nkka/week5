using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle boat = new Boat("RMS Titanic", "Cruise Ship", 1909, "White", "Steamboat", 3547);
            Vehicle bike1 = new Bicycle("Tunturi", "Tunturi Elite", 2018, "Black", true, "Shimano Nexus RapidFire, 8-v");
            boat.PrintInfo();
            bike1.PrintInfo();
            Console.ReadKey(true);
        }
    }
}
