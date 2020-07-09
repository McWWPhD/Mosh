using System;

namespace Ex7
{
    //3- Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console.For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();

            try
            {
                ulong number = Convert.ToUInt64(input);
                ulong factorial = 1;

                for (ulong i = 1; i <= number; i++)
                {
                    factorial *= i;

                }

                Console.WriteLine("Factorial is: " +factorial);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
