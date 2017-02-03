using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>
    {
        T[] customArray = new T[5];
        public int Count = 0;


        public void Add(T item)
        {
            
            if (Count >= customArray.Length)
            {
                T[] tempArray = new T[customArray.Length + 5];
                for (int i = 0; i < customArray.Length; i++)
                {
                    customArray[i] = tempArray[i];
                }
                    tempArray[Count] = item;
                    customArray = tempArray;
                    Count++;
            }
            else
            {
                customArray[Count] = item;
                Count++;
            } 

        }

        public void IndexOf()
        {

        }

        //public void Remove(T item)
        //{
        //    for (int i = 0; i > 0; i--) ;
        //    if (Count > 1)
        //    {
        //        Count--;
        //    }
        //}


    }
}
