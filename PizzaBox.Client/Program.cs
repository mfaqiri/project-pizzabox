using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;


namespace PizzaBox.Client
{
    internal class Program
    {
        private static  void Main()
        {
            List<string> storeList = new List<string>{"Store 001", "Store 002"};

            var stores = new List<AStore>{new ChicagoStore(), new NewYorkStore()};

            for (int x = 0; x < storeList.Count; x+= 1){
                Console.WriteLine($"{x}  {storeList[x]}");
           }

            Console.WriteLine("make a selection");
            string input = Console.ReadLine(); 

            int entry = int.Parse(input);

            System.Console.WriteLine(storeList[entry]);

        }
    }
}
