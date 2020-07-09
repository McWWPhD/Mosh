using System;

namespace Ex3
{
    class Program
    {
        //3- Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;

            Console.Write("Enter the width and height of an image\nWidht: ");
            
                var entryOne = Console.ReadLine();

            try
            {                
                    width = Convert.ToInt32(entryOne);                         

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);               
            }

        
            Console.Write("Heigt: ");

            var entryTwo = Console.ReadLine();

            try
            {               
                    height= Convert.ToInt32(entryTwo);               
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }





            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("C`mon");
            }

            else if (width > height)
                {
                    Console.WriteLine("Image is a landscape");
                }
            else if (height > width)
                {
                    Console.WriteLine("Image is a portrait");
                }
           

            else if (width == height)
            {
                Console.WriteLine("Image is a square (1:1 ratio)");
            }


        }
    }
}
