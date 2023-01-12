using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _1ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            
            foreach (char element in input)
            {
                stack.Push(element);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
