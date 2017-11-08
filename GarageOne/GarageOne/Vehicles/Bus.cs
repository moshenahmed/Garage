using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    class Bus : Vehicle
    {
        private int nmberofseats;

        public int Numberofseats
        {
            get { return nmberofseats;; }
            set { nmberofseats = value; }
        }
        public Bus()
        {

        }

        public Bus(int regno, string color, int noofwheels, string model, string type, int numberofseats): base (regno, color, noofwheels, model, type)
        {
            Numberofseats = numberofseats;
        }
        public override string PrintVehicle()
        {
            return base.PrintVehicle() + Numberofseats;
        }
    }
}
