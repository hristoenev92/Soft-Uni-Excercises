using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../input.txt");
            int[] inputArray = input.Split(' ').Select(int.Parse).ToArray();
            int[] count = new int[100000];

            foreach (var element in inputArray)
            {
                count[element]++;
            }

            int maxCount = count.Max();
            string output="";
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (count[inputArray[i]] == maxCount)
                {
                    output = inputArray[i].ToString();
                    File.WriteAllText("../../output.txt", output);
                    return;
                }
            }
            
        }
    }
}
