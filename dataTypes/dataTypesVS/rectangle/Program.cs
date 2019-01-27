using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //s
            Console.WriteLine(a * b);

            //p
            Console.WriteLine(a * 2 + b * 2);

            //d
            Console.WriteLine(Math.Sqrt(Math.Pow(a , 2) + Math.Pow(b, 2)));
        }
    }
}
