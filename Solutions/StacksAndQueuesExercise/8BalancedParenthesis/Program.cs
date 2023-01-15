using System;
using System.Collections.Generic;
using System.Linq;

namespace _8BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parantheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var paranthesis in parantheses)
            {
                switch(paranthesis)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(paranthesis);
                        break;
                    case ')':
                        if(stack.Count == 0 || stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if(stack.Count == 0 || stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '}':
                        if(stack.Count == 0 || stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
