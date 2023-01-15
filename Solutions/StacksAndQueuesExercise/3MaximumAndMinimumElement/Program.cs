using System;
using System.Collections.Generic;
using System.Linq;

namespace _3MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

                int query = input[0];

                switch (query)
                {
                    case 1:
                        stack.Push(input[1]);
                        break;
                    case 2:
                        if(stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if(stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if(stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
