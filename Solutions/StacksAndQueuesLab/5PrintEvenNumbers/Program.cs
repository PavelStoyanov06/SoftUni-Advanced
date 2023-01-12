using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);   


            Queue<int> evenNumbers = new Queue<int>();
            while(queue.Count > 0)
            {
                if(queue.Peek() % 2 == 0)
                    evenNumbers.Enqueue(queue.Dequeue());
                else
                    queue.Dequeue();
            }

            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
