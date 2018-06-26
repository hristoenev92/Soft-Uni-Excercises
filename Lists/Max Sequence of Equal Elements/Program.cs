using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lenght = 1;
            int bestStart = 0;int bestLenght = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]==list[i-1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if (lenght>bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = i-lenght+1;
                }
            }
            for (int j = bestStart; j < bestLenght+bestStart ; j++)
            {
                Console.Write("{0} ",list[j]);
            }
            Console.WriteLine();
        }
    }
}
