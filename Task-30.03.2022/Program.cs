using System;
using Task_30._03._2022.Models;
using System.Collections.Generic;

namespace Task_30._03._2022
{
   internal class Program
    {
        static void Main(string[] args)
        {
            CustomList <int> list = new CustomList<int>();
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list.Add(25);
            list.Add(30);
            list.Add(35);
            list.Add(40);
            list.Add(45);
            list.Add(50);

            
            Console.WriteLine(list.IndexOf(3));
            Console.WriteLine("-------------------");
            Console.WriteLine(list.LastIndexOf(4));
            Console.WriteLine("--------------------");

        }
    }
}
