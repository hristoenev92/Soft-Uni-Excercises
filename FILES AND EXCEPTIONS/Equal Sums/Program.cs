using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../input.txt");
            int[] inputArray = input.Split(' ').Select(int.Parse).ToArray();
            bool foundSums = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int[] leftSide = inputArray.Take(i).ToArray();
                int[] rightSide = inputArray.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    File.WriteAllText("../../output.txt",i.ToString());
                    foundSums = true;
                    break;
                }
            }

            if (!foundSums)
            {
                File.WriteAllText("../../output.txt","no");
            }
        }
    }
}
