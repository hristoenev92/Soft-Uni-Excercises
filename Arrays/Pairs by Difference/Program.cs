using System;
using System.Linq;


namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentNum = inputArray[i];
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    int secondNum = inputArray[j];
                    if (currentNum-secondNum==difference||secondNum-currentNum==difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
