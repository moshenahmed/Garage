using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Motorcycle : Vehicle
    {
        private int cylindervolume;

        public int CylinderVolume
        {
            get { return cylindervolume; }
            set { cylindervolume = value; }
        }

        //public Motorcycle() {}

        public Motorcycle(string regno, string col, string model, int wheels, int cv) :
            base(regno, col, model, wheels)
        {
            CylinderVolume = cv;
        }

        public override string PrintVehicles()
        {
            return base.PrintVehicles()+ "\nCylinder Volume: "+CylinderVolume;
        }



    }
}
