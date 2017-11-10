using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Boat : Vehicle
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Boat() { }

        public Boat(string type, string regno, string col, string model, int wheels, int length) :
            base(type, regno, col, model, wheels)
        {
            Length = length;
        }

        public override string PrintVehicles()
        {
            return base.PrintVehicles() + "\nLength of Boat:      " + Length+ " feet";
        }


    }
}
