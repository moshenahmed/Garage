using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class Program

    {

        static void Main(string[] args)
        {


            List<Vehicle> vehicleList = new List<Vehicle>();
            bool runAgain = true;
            while (runAgain == true)
            {
                Console.WriteLine("***MAIN MENU***");
                Console.WriteLine("Choose an option:" +
                    "\n1. Create a garage" +
                    "\n2. Park your vehicle " +
                    "\n3. Remove/ unpark your vehicle " +
                    "\n4. See a list of parked vehicles " +
                    "\n5. See a list of vehicle types currently in the garage " +
                    "\n6. Search for a vehicle based on it's registration number " +
                    "\n0. Exit the program ");

                string option = "";
                option = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(option))
                {
                    Console.WriteLine("Please enter a valid option!");
                    Console.WriteLine();
                }
                else
                {
                    char nav = ' ';
                    nav = option[0];
                    try
                    {
                        nav = option[0];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Input can not be empty !");
                    }


                    switch (nav)
                    {
                        case '1':
                            Console.Write("How many parking slots are in this garage?");
                            int id = int.Parse(Console.ReadLine());
                            creator = new Garage<Vehicle>(id);
                            break;

                        case '2':
                            AddVehicle();
                            break;

                        case '3':
                            break;

                        case '4': //Print list of parked vehicles   
                            ParkingList();
                            break;

                        case '5': //list of vehicle types currently in the garage
                            break;

                        case '6': //Search for a vehicle based on it's registration number
                            break;

                        case '0':
                            Console.Clear();
                            Console.WriteLine("Have a nice day!");
                            Console.ReadLine();
                            return;
                    }

                }

            }
        }
        public static void ParkingList()
        {
            foreach (var item in creator)
            {
                if (item != null)
                {
                    Console.WriteLine(item.PrintVehicles() +
"\n--------------------------------\n");
                }

                else {
                    Console.WriteLine("Free parking slot!");
                }
            }


            Console.ReadLine();
        }


        private static Garage<Vehicle> creator;

        public static void AddVehicle()
        {
            //List<Vehicle> vehicleList = new List<Vehicle>();

            //int count = 1;
            //bool runAgain = true;

            {
                string option2 = "";
                char nav2 = ' ';

                Console.WriteLine("Type of Vehicle:" +
                                "\n1. Car" +
                                "\n2. Bus" +
                                "\n3. Boat" +
                                "\n4. Airplane" +
                                "\n5. Motorcycle" +
                                "\n0. Exit to Main Menu");

                option2 = Console.ReadLine();
                nav2 = option2[0];
                if (option2 == "0")
                {
                    Console.Clear();
                    return;
                }
                Console.Write("Registration Number:");
                var regno = Console.ReadLine();
                Console.Write("Color:");
                var col = Console.ReadLine();
                Console.Write("Model:");
                var model = Console.ReadLine();
                Console.Write("Wheels:");
                var wheelsTest = Console.ReadLine();
                var wheels = 0;
                if (!int.TryParse(wheelsTest, out wheels))
                {
                    Console.WriteLine("Error encountered when adding Wheels. It has been set to 0 ");
                }

                switch (nav2)
                {
                    case '1':

                        Console.Write("Fueltype:");
                        var fuel = Console.ReadLine();
                        var type = "Car";
                        var car = new Car(type, regno, col, model, wheels, fuel);
                        creator.Park(car);
                        break;

                    case '2':
                        Console.Write("Number of Seats: ");
                        var seatsTest = Console.ReadLine();
                        var seats = 10;
                        if (!int.TryParse(seatsTest, out seats))
                        {
                            Console.WriteLine("Error encountered when adding Seats. It has been set to 10 ");
                            seats = 10;
                        }
                        Console.ReadLine();
                        type = "Bus";
                        var bus = new Bus(type, regno, col, model, wheels, seats);
                        creator.Park(bus);
                        break;

                    case '3':
                        Console.Write("Length: ");
                        var lengthTest = Console.ReadLine();
                        var length = 20;
                        if (!int.TryParse(lengthTest, out length))
                        {
                            Console.WriteLine("Error encountered when adding Length. It has been set to 20 feet ");
                            length = 20;
                        }
                        Console.ReadLine();
                        type = "Boat";
                        var boat = new Boat(type, regno, col, model, wheels, length);
                        creator.Park(boat);
                        break;

                    case '4':
                        Console.Write("Number of Engines: ");
                        var enginesTest = Console.ReadLine();

                        var engines = 2;
                        if (!int.TryParse(enginesTest, out engines))
                        {
                            Console.WriteLine("Error encountered when adding Engines. It has been set to 2 ");
                            engines = 2;
                        }
                        Console.ReadLine();
                        type = "Airplane";
                        var airplane = new Airplane(type, regno, col, model, wheels, engines);
                        creator.Park(airplane);
                        break;

                    case '5':
                        Console.Write("Cylinder volume: ");
                        var cvTest = Console.ReadLine();
                        var cv = 500;
                        if (!int.TryParse(cvTest, out cv))
                        {
                            Console.WriteLine("Error encountered when adding Cylinder Volume. It has been set to 500");
                            cv = 500;
                        }
                        Console.ReadLine();
                        type = "Motorcycle";
                        var motorcycle = new Motorcycle(type, regno, col, model, wheels, cv);
                        creator.Park(motorcycle);
                        break;

                    default:
                        Console.WriteLine("Please enter valid input(0, 1, 2, 3, 4 or 5)");
                        break;
                }

                //Console.WriteLine(count + " vehicle(s)  parked in the garage of " + id + " slots");
                //count++;
                //if (creator != null)
                //{
                //  
                //}
                //else
                //{
                //    Console.WriteLine("full");
                //}
            }
        }
    }


}












