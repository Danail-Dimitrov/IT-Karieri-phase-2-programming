using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//speling error
namespace RaimAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> customers = new Dictionary <string, List<int>>();

            while (command != "I believe I can fly!")
            {
                List <string> commandArgs= command.Split(' ').ToList();
                if (commandArgs.Contains("="))
                {
                    string nameCopy = commandArgs[0];
                    string nameOg = commandArgs[2];
                    if (customers.ContainsKey(nameCopy))
                    {
                        customers.Remove(nameCopy);

                    }
                    customers[nameCopy] = customers[nameOg].ToList();
                }
                else
                {
                    string name = commandArgs[0];
                    commandArgs.RemoveAt(0);
                    List<int> numbers = commandArgs.Select(int.Parse).ToList();
                    if (!customers.ContainsKey(name))
                    {
                        customers.Add(name, new List<int>());
                    }
                    customers[name].AddRange(numbers);
                }
                command = Console.ReadLine();
            }
            foreach (var pair in customers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                pair.Value.Sort();
                Console.WriteLine("#{0} ::: {1}", pair.Key, string.Join(", ", pair.Value.OrderBy(x => x)));
            }
        }
    }
}
