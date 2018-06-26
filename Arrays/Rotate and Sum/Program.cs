using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] newArray = new int[array.Length];
            for (int j = 0; j < k; j++)
            {
                int last = array[array.Length-1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
                array[0] = last;
                for(int l=0;l<array.Length;l++)
                {
                    newArray[l] += array[l];
                }
            }
            Console.WriteLine(String.Join(" ",newArray));
        }
    }
}
