using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            sum(input, k);
        }

        private static void sum(int[] input, int k)
        {
            int[] sum = new int[input.Length];
            for (int i = 0; i < k; i++)
            {
                rotate(input);
                for (int j = 0; j < input.Length; j++)
                {
                    sum[j] += input[j];
                }
            }
            print(sum);
        }

        private static void rotate(int[] input)
        {
            int buffer = input[input.Length-1];
            for (int i = input.Length-1; i > 0 ; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = buffer;
        }

        private static void print(int[] sum)
        {
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
