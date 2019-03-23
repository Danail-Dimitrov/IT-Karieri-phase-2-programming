using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArgs = Console.ReadLine().Split(':').ToArray();
            string person = commandArgs[0];
            Dictionary<string, int> playerPower = new Dictionary<string, int>();

            while (person != "JOKER")
            {
                List<string> cards = commandArgs[1].Split(' ', ',').Where(x => x != "").ToList();
                int power = 0;
                for (int i = 0; i < cards.Count; i++)
                {                   
                    for (int j = cards.Count-1; j > 0; j--)
                    {
                        if (cards[i] == cards[j] && i!=j)
                        {
                            cards.RemoveAt(j);
                        }
                    }
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    char[] charArr = cards[i].ToCharArray();
                    char a = charArr[0];
                    string card;
                    if (cards[i].Length == 2)
                    {
                        card = cards[i].Substring(0, 1);
                    }
                    else
                    {
                       card = cards[i].Substring(0, 1);
                       card += cards[i].Substring(1, 1);
                    }                   
                    string type;
                    if (cards[i].Length == 2)
                    {
                        type = cards[i].Substring(1, 1);
                    }
                    else
                    {
                        type = cards[i].Substring(2, 1);
                    }
                    bool isDigit = Char.IsDigit(a);
                    int multiply = 1;

                    if (type == "S")
                    {
                        multiply = 4;
                    }
                    else if (type == "H")
                    {
                        multiply = 3;
                    }
                    else if (type == "D")
                    {
                        multiply = 2;
                    }

                    int cartInt;
                    if (isDigit)
                    {
                        cartInt = int.Parse(card);                      
                    }
                    else
                    { 
                        if (card == "J")
                        {
                            cartInt = 11;
                        }
                        else if (card == "Q")
                        {
                            cartInt = 12;
                        }
                        else if (card == "K")
                        {
                            cartInt = 13;
                        }
                        else
                        {
                            cartInt = 14;
                        }
                    }
                    power += cartInt * multiply;
                }
              
                if (!playerPower.ContainsKey(person))
                {
                    playerPower.Add(person, power);
                }
                else//106
                {
                    playerPower[person] += power;
                }

                commandArgs = Console.ReadLine().Split(':').ToArray();
                person = commandArgs[0];
            }
            foreach (var pair in playerPower)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}
