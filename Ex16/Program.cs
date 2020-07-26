using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex16
{

    //2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter few numbers separated by a hyphen: ");

            var input = Console.ReadLine();

            try
            {
                byte count = 0;

                if (string.IsNullOrWhiteSpace(input))
                    return;


                var numbers = input.Trim().Split('-');

                for (int i = 0; i < numbers.Length - 1; i++)
                {

                    if (numbers[i] == numbers[i+1])
                    {
                        count++;
                    }

                    continue;
                }

                if (count==0)
                {
                    Console.WriteLine("No duplicates");
                }
                else
                    Console.WriteLine("There are {0} duplicates", count);


            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}
