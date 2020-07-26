using System;
using System.Collections.Generic;

namespace Ex12
{
    //3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.


    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                if (numbers.Count > 4)
                {
                    Console.WriteLine("Enter 1 number: ");
                }

                Console.WriteLine("Enter {0} numbers: ", 5 - numbers.Count);



                try
                {
                    var input = Console.ReadLine();

                    var number = Int32.Parse(input);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("re-try: ");
                        continue;
                    }
                    else
                    {
                        numbers.Add(number);
                    }



                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

            }
            numbers.Sort();

            Console.WriteLine("Sorted numbers are: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }



        }
    }
}
