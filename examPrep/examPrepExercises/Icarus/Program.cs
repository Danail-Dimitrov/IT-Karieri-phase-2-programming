using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            int damage = 1;
            string[] commandArgs = Console.ReadLine().Split(' ').ToArray();

            while(commandArgs[0] != "Supernova")
            {
                string direction = commandArgs[0];
                int steps = int.Parse(commandArgs[1]);

                if (direction == "left")
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        index--;
                        if (index < 0)
                        {
                            index = plane.Length - 1;
                            damage++;
                        }
                        plane[index] -= damage;
                    }
                }
                else if (direction == "right")
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        index++;
                        if (index > plane.Length-1)
                        {
                            index = 0;
                            damage++;
                        }
                        plane[index] -= damage;
                    }
                }

                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
