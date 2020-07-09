using System;

namespace Ex4
{
//    4- Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

    class Program
    {
        static void Main(string[] args)
        {
            int speed = 0;
            int speedLimit = 50;
            int points = 0;

            Console.Write("Enter the speed: ");

            var entry = Console.ReadLine();

            try
            {
                speed = Convert.ToInt32(entry);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }


            if (speed <= speedLimit)
            {
                Console.WriteLine("OK");
            }

            else
            {
                points = (speed - speedLimit)/5 ;

                if (points <= 12)
                {
                    Console.WriteLine("You have {0} points", points);
                }
                else
                {
                    Console.WriteLine("License suspended");
                }

            }



         



        }
    }
}
