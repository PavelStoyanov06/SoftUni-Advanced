using System;
using System.Collections.Generic;
using System.Linq;

namespace _2BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = mainArgs[0];
            int s = mainArgs[1];
            int x = mainArgs[2];

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine(queue.Count);
            }
        }
    }
}
