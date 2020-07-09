using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ex1
{
    class Program
    {
        //1- Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)



        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());

            //if (number >=1 && number <= 10)
            //{
            //    Console.WriteLine("Number is Valid");
            //}

            //else
            //{
            //    Console.WriteLine("Number is Invalid");
            //}

            string answer = (number >= 1 && number <= 10) ? "Valid" : "Invalid";

            Console.WriteLine("Number is {0}", answer);

        }
    }
}
