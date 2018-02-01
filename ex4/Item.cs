using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Item
    {
        private string name;
        private string type;
        private int quantity;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public virtual void PrintInfo()
        {
            
        }
    }
}
