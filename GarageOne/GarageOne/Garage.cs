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
        private List<T> vehicleList;
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
            vehicleList = new List<T>();
        }

       

        public void Park(T input)
        {
            if (count < garsize)
            {
                vehicleList[count++] = input;
            }
        }

        public void Unpark(int id)
        {
            if (id != 0 && id <= garsize && vehicleList[id] != null)
            {                
                if (id + 1 != garsize)
                {                    
                    for (int i = id; i < garsize; i++)
                    {
                        if (vehicleList[i + 1] != null && i + 1 != garsize)
                        {
                            vehicleList[i] = vehicleList[i + 1];
                        }
                        else
                        {
                            vehicleList[i] = null;
                        }
                    }
                }
                else
                {
                    vehicleList[id] = null;
                }
                count--;
            }
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
