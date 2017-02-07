using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T> : IEnumerable
    {

        T[] customArray = new T[5];
        public int Count;
        public object items = new string[5];
        public object obj;
       

        public void Add(T item)
        {
            
            if (Count >= customArray.Length)
            {
                T[] tempArray = new T[customArray.Length + 5];
                for (int i = 0; i < customArray.Length; i++)
                {
                    customArray[i] = tempArray[i];
                }
                    customArray = tempArray;
                    tempArray[Count] = item;                   
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            {
                for (int i = 0; i < Count; i++) 
                {
                    yield return customArray[i];                   
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count; i++)
            {
                result = string.Concat(customArray[i].ToString());
            }
            return result;
        }

        // Overload +
        public static CustomListClass<T> operator +(CustomListClass<T> one, CustomListClass<T> two)
        {
            CustomListClass <T> three = new CustomListClass<T>();
            for (int i = 0; i < one.Count; i++)
            {
                three.Add(one.customArray[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                three.Add(two.customArray[i]);
            }
                return three;
        }
    }
}





