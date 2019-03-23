using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromClass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoinPrice = decimal.Parse(Console.ReadLine());
            decimal ethereumPrice = decimal.Parse(Console.ReadLine());
            decimal litecoinPrice = decimal.Parse(Console.ReadLine());

            int transactionsCount = int.Parse(Console.ReadLine());

            long bitcoin = 0;
            long ethereum = 0;
            long litecoin = 0;
            decimal commisionValue = 0;

            decimal commisionRate = 0.073456764216789345M;
            for (int i = 0; i < transactionsCount; i++)
            {
                int amount = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                string action = Console.ReadLine();
          
                if (type=="Bitcoin")
                {
                    if (action == "Buy")
                    {
                        bitcoin += amount;
                        commisionValue += (bitcoinPrice * amount) * commisionRate;
                    }
                    else
                    {
                        bitcoin -= amount;
                        commisionValue += amount * bitcoinPrice * commisionRate;
                    }
                }
                else if (type=="Ethereum")
                {
                    if (action == "Buy")
                    {
                        ethereum += amount;
                        commisionValue += (ethereumPrice * amount) * commisionRate;
                    }
                    else
                    {
                        ethereum -= amount;
                        commisionValue += (ethereumPrice * amount) * commisionRate;
                    }
                }
                else
                {
                    if (action == "Buy")
                    {
                        litecoin += amount;
                        commisionValue += (litecoinPrice * amount) * commisionRate;
                    }
                    else
                    {
                        litecoin -= amount;
                        commisionValue += (litecoinPrice * amount) * commisionRate;
                    }
                }
            }
            decimal value = (bitcoin * bitcoinPrice) + (ethereum * ethereumPrice) + (litecoin * litecoinPrice) - commisionValue;
            Console.WriteLine("{0}", value);
        }
    }
}
