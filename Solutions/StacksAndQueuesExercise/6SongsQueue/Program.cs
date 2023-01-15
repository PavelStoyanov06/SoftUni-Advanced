using System;
using System.Collections.Generic;
using System.Linq;

namespace _6SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songQueue = new Queue<string>(songs);

            string cmd = Console.ReadLine();

            while (songQueue.Count > 0)
            {
                if (cmd == "Play")
                {
                    songQueue.Dequeue();
                }
                else if (cmd.Contains("Add"))
                {
                    string song = cmd.Remove(0, 4);
                    if (!songQueue.Contains(song))
                    {
                        songQueue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (cmd == "Show")
                {
                    Console.WriteLine(String.Join(", ", songQueue));
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
