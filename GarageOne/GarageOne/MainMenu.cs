using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageOne
{
    public class MainMenu
    {

        public void Menu()
        {
            //bool runAgain = true;
            //while (runAgain == true)
            //{
            //    Console.WriteLine("Choose an option:" +
            //        "\n1. Park your vehicle " +
            //        "\n2. Remove/ unpark your vehicle " +
            //        "\n3. See a list of parked vehicles " +
            //        "\n4. See a list of vehicle types currently in the garage " +
            //        "\n5. Search for a vehicle based on it's registration number " +
            //        "\n0. Exit the program ");

            //    string option = "";
            //    option = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(option))
            //    {
            //        Console.WriteLine("Please enter a valid option!");
            //    }
            //    else
            //    {
            //        char nav = ' ';
            //        nav = option[0];

            //        try
            //        {
            //            nav = option[0];
            //        }
            //        catch (IndexOutOfRangeException)
            //        {
            //            Console.WriteLine("\n");
            //            Console.WriteLine("Input can not be empty !");
            //        }

            //        switch (nav)
            //        {
            //            case '1':                            
            //                break;

            //            case '2':
            //                break;

            //            case '3': //Print list of parked vehicles  
            //                Garagecreator create = new Garagecreator();

            //                create.Calculations();
            //                break;

            //            case '4': //list of vehicle types currently in the garage
            //                break;

            //            case '5': //Search for a vehicle based on it's registration number
            //                break;

            //            case '0':
            //                Console.Clear();
            //                Console.WriteLine("Have a nice day!");
            //                Console.ReadLine();
            //                return;


            //        }

            //    }
            Garagecreator create = new Garagecreator();

                           create.Calculations();
            Console.ReadLine();
        }
        
    }
    }

