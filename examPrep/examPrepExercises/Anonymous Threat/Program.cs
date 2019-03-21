using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string[] comandArgs= Console.ReadLine().Split(' ').ToArray();

            while (true)
            {      
                if (comandArgs[0] == "merge")
                {
                    input = Merge(input, comandArgs);
                }
                else if (comandArgs[0] == "divide")
                {
                    input = Divide(input, comandArgs);
                }
                else
                {
                    break;
                }
                comandArgs = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ",input));
        }

        private static List<string> Divide(List<string> input, string[] comandArgs)
        {
            int index = int.Parse(comandArgs[1]);
            int partitions = int.Parse(comandArgs[2]);
            int charInObj,charInObjMax,charInObjMin;
            string[] toInput = new string[partitions];
            string workWith = input[index];
            int a = 0;
            int z = 0;

            if (workWith.Length % partitions == 0)
            {
               charInObj = (int)(workWith.Length / partitions);               
                for (int i = 0; i < partitions; i++)
                {
                    string b = string.Empty;                    
                    for (int j = 0; j < charInObj; j++) //a b cd efgh ijkl
                    {
                        b += workWith[ j + z];                       
                    }
                    z+=b.Length;
                    toInput[a] = b;
                    a++;
                }
            }
            else
            {
                double d = Math.Floor((double)(workWith.Length / partitions));
                charInObjMin = (int)(d);

                int m = charInObjMin * (partitions - 1);
                charInObjMax = workWith.Length - m;

                for (int i = 0; i < partitions-1; i++)
                {
                    string c = string.Empty;
                    for (int j = 0; j < charInObjMin; j++) //a b cd efgh ijkl
                    {
                        c += workWith[j +z];
                    }
                    z += c.Length;
                    toInput[a] = c;
                    a++;
                }
                string f = string.Empty;
                for (int j = 0; j < charInObjMax; j++) 
                {                  
                    f += workWith[workWith.Length-charInObjMax+ j];
                }
                toInput[a] = f;

            }
            input.RemoveAt(index);
            for (int i = 0; i < partitions; i++)
            {
                input.Insert(index + i, toInput[i]);
            }

            return input;
        }

        private static List<string> Merge (List<string> input, string[] comandArgs)
        {
            int startIndex = int.Parse(comandArgs[1]);
            int endIndex = int.Parse(comandArgs[2]);
            string toInput = string.Empty;

            if (startIndex<0)
            {
                startIndex = 0;
            }
            else if (startIndex > input.Count-1)
            {
                startIndex = input.Count - 1;
            }

            if (endIndex < 0)
            {
                endIndex = 0;
            }
            else if (endIndex > input.Count - 1)
            {
               endIndex = input.Count - 1;
            }

            int[] toRemove = new int[endIndex-startIndex+1];//a b cd efgh ijkl
            int j = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                toInput += input[i];
                toRemove[j] = i;
                j++;
            }

            int a = toRemove.Length;

            for (int i = 0; i < a-1; i++)
            {
                input.RemoveAt(startIndex);
            }

            input[startIndex] = toInput;

            return input;
        }
    }
}
