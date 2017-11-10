using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Bus : Vehicle
    {
        private int numberofseats;

        public int NumberOfSeats
        {
            get { return numberofseats; }
            set { numberofseats = value; }
        }

        public Bus() { }

        public Bus(string type, string regno, string col, string model, int wheels, int seats) :
            base(type, regno, col, model, wheels)
        {
            NumberOfSeats = seats;
        }

        public override string PrintVehicles()
        {
            return base.PrintVehicles() + "\nNumber of Seats:     " + NumberOfSeats;
        }




    }
}
