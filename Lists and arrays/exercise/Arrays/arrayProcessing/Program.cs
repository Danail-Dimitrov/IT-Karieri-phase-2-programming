using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else
                {
                    arr[int.Parse(command[1])] = command[2];
                }
            }

            Console.WriteLine(string.Join(", ", arr));

        }
    }
} // .