using System;
using System.Collections.Generic;
using System.Linq;

namespace _12CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupCap = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cupQueue = new Queue<int>(cupCap);
            Stack<int> bottleStack = new Stack<int>(filledBottles);

            int wastedWater = 0;

            while (cupQueue.Count > 0 && bottleStack.Count > 0)
            {
                int currCup = cupQueue.Peek();
                while (currCup - bottleStack.Peek() > 0)
                {
                    currCup -= bottleStack.Pop();
                }
                wastedWater += (bottleStack.Pop() - currCup);
                cupQueue.Dequeue();
            }

            if(cupQueue.Count > 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cupQueue)}");
            }
            if(bottleStack.Count > 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottleStack)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
