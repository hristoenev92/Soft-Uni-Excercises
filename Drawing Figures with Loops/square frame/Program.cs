﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char dash = '-';
            Console.Write('+');
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" {0}",dash);
            }
            Console.WriteLine(" +");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write('|');
                for (int y = 0; y < n - 2; y++)
                {
                    Console.Write(" {0}", dash);
                }
                Console.WriteLine(" |");
            }
            Console.Write('+');
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" {0}", dash);
            }
            Console.WriteLine(" +");
        }
    }
}
