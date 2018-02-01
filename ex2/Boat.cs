using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Boat : Vehicle
    {
        private string boatType;
        private int seatCount;

        public Boat(string n, string m, int y, string c, string bt, int sc)
        {
            Name = n;
            Model = m;
            Year = y;
            Color = c;
            BoatType = bt;
            SeatCount = sc;
        }

        public string BoatType
        {
            get { return boatType; }
            set { boatType = value; }
        }
        public int SeatCount
        {
            get { return seatCount; }
            set { seatCount = value; }
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Boat:\nName: {1} Model: {2} Year: {3} Color: {4} Boat type: {5} Seat count: {6}", this, Name, Model, Year, Color, BoatType, SeatCount);
        }
    }
}
