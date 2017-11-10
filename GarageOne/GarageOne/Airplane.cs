using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Airplane : Vehicle    
    {
        private int numberofengines;

        public int NumberOfEngines
        {
            get { return numberofengines; }
            set { numberofengines = value; }
        }

        //public Airplane() { }

        public Airplane(string type, string regno, string col, string model, int wheels, int engines) :
            base(type, regno, col, model, wheels)
        {
            NumberOfEngines = engines;
        }

        

        public override string PrintVehicles()
        {
            return base.PrintVehicles() + "\nNumber of Engines:   " + NumberOfEngines;
        }



    }
}
