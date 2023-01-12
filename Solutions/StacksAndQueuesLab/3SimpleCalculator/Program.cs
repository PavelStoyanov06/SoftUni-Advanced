using System;
using System.Collections.Generic;
using System.Linq;

namespace _3SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(" ").ToList());

            int sum = 0;
            while (stack.Count > 0)
            {
                int number = int.Parse(stack.Pop());
                string symbol = string.Empty;
                if(stack.Count > 0)
                {
                    symbol = stack.Pop();
                }
                else
                {
                    symbol = "+";
                }

                if (symbol == "+")
                {
                    sum += number;
                }
                else if (symbol == "-") {
                    sum -= number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
