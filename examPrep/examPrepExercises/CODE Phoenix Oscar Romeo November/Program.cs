using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            //task incompleat
            List<string> input = Console.ReadLine().Split(' ').ToList();
            input.RemoveAt(1);
            SortedDictionary<string, List<string>> creatures = new SortedDictionary<string, List<string>>();
            while (input[0] != "Blaze")
            {
                string creature = input[0];
                string mate = input[1];
                if (!creatures.ContainsKey(creature))
                {
                    creatures.Add(creature,new List<string>());
                    if (!creatures[creature].Contains(mate))
                    {
                        creatures[creature].Add(mate);
                    }                   
                }
                else
                {
                    if (!creatures[creature].Contains(mate) )
                    {
                        creatures[creature].Add(mate);
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
                input.RemoveAt(1);
            }
            foreach (var pair in creatures)
            {
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    if (creatures.ContainsKey(pair.Value[i]) && pair.Value.Contains(pair.Key))
                    {
                        pair.Value.Remove(pair.Value[i]);
                    }
                }
            }
            creatures.OrderBy(x => x.Value.Count).ThenBy(x => x.Key);
            foreach (var pair in creatures)
            {
                //Mozilla : 2
                //Tony: 2
                Console.WriteLine("{0} : {1}",pair.Key, pair.Value.Count);
            }
        }
    }
}
