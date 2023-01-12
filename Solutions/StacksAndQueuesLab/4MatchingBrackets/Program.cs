using System;
using System.Collections.Generic;
using System.Linq;

namespace _4MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> brackets = new Stack<int>();

            string expression = Console.ReadLine();


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push(i);
                }
                if (expression[i] == ')')
                {
                    int prevIndex = brackets.Pop();
                    Console.WriteLine(expression.Substring(prevIndex, i + 1 - prevIndex));
                }
            }
        }
    }
}
