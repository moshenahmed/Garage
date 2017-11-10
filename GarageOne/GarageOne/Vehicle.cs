using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Vehicle
    {
        private string type;
        private string regnumber;
        private string color;
        private string modelname;
        private int numberofwheels;
        

        public string Type
        {
            get {return type;}
            set {type = value;}
        }

        public string Regnumber
        {
            get { return regnumber; }
            set { regnumber = value;}
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Modelname
        {
            get { return modelname; }
            set { modelname = value; }
        }

        public int NumberOfWheels
        {
            get { return numberofwheels; }
            set { numberofwheels = value; }
        }


        public Vehicle() { }

        public Vehicle(string type,string regno, string col, string model, int wheels)
        {
            Type = type;         
            Regnumber = regno;
            Color = col;
            Modelname = model;
            NumberOfWheels = wheels;
        }
       
        

        public virtual string PrintVehicles()
        {
            return "\nVehicle Type:        " + Type + "\nRegistration Number: " + Regnumber +
                "\nVehicle Color:       " + Color + "\nVehicle Model:       " + Modelname + 
                "\nNumber of Wheels:    " + NumberOfWheels;
        }




    }
}
