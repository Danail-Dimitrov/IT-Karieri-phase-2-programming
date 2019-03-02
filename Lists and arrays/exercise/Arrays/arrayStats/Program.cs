using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayStats
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double min = input[0], max = 0, sum = 0;
            double avg;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
                if (input[i] < min)
                {
                    min = input[i];
                }
                sum += input[i];
            }

            avg = sum / input.Length;
            Console.WriteLine($"Min = {min}\n Max = {max}\n Sum = {sum}\n Average = {avg}");
            Console.WriteLine(input.Length);
        }
    }
}
