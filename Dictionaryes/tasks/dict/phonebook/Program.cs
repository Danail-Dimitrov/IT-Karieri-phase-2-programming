//This task has been upgradet to task 2.Phonebook Upgrade
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
            //This task has been upgradet to task 2.Phonebook Upgrade
            var phonebook = new SortedDictionary<string, string>();
            string[] comandArgs = Console.ReadLine().Split(' ').ToArray();
            string command = comandArgs[0];

            while (command != "END")
            {
                if (command == "A")
                {
                    Add(phonebook, comandArgs);
                }
                else if (command == "S")
                {
                    Search(phonebook, comandArgs);
                }
                else if (command == "ListAll")
                {
                    PrintAll(phonebook);
                }
                comandArgs = Console.ReadLine().Split(' ').ToArray();
                command = comandArgs[0];
            }
        }

        private static void PrintAll(SortedDictionary<string, string> phonebook)
        {
            //This task has been upgradet to task 2.Phonebook Upgrade
            foreach (var pair in phonebook)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        private static void Search(SortedDictionary<string, string> phonebook, string[] comandArgs)
        {
            //This task has been upgradet to task 2.Phonebook Upgrade
            string name = comandArgs[1];
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        private static void Add(SortedDictionary<string, string> phonebook, string[] comandArgs)
        {
            //This task has been upgradet to task 2.Phonebook Upgrade
            string name = comandArgs[1];
            string number = comandArgs[2];
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, number);
            }
            else
            {
                phonebook[name] = number;
            }
        }
    }
}
//This task has been upgradet to task 2.Phonebook Upgrade