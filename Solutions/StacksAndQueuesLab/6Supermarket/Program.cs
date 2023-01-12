using System;
using System.Collections.Generic;

namespace _6Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Queue<string> customers = new Queue<string>(input);

            string newCustomer = Console.ReadLine();
            while(newCustomer != "End")
            {
                if(newCustomer == "Paid")
                {
                    while (customers.Count > 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(newCustomer);
                }
                newCustomer = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
