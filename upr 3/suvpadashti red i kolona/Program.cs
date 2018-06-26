using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suvpadashti_red_i_kolona
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[3, 3];
            int result=0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    if (mas[i, j] == mas[j, i])
                    {
                        result = i+1;//kolonata koqto e ravna
                    }
                    else break;
            }
            Console.WriteLine(result);
        }
    }
}
