using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex11
{

    //2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your name: ");
            var input = Console.ReadLine();

            List<char> name = new List<char>();

            foreach (var letter in input)
            {
                name.Add(letter);
            }

            name.Reverse();

            Console.WriteLine(string.Join("", name));

            var arrayt = new Array[4];



        }
    }
}
