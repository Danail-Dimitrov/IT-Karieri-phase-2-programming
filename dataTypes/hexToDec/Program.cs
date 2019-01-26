using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            short inDec = Convert.ToInt16(input, 16);

            Console.WriteLine(inDec);
        }
    }
}
