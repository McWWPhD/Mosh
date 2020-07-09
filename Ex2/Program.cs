using System;

namespace Ex2
{
    class Program
    {
        //2- Write a program which takes two numbers from the console and displays the maximum of the two.

        static void Main(string[] args)
        {

            Console.WriteLine("Write first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Numbers are equal");
            }

            else if (number1 > number2)
            {
                Console.WriteLine("{0} is grater than {1}", number1, number2);     
            }

            else
            {
                Console.WriteLine("{0} is grater than {1}", number2, number1);

            }
        }
    }
}
