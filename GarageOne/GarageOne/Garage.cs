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
        private T[] garageArray;
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
            private set { count = value; }
        }


        //public Park()
        //{

        //}
        //public Garage()
        //{

        //}
        public Garage(int input)
        {
            garsize = input;
            garageArray = new T[garsize];

            count = 0;
            //for (int i = 0; i < garsize; i++)
            //{
            //    garageArray[i] = garageArray[i + 1];
            //}
        }
        public void Park(T vehicle)
        {

            

            if ( count < garsize )
            {
                garageArray[count] = vehicle;
                //if (garageArray[count] == null)
                //{
                //    Console.WriteLine("empty spot");
                //}
            }
          

            else
            {
                Console.WriteLine("full");
            }
            count++;




           



            

       

            //for (int i = 0; i < garsize; i++)
            //{
            //   

            //}


        }
                
                
                    

                 
              
            
            










        public void Unpark(int id)
        {
            if (id != 0 && id <= garsize && garageArray[id] != null)
            {
                if (id + 1 != garsize)
                {
                    for (int i = id; i < garsize; i++)
                    {
                        if (garageArray[i + 1] != null && i + 1 != garsize)
                        {
                            garageArray[i] = garageArray[i + 1];
                        }
                        else
                        {
                            garageArray[i] = null;
                        }
                    }
                }
                else
                {
                    garageArray[id] = null;
                }
                count--;
            }
        }




        //public void listparkedvehicles() /*List all elements in the list as parked vehicles.*/
        //{
        //    foreach (var item in vehicleList)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}





        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < garsize; i++)

            {
                
                yield return garageArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
