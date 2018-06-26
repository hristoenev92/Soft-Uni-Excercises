using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[100000];

            foreach (var element in inputArray)
            {
                count[element]++;
            }

            int maxCount = count.Max();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (count[inputArray[i]] == maxCount)
                {
                    Console.WriteLine(inputArray[i]);
                    return;
                }
            }
        }
    }
}
