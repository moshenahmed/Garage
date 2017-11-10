using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private List<T> vehicleList = new List<T>();
        private int garsize;
        private int count;       

        public int GarSize
        {
            get { return garsize; }
            set { garsize = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
               

        public Garage(T input) //Must set max capacity
        {                                   
            //need to Set Max Capacity
            //vehicleList = new List<T>();
        }

       

        public void Park(T vehicle)
        {            
            vehicleList.Add(vehicle);
        }

        private static void AddVehicle()
        {
            //List<Vehicle> vehicleList = new List<Vehicle>();
            //Console.WriteLine("Type:");
            //var type = Console.ReadLine();
            //Console.Write("Registration Number:");
            //var regno = Console.ReadLine();
            //Console.Write("Color:");
            //var col = Console.ReadLine();
            //Console.Write("Model:");
            //var model = Console.ReadLine();
            //Console.WriteLine("Wheels:");
            //var wheels = Console.ReadLine();
            //var vehicle = new Vehicle(type,regno, col, model, wheels);

            //vehicleList.Add(vehicle);

            //Console.WriteLine("The following vehicle has been parked");
            //Console.WriteLine("\n");
            //foreach (var item in vehicleList)
            //{
            //    Console.WriteLine(item.PrintVehicles());
            //}
            //Console.ReadLine();
        }

        public void Unpark(int id)
        {
           
            
        }




        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicleList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
