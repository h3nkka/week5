using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Item device = new Device("Moto G 4G", "Smartphone", 1, 10.2F, "Motorola");
            Item cd = new CD("Megadeth: Dystopia", "CD-ROM", 2, 46.51F, 2016);
            device.PrintInfo();
            cd.PrintInfo();
            Console.ReadKey(true);
        }
    }
}
