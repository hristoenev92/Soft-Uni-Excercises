using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3,3];
            Random r = new Random();
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = r.Next(-30, 31);
                    if (mas[i, j] > 0)
                        sum += mas[i, j];
                }
            }
            Console.WriteLine(sum);


        }
    }
}
