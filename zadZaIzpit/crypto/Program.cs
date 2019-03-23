using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoinPrice = decimal.Parse(Console.ReadLine());
            decimal ethereumPrice = decimal.Parse(Console.ReadLine());
            decimal litecoinPrice = decimal.Parse(Console.ReadLine());

            int transactionsCount = int.Parse(Console.ReadLine());

            long bitcoinCount = 0;
            long ethereumCount = 0;
            long litecoinCount = 0;

            // 723277.3375077729276735
            //757890.1648067240670375

            decimal commisionRate = 0.073456764216789345M;
            decimal commisionValue = 0;

            for (int i = 0; i < transactionsCount; i++)
            {
                long quantity = long.Parse(Console.ReadLine());
                string currencyName = Console.ReadLine();
                string buyOrSell = Console.ReadLine();

                if (buyOrSell == "Buy")
                {
                    if (currencyName == "Bitcoin")
                    {
                        bitcoinCount += quantity;
                        commisionValue += quantity * bitcoinPrice * commisionRate;
                    }
                    else if (currencyName == "Ethereum")
                    {
                        ethereumCount += quantity;
                        commisionValue += quantity * ethereumPrice * commisionRate;

                    }
                    else if (currencyName == "Litecoin")
                    {
                        litecoinCount += quantity;
                        commisionValue += quantity * litecoinPrice * commisionRate;
                    }
                }
                else
                {

                    if (currencyName == "Bitcoin")
                    {
                        bitcoinCount -= quantity;
                        commisionValue += quantity * bitcoinPrice * commisionRate;

                    }
                    else if (currencyName == "Ethereum")
                    {
                        ethereumCount -= quantity;
                        commisionValue += quantity * ethereumPrice * commisionRate;

                    }
                    else if (currencyName == "Litecoin")
                    {
                        litecoinCount -= quantity;
                        commisionValue += quantity * litecoinPrice * commisionRate;

                    }
                }
            }

            decimal result = (
                bitcoinPrice * bitcoinCount +
                ethereumPrice * ethereumCount +
                litecoinPrice * litecoinCount)
                - commisionValue;

            Console.WriteLine($"{result:F16}");

        }
    }
}
