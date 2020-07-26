using System;
using System.Linq;

namespace Ex19
{

    //5- Write a program and ask the user to enter an English word.Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter an English word: ");

            var input = Console.ReadLine();

            var count = 0;

            
            try 
            {

                foreach (var letter in input)
                {
                    if (letter == 'a' || letter == 'e' || letter== 'o' || letter == 'u' || letter == 'i')
                    {
                        count++; 
                    }
                }

                Console.WriteLine("String contains {0} vowels", count);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }





        }
    }
}
