using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandArgs = command.Split(' ').ToArray();

                if (commandArgs[0] == "push")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);

                }
                else if (commandArgs[0] == "pop")
                {
                    int number = numbers.Last();
                    numbers.RemoveAt(numbers.Count - 1);
                    Console.WriteLine(number);
                }
                else if (commandArgs[0] == "shift")
                {
                    int lastNumber = numbers.Last();
                    int firstNumber = numbers.First();

                    numbers[0] = lastNumber;
                    numbers[numbers.Count - 1] = firstNumber;
                }
                else if (commandArgs[0] == "remove")
                {
                    int position = int.Parse(commandArgs[1]);

                    if (position >= 0 && position < numbers.Count)
                    {
                        numbers.RemoveAt(position);
                    }

                }
                else if (commandArgs[0] == "addMany")
                {
                    int position = int.Parse(commandArgs[1]);

                    if (position >= 0 && position < numbers.Count)
                    {
                        List<int> numbersToAdd = commandArgs.Skip(2).Select(int.Parse).ToList();
                        numbers.InsertRange(position, numbersToAdd);
                    }
                }

                command = Console.ReadLine();
            }

            numbers.Reverse();

            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}
