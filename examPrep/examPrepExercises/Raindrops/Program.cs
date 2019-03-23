using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ').ToArray();
                double raindropsCount = double.Parse(commandArgs[0]);
                double squareMeters = double.Parse(commandArgs[1]);

                double regionalCoefficient = raindropsCount / squareMeters;
                sum += regionalCoefficient;
            }
            if (density != 0)
            {
                Console.WriteLine("{0:f3}", sum / density);
            }
            else
            {
                Console.WriteLine("{0:f3}", sum);
            }
        }
    }
}
