﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=0;i<n;i++)
            {
                int a= int.Parse(Console.ReadLine());
                sum = sum + a;

            }
            Console.WriteLine(sum);
        }
    }
}
