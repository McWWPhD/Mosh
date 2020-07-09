using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex9
{

    //5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a series of numbers separated by comma:");

            var input = Console.ReadLine();

            List<int> numbers = new List<int>();

            foreach (var item in input.Split(','))
            {
                numbers.Add(Convert.ToInt32(item));

            }

            Console.WriteLine("Maximum number is: " + numbers.Max<int>());
        }
    }
}
