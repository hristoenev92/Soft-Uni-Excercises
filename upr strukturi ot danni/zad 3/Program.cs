using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n,n];
            List<int> red = new List<int>();
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    array[col,row] = int.Parse(Console.ReadLine());
                    red.Add(array[col, row]);
                }
            }
            red.Sort();
            int element = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    array[row, col] = red[element++];
                }
            }
            Console.Clear();
            for (int col = 0;  col< n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    Console.Write(array[col,row]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
