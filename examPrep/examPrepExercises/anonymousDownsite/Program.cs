using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace anonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());
            decimal loses = 0m;
            string[] sites = new string[n];
            var token = new BigInteger(1);


            for (int i = 0; i < n; i++)
            {
                string[] siteInfo = Console.ReadLine().Split(' ').ToArray();
                sites[i] = siteInfo[0];
                uint siteVisits = uint.Parse(siteInfo[1]);
                decimal siteValuePerVisit = decimal.Parse(siteInfo[2]);
                token *= secKey;
                loses += siteValuePerVisit * siteVisits;
            }
            for (int i = 0; i < sites.Length; i++)
            {
                Console.WriteLine(sites[i]);  
            }
            Console.WriteLine("Total Loss: {0:f20}",loses);
            Console.WriteLine($"Security Token: {token.ToString()}");
        }
    }
}
