﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int buffer;

            buffer = a;
            a = b;
            b = buffer;
           
            Console.WriteLine($"After: \n a={a} \n b={b}");

        }
    }
}
