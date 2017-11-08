using GarageOne;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class MainMenu
    {
        public void mainmenu()
        {


            var garage = new GarageHandler();
            List<Vehicle> vehiclelist = new List<Vehicle>();
            var boat = new Boat(456, "blue", 4, "Ford", "small", 55);
            //vehiclelist.Add(garage.Createvehicle(456, "blue", 4, "Ford", "small"));
            //vehiclelist.Add(garage.Createvehicle(573, "white", 6, "benz", "lastbill"));
            //vehiclelist.Add(garage.Createvehicle(148, "green", 10, "scania", "tipper"));
            //vehiclelist.Add(garage.Createvehicle(846, "silver", 3, "suzuki", "small"));
            //vehiclelist.Add(garage.Createvehicle(851, "maroon", 9, "audi", "sedan"));
            
            foreach (var item in vehiclelist)
            {
                Console.WriteLine(item.PrintVehicle() + "\n--------------------------------\n");

            }
            Console.ReadLine();

        }
    }
}
