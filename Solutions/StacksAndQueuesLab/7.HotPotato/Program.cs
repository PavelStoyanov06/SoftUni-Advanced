using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Queue<string> children = new Queue<string>(names);

            int n = int.Parse(Console.ReadLine());
            int maxTosses = n;


            while (children.Count > 1) 
            {
                if(n <= 1)
                {
                    Console.WriteLine($"Removed {children.Dequeue()}");
                    n = maxTosses;
                }
                else
                {
                    string child = children.Dequeue();
                    children.Enqueue(child);
                    n--;
                }
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
