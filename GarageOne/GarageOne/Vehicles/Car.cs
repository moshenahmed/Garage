using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    class Car: Vehicle
    {
        private string fueltype;

        public string Fueltype
        {
            get { return fueltype; }
            set { fueltype = value; }
        }

        public Car()
        {

        }
        public Car(int regno, string color, int noofwheels, string model, string type, string fueltype): base (regno, color, noofwheels, model, type)
        {
            Fueltype = fueltype;
        }
        public override string PrintVehicle()
        {
            return base.PrintVehicle() + fueltype;
        }

    }
}
