using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
   public class GarageHandler
    {
        public void SetRegno(Vehicle veh, int regno)
        {
            veh.Regno = regno;
        }
        public void SetColor(Vehicle veh, string color)
        {
            veh.Color = color;
        }
        public void SetNoOfWheels(Vehicle veh, int noofwheels)
        {
            veh.NoOfwheels = noofwheels;
        }
        public void SetModel(Vehicle veh, string model)
        {
            veh.Model = model;
        }
        public void SetType(Vehicle veh, string type)
        {
            veh.Type = type;
        }

        public int GetRegno(Vehicle veh)
        {
            return veh.Regno;
        }
        public string GetColor(Vehicle veh)
        {
            return veh.Color;
        }
        public int GetNoOfwheels(Vehicle veh)
        {
            return veh.NoOfwheels;
        }
        public string GetModel(Vehicle veh)
        {
            return veh.Model;
        }

        public string GetType(Vehicle veh)
        {
            return veh.Type;
        }
        public Vehicle Createvehicle(int Regno, string Color, int NoOfWheels, string Model, string Type)
        {
            var vehicle = new Vehicle();
            vehicle.Regno = Regno;
            vehicle.Color = Color;
            vehicle.NoOfwheels = NoOfWheels;
            vehicle.Model = Model;
            vehicle.Type = Type;
            return vehicle;
        }

        


    }

}
