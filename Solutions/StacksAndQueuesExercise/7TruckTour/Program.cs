using System;
using System.Collections.Generic;
using System.Linq;

namespace _7TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] pumpArgs = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(pumpArgs);
            }

            int index = 0;

            while (true)
            {
                int tempFuel = 0;
                bool isFinished = true;

                foreach (var pump in pumps)
                {
                    int fuel = pump[0];
                    int distance = pump[1];

                    tempFuel += fuel;
                    if(tempFuel < distance)
                    {
                        pumps.Enqueue(pumps.Dequeue());
                        index++;
                        isFinished = false;
                        break;
                    }

                    tempFuel -= distance;
                }
                if(isFinished)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }
}
