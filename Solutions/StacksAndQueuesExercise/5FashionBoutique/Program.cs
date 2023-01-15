using System;
using System.Collections.Generic;
using System.Linq;

namespace _5FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackCount = 1;
            int tempSum = 0;
            while (stack.Count > 0)
            {
                if (tempSum + stack.Peek() <= rackCapacity)
                {
                    tempSum += stack.Pop();
                    continue;
                }
                tempSum = 0;
                rackCount++;
            }

            Console.WriteLine(rackCount);
        }
    }
}
