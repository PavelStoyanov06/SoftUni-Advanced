using System;
using System.Collections.Generic;
using System.Linq;

namespace _11KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bulletStack = new Stack<int>(bullets);
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> lockQueue= new Queue<int>(locks);
            int intValue = int.Parse(Console.ReadLine());

            int usedBullets = 0;
            while(lockQueue.Count > 0)
            {
                if(bulletStack.Pop() <= lockQueue.Peek())
                {
                    lockQueue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if(bulletStack.Count <= 0)
                {
                    break;
                }
                usedBullets++;
                if (usedBullets >= barrelSize)
                {
                    usedBullets = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if(lockQueue.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockQueue.Count}");
            }
            else
            {
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${intValue - (bullets.Length - bulletStack.Count) * bulletPrice}");
            }
        }
    }
}
