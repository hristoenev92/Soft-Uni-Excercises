﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x == x1||x==x2)
                if (y <= y2 && y1 <= y) Console.WriteLine("Border");
                else Console.WriteLine("Inside / Outside");
            else if (y == y1||y==y2)
                    if (x1 <= x && x <= x2) Console.WriteLine("Border");
                    else Console.WriteLine("Inside / Outside");
                 else Console.WriteLine("Inside / Outside");

        }
    }
}
