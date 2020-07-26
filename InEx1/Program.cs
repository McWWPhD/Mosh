using System;

namespace InEx1
{


    class Program
    {
        static void Main(string[] args)
        {
            
            var stopwatch = new Stopwatch();
            string input;

            do
            {
                Console.Write(@"Type ""Start"": ");
                input = Console.ReadLine();

                if (input.ToLower()!="start")
                {
                    do
                    {
                        Console.Write(@"Wrong input, type ""Start"": ");
                        input = Console.ReadLine();

                    } while (input.ToLower() != "start");
                }
                
                    stopwatch.Start();
                    Console.Write(@"StopWatch is running, type ""Stop"": ");
                    input = Console.ReadLine();

                if (input.ToLower()!="stop")
                {
                    do
                    {
                        Console.Write(@"Wrong input, type ""Stop"": ");
                        input = Console.ReadLine();

                    } while (input.ToLower() != "stop") ;
                }                
                
                    stopwatch.Stop();
                    Console.WriteLine("TimeSpan is: " + stopwatch.TimeSpan());
                    Console.WriteLine();

            }

            while (!string.IsNullOrWhiteSpace(input));
        }
    }
}
