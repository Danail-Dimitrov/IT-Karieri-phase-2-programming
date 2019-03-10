using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {

                string[] Args = command.Split(' ').ToArray();
                if (Args[0] == "A")
                {

                }
                command = Console.ReadLine();
            }
        }
    }
}
