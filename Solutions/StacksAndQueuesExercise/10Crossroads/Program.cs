using System;
using System.Collections.Generic;
using System.Linq;

namespace _10Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startGreenLight = int.Parse(Console.ReadLine());
            int startFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            int carsPassed = 0;
            bool crashed = false;
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }

                //When light is green:
                int greenLight = startGreenLight;
                int freeWindow = startFreeWindow;
                bool entered = false;
                string partNotThrough = string.Empty;
                while (greenLight > 0 && cars.Count > 0)
                {
                    if (greenLight >= cars.Peek().Length)
                    {
                        carsPassed++;
                        greenLight -= cars.Dequeue().Length;
                    }
                    else
                    {
                        partNotThrough = cars.Peek().Remove(0, greenLight);
                        entered = true;
                        break;
                    }
                }

                if (entered == true)
                {
                    if (freeWindow >= partNotThrough.Length)
                    {
                        carsPassed++;
                        cars.Dequeue();
                    }
                    else
                    {
                        partNotThrough = partNotThrough.Remove(0, freeWindow);
                        crashed = true;
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{cars.Peek()} was hit at {partNotThrough[0]}.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            if(!crashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
