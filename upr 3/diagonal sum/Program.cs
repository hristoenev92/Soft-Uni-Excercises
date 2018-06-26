using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            Random r = new Random();
            int sum = 0;
            decimal avg = 0;
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = r.Next(0, 5);
                    if (i == j)
                    {
                        Console.WriteLine(mas[i,j]);
                        sum += mas[i, j];
                        if (mas[i, j] == 0) count++;
                    }
                }
            }
            avg = sum / 10;
            Console.WriteLine(avg);
            Console.WriteLine(count);
        }
    }
}
