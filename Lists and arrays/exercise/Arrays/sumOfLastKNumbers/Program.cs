using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfLastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            array[0] = 1;
            for (int i = 1; i < k; i++)
            {
                array[i] = FindInt(k, array, i);
            }
        }

        private static int FindInt(int k, int[] array, int i)
        {
            return 0;
        }
    }
}
