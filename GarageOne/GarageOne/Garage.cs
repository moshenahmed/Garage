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
        private T[] vehicleArray;
        
        
        private int capacity;
        private int count;

        public int Capacity
        {
            get { return capacity; }
            
        }


        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }



    public Garage(T input)
        {
            ///*
            // * We make sure that the type of the inparam "input" is of the type Sentient
            // * or a child of it
            // */
            if (input)
            {
                capacity = input;
                vehicleArray = new T[capacity];
            }
            ///*
            // * otherwise we ensure that the party will only be the founding person
            // */
            else
            {
                capacity = 1;
                vehicleArray = new T[1];
            }
            vehicleArray[0] = input;
            Count = 1;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicleArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}

