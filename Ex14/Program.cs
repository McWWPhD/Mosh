using System;
using System.Collections.Generic;

namespace Ex14
{

    //5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new List<int>();

                do
                {

                    Console.Write("Supply a list of 5 comma separated numbers: ");
                    var input = Console.ReadLine();


                    foreach (var item in input.Trim(new char[3] { ' ', ',', '.' }).Split(',') )
                    {
                        numbers.Add(Convert.ToInt32(item));
                    }

                    if (numbers.Count < 5)
                    {
                        Console.WriteLine("Invalid List please re -try: ");
                        numbers.Clear();
                        continue;
                    }

                } while (numbers.Count < 5);


                numbers.Sort();

                Console.WriteLine("Smallest numbers are: {0}, {1}, {2}", numbers[0], numbers[1], numbers[3]);


            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            

        }
    }
}
