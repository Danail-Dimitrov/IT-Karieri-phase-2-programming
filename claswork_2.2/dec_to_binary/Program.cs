using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            //binary
            string result = "";
            while (dec > 0)
            {
                result += dec % 2;
                dec /= 2;
            }
            Console.WriteLine("binary "+new string(result.Reverse().ToArray()));
        }
    }
}
