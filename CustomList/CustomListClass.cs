using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T> :IEnumerable
    {

        T[] customArray = new T[5];
        public int Count;


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

        public void Remove(T item)
        {            
            T[] tempArray = new T[customArray.Length];

            for (int i = 0; i > customArray.Length; i++)
            {
                if(!(item.Equals(customArray[i])))
                {
                    customArray[i] = tempArray[i];
                }
                tempArray[i] = customArray[i];
            }
            Count--;            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
