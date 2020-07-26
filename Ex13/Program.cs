using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex13
{

    //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.The list of numbers may include duplicates. Display the unique numbers that the user has entered.

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            var uniqueNumbers = new List<int>();

            try
            {
                while (true)
                {
                    Console.WriteLine(@"enter a number or type ""Quit"" to exit: ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                    {
                        break;
                    }

                    numbers.Add(Convert.ToInt32(input));
                }

                foreach (var number in numbers)
                {
                    if (numbers.IndexOf(number) == numbers.LastIndexOf(number))
                    {
                        uniqueNumbers.Add(number);
                    }
                    continue;

                }

                Console.WriteLine("Your unique numbers are: ");
                foreach (var number in uniqueNumbers)
                {
                    Console.WriteLine(number);
                }


            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            


        }
    }
}
