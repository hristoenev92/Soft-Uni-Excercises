using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = 0;
            int count;
            int bestCount = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                count = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])count++ ;
                }
                if (count>bestCount)
                {
                    element = array[i];
                    bestCount = count;
                }
            }
            Console.WriteLine(element);

           
        }
    }
}
