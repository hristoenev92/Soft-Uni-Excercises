﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            for (int row = 1; row <= n; row++)
            {

                for (int col = 1; col <= row; col++)
                {
                    Console.Write(s++ + " ");
                    if (s > n) break;
                }
                Console.WriteLine();
                if (s > n) break;
            }
        }
    }
}
