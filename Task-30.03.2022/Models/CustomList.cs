using System;
using System.Collections.Generic;
using System.Text;

namespace Task_30._03._2022.Models
{
    class CustomList <T>
    {
        private  T[] array;
        private int _Capacity;
        private int _Count=0;

        public CustomList()
        {
            array = new T[0];
        }
        public T this [int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Add(T number)
        {    
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = number;
            Console.WriteLine(number);
        }


        public void Clear()
        {
            array = new T[_Capacity];
            _Count = 0;
        }
        public bool Exist(T Number)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array.Equals(Number))
                    return true;
            }
            return false;
        }

        public void Remove(T Number)
        {
            int index = IndexOf(Number);
            Remove(Number);
        }
        public void Reverse()
        {
            Array.Reverse(array);
        }
        public int IndexOf(T Number)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Equals(Number))
                    return i;
            }
            return -1;
        }
        public int LastIndexOf(T Number)
        {
            for(int i = array.Length - 1; i > 0; i--)
            {
                if (array[i].Equals(Number))
                  return i;
            }
            return -1;
        }
        public void ShowInfo()
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
