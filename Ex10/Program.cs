using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Ex10
{
//    1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

    class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<string>();


            while (true)
            {
                Console.Write("Enter different name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    continue;
                }
                else if (input.ToLower() == "enter")
                {
                    break;

                }
                else
                {
                    likes.Add(input);
                    continue;
                }

            }

            switch (likes.Count)
            {
                case 0:
                    Console.WriteLine("Booooo");
                    break;

                case 1:
                    Console.WriteLine("{0} likes your post", likes[0]);
                    break;

                case 2:
                    Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
                    break;
                    

                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post!", likes[0], likes[1], likes.Count - 2);
                    break;
            }

        }
    }
}
