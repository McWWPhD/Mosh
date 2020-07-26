using System;
using System.Collections.Generic;

namespace Ex15
{

    //1- Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter a few numbers separated by a hyphen: ");

            var input = Console.ReadLine();

            try
            {
                bool consecutive = false;
                List<int> numbers = new List<int>();

                foreach (var item in input.Trim().Split('-'))
                {
                    numbers.Add(Convert.ToInt32(item));
                }

                List<int> sortedNumbers = new List<int>(numbers);
                sortedNumbers.Sort();


                for (int i = 0; i < numbers.Count; i++)
                {

                    if (numbers[i] != sortedNumbers[i])
                    {
                        consecutive = false;
                        break;
                    }

                    consecutive = true;
                }

                var result = (consecutive) ? "Consecutive" : "Not consecutive";
                Console.WriteLine(result);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }



        }
    }
}
