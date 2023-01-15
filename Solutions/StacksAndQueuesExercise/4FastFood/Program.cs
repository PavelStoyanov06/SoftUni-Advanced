using System;
using System.Collections.Generic;
using System.Linq;

namespace _4FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] quantityOrder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(quantityOrder);
            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (quantityFood >= orders.Peek())
                {
                    quantityFood -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if(orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
