using System;

namespace Ex6
{

    //2- Write a program and continuously ask the user to enter a number or "ok" to exit.Calculate the sum of all the previously entered numbers and display it on the console.

    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            
            try
            {
                while (true)
                {
                    Console.Write(@"enter a number or ""ok"" to exit: ");

                    var number = Console.ReadLine();

                    if (number == "ok" || string.IsNullOrEmpty(number))
                        break;

                    sum += Convert.ToInt32(number);                   


                }

                Console.WriteLine("The sum is: " + sum);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            

        }
    }
}
