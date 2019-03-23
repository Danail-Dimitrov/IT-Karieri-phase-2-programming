using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            getOuter(input);
        }

        private static void getOuter(int[] input)
        {
            double a = input.Length / 4;
            int quarterLenght =(int)(Math.Floor (a));            
            int[] outerFirst = new int[quarterLenght];
            int[] outerSecond = new int[quarterLenght];
            int[] outer = new int[input.Length / 2];

            //finds first half of outer
            for (int i = 0; i < quarterLenght; i++)
            {
                outerFirst[i] = input[i];                
            }
            Array.Reverse(outerFirst);

            //finds second half of outer
            int counter = 0;
            for (int i =input.Length-quarterLenght; i < input.Length; i++)
            {               
                outerSecond[counter] = input[i];
                counter++;
            }
            Array.Reverse(outerSecond);

            //adds outerFirst to output
            //reusing counter so i do not need a new variable
            counter = 0;
            for (int i = 0; i < quarterLenght; i++)
            {
                outer[i] = outerFirst[i];
                counter++;
            }
            for (int i = 0; i <quarterLenght; i++)
            {
                outer[counter] = outerSecond[i];
                counter++;
            }
            getInner(input, outer, quarterLenght);
        }

        private static void getInner(int[] input, int[] outer,int quarterLenght)
        {
            int counter = 0;
            int[] inner = new int[input.Length / 2];
            for (int i = input.Length-3 * quarterLenght; i < input.Length-quarterLenght; i++)
            {
                inner[counter] = input[i];
                counter++;
            }
            getResult(outer, inner, input);
        }

        private static void getResult(int[] outer, int[] inner,int[] input)
        {
            int[] result = new int[input.Length/2];
            for (int i = 0; i < input.Length/2; i++)
            {
                result[i] = outer[i] + inner[i];
            }
            print(result);
        }

        private static void print(int[] result)
        {
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
