using System;
using System.Collections.Generic;
using System.Linq;

namespace _2StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            string input = Console.ReadLine().ToLower();
            while(input != "end")
            {
                string[] commmandArgs = input.Split(" ");
                string cmd = commmandArgs[0];

                if (cmd == "add")
                {
                    stack.Push(int.Parse(commmandArgs[1]));
                    stack.Push(int.Parse(commmandArgs[2]));
                }
                else if (cmd == "remove")
                {
                    if (stack.Count >= int.Parse(commmandArgs[1]))
                    {
                        for (int i = 0; i < int.Parse(commmandArgs[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
