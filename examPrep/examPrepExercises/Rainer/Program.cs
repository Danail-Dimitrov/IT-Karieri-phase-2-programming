using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int index = sequence[sequence.Count - 1];
            List<int> initialValues = sequence.GetRange(0, sequence.Count-1);
            sequence.RemoveAt(sequence.Count - 1);
            bool isWet = false;
            bool a = true;
            bool b = true;
            int steps = 0;

            while (!isWet)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] -= 1;
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0 && i == index)
                    {                                           
                        isWet = true;
                        a = false;
                        b = false;
                        steps--;
                        break;                                  
                    }                  
                }
                if (b)
                {
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] == 0)
                        {
                            sequence[i] = initialValues[i];
                        }
                    }
                }
                if (a)
                {
                    index = int.Parse(Console.ReadLine());
                }
                steps++;
            }
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(steps);
        }
    }
}
