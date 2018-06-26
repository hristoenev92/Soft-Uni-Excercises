using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random n = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = n.Next(-3000, 3001);
                if (i%2==0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
