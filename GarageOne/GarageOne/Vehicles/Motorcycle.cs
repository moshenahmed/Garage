using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    class Motorcycle : Vehicle
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Motorcycle()
        {

        }

        public Motorcycle(int regno, string color, int noofwheels, string model, string type, int length): base (regno, color, noofwheels,model,type)
        {
            Length = length;
        }
        public override string PrintVehicle()
        {
            return base.PrintVehicle() + length;
        }
    }
}
