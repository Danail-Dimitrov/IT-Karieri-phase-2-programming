using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int n = int.Parse(Console.ReadLine());
            double[] results = new double[n];
            readValues(n, counter, results);
        }

        private static void readValues(int n, int counter, double[] results)
        {
            int totalLength = int.Parse(Console.ReadLine());
            double totalWidth = double.Parse(Console.ReadLine());
            int wingLength = int.Parse(Console.ReadLine());
            calculate(totalLength, totalWidth, wingLength, n, counter, results);

        }

        private static void calculate(int totalLength, double totalWidth, int wingLength, int n, int counter, double[] results)
        {
            //totalYears = {totalLength} ^ 2 * ({totalWidth} + 2 * {wingLength}
            double totalYears = Math.Pow(totalLength, 2) * (totalWidth + 2 * wingLength);
            results[counter] = totalYears;
            if (counter == n - 1)
            {
                print(results, n);
            }
            else
            {
                counter++;
                readValues(n, counter, results);
            }
        }

        private static void print(double[] results, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
