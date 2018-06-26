using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] len = new int[list.Count];
            int[] prev = new int[list.Count];
            List<int> LIS = new List<int>();
            int maxLenght = 0;
            int lastIndex = -1;
            
            for (int p = 0; p < list.Count; p++)
            {
                len[p] = 1;
                prev[p] = -1;
                for (int left = 0; left < p; left++)
                    if (list[left] < list[p] && len[left] >= len[p])
                    {
                        len[p] = 1 + len[left];
                        prev[p] = left;
                    }
                if (len[p]>maxLenght)
                {
                    maxLenght = len[p];
                    lastIndex = p;
                }
            }
            for (int i = 0; i < maxLenght; i++)
            {
                LIS.Add(list[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            LIS.Reverse();
            Console.WriteLine($"{string.Join(" ",LIS)}");
        }
    }
}
