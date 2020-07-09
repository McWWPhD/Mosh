using System;

namespace Ex8
{
    //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);

            var randomNumber = random.Next(1, 11);

            var chances = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Quess the number: ");
                var userQuess = Convert.ToInt32(Console.ReadLine());

                if (userQuess == randomNumber)
                {
                    Console.WriteLine("You Win !!!");
                    break;
                }
                else
                {
                    Console.WriteLine("No...");
                    chances++;
                }
                continue;

            }
            if (chances == 4)
            {
                Console.WriteLine("You lost");
            }


        }
    }
}
