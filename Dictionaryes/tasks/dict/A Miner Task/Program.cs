using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//renamed the task to 4. Fix Emails
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> eMails = new Dictionary<string, string>();
            string key = Console.ReadLine();

            while (key!="stop")
            {
                string value = Console.ReadLine();
                string ending = value.Substring(value.Length - 2, 2).ToLower();
                if (ending != "us" && ending != "uk")
                {
                    eMails.Add(key, value);
                }
                key = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> pair in eMails)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
