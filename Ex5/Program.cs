using System;

namespace Ex5
{
    class Program
    {
    //    1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.


        static void Main(string[] args)
        {
            var count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);

        }
    }
}
