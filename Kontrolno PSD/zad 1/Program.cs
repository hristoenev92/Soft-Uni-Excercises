using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=4;
            int[,] matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input==0||input==1)
                    {
                       matrix[col, row] = input;
                    }
                }
            }
            int sumTop = 0;
            int sumBot = 0;
            Console.WriteLine("Matricata e: ");
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(matrix[cols,rows]+" ");
                    if (rows>cols)
                    {
                        sumBot += matrix[cols, rows];
                    }
                    if (cols>rows)
                    {
                        sumTop += matrix[cols, rows];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sumata nad glavniq diagonal e: ");
            Console.WriteLine(sumTop);
            Console.WriteLine("Sumata pod glavniq diagonal e: "+sumBot);
            int[] nmas = new int[n*n];
            int count = 0;
            for (int col = n-1; col >= 0; col--)
            {
                for (int row = n-1; row >= 0; row--)
                {
                    nmas[count++] = matrix[col, row];
                }
            }
            Console.WriteLine("Masiva e:");
            foreach (var item in nmas)
            {
                Console.Write(item+", ");
            }            
        }
    }
}
