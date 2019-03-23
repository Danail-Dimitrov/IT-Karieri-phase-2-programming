using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fromclass_Comands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "print")
            {
                string[] commandArgs = command.Split(' ').ToArray();

                if (commandArgs[0]=="push")
                {
                    int toPush = int.Parse(commandArgs[1]);
                    list.Add(toPush);
                }
                else if (commandArgs[0] == "pop")
                {
                    Console.WriteLine(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
                else if (commandArgs[0] == "shift")
                {
                    int first = list[0];
                    int last = list[list.Count - 1];
                    list[0] = last;
                    list[list.Count - 1] = first;
                }
                else if (commandArgs[0] == "addMany")
                {
                    int index =int.Parse(commandArgs[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        List<int> numbersToAdd = commandArgs.Skip(2).Select(int.Parse).ToList();
                        list.InsertRange(index, numbersToAdd);
                    }
                }
               else if (commandArgs[0] == "remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                }
                    command = Console.ReadLine();
            }
            list.Reverse();
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
