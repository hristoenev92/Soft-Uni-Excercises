﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <1||n>100)
            {
                Console.Write("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100) Console.WriteLine("Invalid number!");
                else Console.WriteLine("The number is: "+n);
            }
            
        }
    }
}
