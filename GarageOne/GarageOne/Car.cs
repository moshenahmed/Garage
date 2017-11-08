using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Car : Vehicle
    {
        private string fueltype;

        public string FuelType
        {
            get { return fueltype; }
            set { fueltype = value; }
        }

        //public Car() { }

        public Car(string regno, string col, string model, int wheels, string fuel) :
            base(regno, col, model, wheels)
        {
            FuelType = fuel;
        }

        public override string PrintVehicles()
        {
            return base.PrintVehicles() + "\nType of fuel used: " + FuelType;
        }


    }
}
