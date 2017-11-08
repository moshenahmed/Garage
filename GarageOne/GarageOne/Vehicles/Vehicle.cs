using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Vehicle
    {


        private int regno;
        private string color;
        private int noofwheels;
        private string model;
        private string type;

        public int Regno
        {
            get { return regno; }
            set { regno = value; }
        }
        public string Color { get { return color; } set { color = value; } }
        public int NoOfwheels { get { return noofwheels; } set { noofwheels = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Type { get { return type; } set { type = value; } }


        public Vehicle()
        {

        }
       public Vehicle(int regno, string color, int noofwheels, string model, string type)
        {
            Regno = regno;
            Color = color;
            NoOfwheels = noofwheels;
            Model = model;
            Type = type;
        }
        public virtual string PrintVehicle()
        {
            return regno + " " + color + "  " + noofwheels + " " + model + " " + type;
        }
    }
}
