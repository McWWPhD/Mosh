using System;
using System.Text;

namespace Ex18
{

    //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a few words separated by a space: ");

            var input = Console.ReadLine();

            var pascalString = new StringBuilder();

            try
            {

                var words = input.Trim().ToLower().Split(' ');

                foreach (var word in words)
                {
                 
                        var firstChar = word.Substring(0, 1).ToUpper();
                        pascalString.Append(firstChar);
                        var restOfTheWord = word.Substring(1);
                        pascalString.Append(restOfTheWord);
                }

                Console.WriteLine(pascalString);




            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }


        }
    }
}
