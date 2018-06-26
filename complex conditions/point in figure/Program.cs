using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_in_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double x1 = 0.0;
            double y1 = 0.0;
            double x2 = 3*h;
            double y2 = h;
            double x3 = h;
            double y3 = h;
            double x4 = 2*h;
            double y4 = 4*h;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x < x1 || x > x2) Console.WriteLine("Outside");
            else if (y < y1 || y > y4) Console.WriteLine("Outside");
            else if (x > h * 2 && y > h) Console.WriteLine("Outside");
            else if (x < h && y > h) Console.WriteLine("Outside");
            else if (y == h && (x < h * 2 && x > h)) Console.WriteLine("Inside");
            else if ((x == x1 || x == x2) && (y >= y1 && y <= y2)) Console.WriteLine("Border");
            else if ((y == y1 || y == y2) && (x >= x1 && x <= x2)) Console.WriteLine("Border");
            else if ((x == x3 || x == x4) && (y >= y3 && y <= y4)) Console.WriteLine("Border");
            else if ((y == y3 || y == y4) && (x >= x3 && x <= x4)) Console.WriteLine("Border");
            else Console.WriteLine("Inside");


        }
    }
}
