using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Bicycle : Vehicle
    {
        private bool isGearboxBike;
        private string gearboxModel;

        public Bicycle(string n, string m, int y, string c, bool gb, string gbm)
        {
            Name = n;
            Model = m;
            Year = y;
            Color = c;
            IsGearboxBike = gb;
            GearboxModel = gbm;
        }

        public bool IsGearboxBike
        {
            get { return isGearboxBike; }
            set { isGearboxBike = value; }
        }
        public string GearboxModel
        {
            get { return gearboxModel; }
            set { gearboxModel = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Bicycle:\nName: {1} Model: {2} Year: {3} Color: {4} Has gearbox: {5} Gearbox model: {6}", Name, Model, Year, Color, IsGearboxBike, GearboxModel);
        }       
    }
}
