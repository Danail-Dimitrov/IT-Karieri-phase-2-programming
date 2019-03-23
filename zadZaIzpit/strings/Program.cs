using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            //alyakeykala kalakey  -> AHAHAHA
            int startIndexOfThePattern = text.LastIndexOf(pattern);

            while (startIndexOfThePattern != -1 && pattern.Length > 0)
            {
                text = text.Remove(startIndexOfThePattern, pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);

                pattern = string.Join("", pattern.Reverse());

                startIndexOfThePattern = text.LastIndexOf(pattern);
            }

            Console.WriteLine(text);

        }
    }
}
