using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastNumber = nums.Last();

            while (nums.Contains(lastNumber))
            {
                nums.Remove(lastNumber);
            }
            Console.Write(string.Join(", ", nums));
            Console.WriteLine(" ");
        } 
    }
}
