using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Boat: Vehicle
    {
        private int cylindervolume;

        public int Cylindervolume
        {
            get { return cylindervolume;; }
            set { cylindervolume = value; }
        }
        public Boat()
        {

        }

        public Boat(int regno, string color, int noofwheels, string model, string type,int cylindervolume): base (regno, color, noofwheels, model, type)
        {
            Cylindervolume = cylindervolume;
        }
       public override string PrintVehicle()
        {
            return base.PrintVehicle() + cylindervolume;
        }
    }
}
