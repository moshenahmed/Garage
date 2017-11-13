using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{

   public class Garagecreator: Vehicle
    {
        
        public void Calculations()
           
        {
            int id = 4;
            Garage<Vehicle> creator = new Garage<Vehicle>(id);
            
            //var bus = new Bus("xft 545", "red", "benz", 4, 8);
            //var aeroplane = new Airplane("tws 854", "blue", "scania", 54, 7);
            //var boat = new Boat("fuy 545", "white", "yamaha", 4, 8);
            //var bike = new Motorcycle("kuh 453", "silver", "kajmbiya", 3, 5);
            //creator.Park(bus);
            //creator.Park(aeroplane);
            //creator.Park(bike);
            //creator.Park(boat);
           
            foreach (var item in creator)
            {
                Console.WriteLine(item.PrintVehicles()??Enumerable.Empty<int>() + 
                    "\n--------------------------------\n");
            }
            Console.ReadLine();
        }
    }
}
