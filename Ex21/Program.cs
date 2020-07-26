using System;
using System.IO;
using System.Net.Mime;

namespace Ex21
{

    //2- Write a program that reads a text file and displays the longest word in the file.

    class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText(@"C:\Users\ABBYS\Desktop\plik.txt");

            var words = content.Split(" ");

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

                continue;

            }

            Console.WriteLine("The longest word is: " + longestWord);
        }
    }
}
