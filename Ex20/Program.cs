using System;
using System.IO;

namespace Ex20
{

    //1- Write a program that reads a text file and displays the number of words.

    class Program
    {
        static void Main(string[] args)
        {
            var content = File.ReadAllText(@"C:\Users\ABBYS\Desktop\opis.docx");

            var words = content.Split(' ');

            Console.WriteLine($"There is {words.Length} words");
        }
    }
}
