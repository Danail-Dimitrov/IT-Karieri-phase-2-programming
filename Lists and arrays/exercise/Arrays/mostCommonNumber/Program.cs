using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostCommonNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            findMostMatches(input);
        }

        private static void findMostMatches(int[] input)
        {
            int currentNumber;
            int currentMax = input[0];
            int numberMatches=0;
            int lastMatces=0;

            for (int i = 0; i < input.Length; i++)
            {
                numberMatches = 0;
                currentNumber = input[i];
                for (int k = 0; k < input.Length; k++)
                {
                    if (input[k]==currentNumber)
                    {
                        numberMatches++;
                    }
                }
                if (numberMatches>lastMatces)
                {
                    lastMatces = numberMatches;
                    currentMax = input[i];
                }
            }
            print(lastMatces,currentMax);
        }

        private static void print(int lastMatces,int currentMax)
        {
            Console.WriteLine(currentMax);
            Console.WriteLine(lastMatces);
        }
    }
}
