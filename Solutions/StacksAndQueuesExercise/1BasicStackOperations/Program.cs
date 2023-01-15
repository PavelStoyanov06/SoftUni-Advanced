using System;
using System.Collections.Generic;
using System.Linq;

namespace _1BasicStackOperations
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
            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }


            if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            
        }
    }
}
