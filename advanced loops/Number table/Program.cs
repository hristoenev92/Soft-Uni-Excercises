using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int row = 0; row < n; row++)
            {
                int num = 0;
                for (int col = 0; col < n; col++)
                {
                    num++;
                    if (num<n)
                    Console.Write((num = row + col + 1) + " ");
                    else Console.Write((2 * n - num) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
