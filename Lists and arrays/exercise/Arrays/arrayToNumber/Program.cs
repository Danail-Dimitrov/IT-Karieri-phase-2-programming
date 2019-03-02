using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sumed=new int[input.Length-1];
            int count = input.Length;
            while(count>1)
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    sumed[i] = input[i] + input[i + 1];
                }
                input = sumed;
                count--;
            }
            Console.WriteLine(input[0]);
        }
    }
}
