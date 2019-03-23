using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToursitDesctinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bulgaria -> [Sofia, Plovdiv, Varna..]
            var destinations = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(' ').ToArray();

                if (commandArgs[0] == "Add")
                {
                    var countryName = commandArgs[1];
                    var cityName = commandArgs[2];

                    if (!destinations.ContainsKey(countryName))
                    {
                        destinations.Add(countryName, new List<string>());
                    }

                    destinations[countryName].Add(cityName);
                }
                else if (commandArgs[0] == "Remove")
                {
                    var cityName = commandArgs[1];

                    bool cityIsRemoved = false;

                    foreach (List<string> cities in destinations.Values)
                    {
                        if (cities.Contains(cityName))
                        {
                            cities.Remove(cityName);
                            cityIsRemoved = true;
                            break;
                        }
                    }

                    if (!cityIsRemoved)
                    {
                        Console.WriteLine($"City {cityName} not found");
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var country in destinations
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{country.Key} has {country.Value.Count} cities and they are: {string.Join(", ", country.Value.OrderBy(x => x))}");
            }
        }
    }
}
