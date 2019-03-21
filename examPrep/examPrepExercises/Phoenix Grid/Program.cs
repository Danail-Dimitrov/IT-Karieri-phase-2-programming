using System;
using System.Linq;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] input = a.Split('.').ToArray();
            while (input[0] != "ReadMe")
            {
                bool isPalindrome = IsPalindrome(a);
                if ( isPalindrome && !a.Contains(" ") && !a.Contains("_"))
                {
                    Console.WriteLine("YES");
                }
                else if (input[0] == " " && input.Length % 2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                a = Console.ReadLine();
                input = a.Split('.').ToArray();
            }
        }

        private static bool IsPalindrome(string a)
        {
            string reversed = Reverse(a);
            if (a == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Reverse(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

