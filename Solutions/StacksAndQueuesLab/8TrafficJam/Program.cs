using System;
using System.Collections.Generic;

namespace _8TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            int carsPassed = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                if(input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0) break;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
