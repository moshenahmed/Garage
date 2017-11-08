using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    class Aeroplane : Vehicle
    {
        private int numberofengines;

        public int Numberofengines
        {
            get { return numberofengines; }
            set { numberofengines = value; }
        }
public Aeroplane()
        {

        }

        public Aeroplane(int regno, string color, int noofwheels, string model, string type, int numberofengines):base (regno, color, noofwheels, model, type)
        {
            Numberofengines = numberofengines;
        }
        public override string PrintVehicle()
        {
            return base.PrintVehicle() + numberofengines;
        }
    }
}
