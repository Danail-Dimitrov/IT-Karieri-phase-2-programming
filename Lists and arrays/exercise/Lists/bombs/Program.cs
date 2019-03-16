using System;
using System.Collections.Generic;
using System.Linq;

namespace bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //totaly wrong code
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int specialNum = int.Parse(Console.ReadLine());
            //power=k
            int k = int.Parse(Console.ReadLine());
          

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == specialNum)
                {
                    if ((i - k > 0) && (i+k < input.Count))
                    {
                        for (int j = i - k; j <= i + k; j++)
                        {
                            input.RemoveAt(j);
                        }
                    }
                    else if (i - k < 0 && i + k > input.Count)
                    {
                        int a = k - i;
                        int b = input.Count - i;
                        for (int j = i - a; j <= i + b; j++)
                        {
                            input.RemoveAt(j);
                        }
                    }
                    else if (i-k<0)
                    {
                        int a = k - i;
                        for (int j = i - a; j <= i + k; j++)
                        {
                            input.RemoveAt(j);
                        }
                    }
                    else if (i + k > input.Count)
                    {
                        int a = input.Count - i - 1;
                        for (int j = i + a; j >= i - k - 1; j--)
                        {
                            input.RemoveAt(j);
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
