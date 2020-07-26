using System;

namespace Ex17
{

    //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a time value in the 24-hour time format(e.g. 19:00): ");

            var input = Console.ReadLine();

            try
            {
                var timeElement = input.Trim().Split(':');

                if (Convert.ToInt32(timeElement[0]) > 0 && Convert.ToInt32(timeElement[0]) < 24 && Convert.ToInt32(timeElement[1]) > 0 && Convert.ToInt32(timeElement[1]) < 59)
                {
                    Console.WriteLine("Ok");
                }
                else

                Console.WriteLine("Invalid time");


            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }



        }
    }
}
