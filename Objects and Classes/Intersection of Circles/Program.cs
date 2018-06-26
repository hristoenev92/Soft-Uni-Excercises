using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> circle1 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> circle2 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            decimal d = (decimal)Math.Sqrt(Math.Pow(circle2[0] - circle1[0], 2) + Math.Pow(circle2[1] - circle1[1], 2));
            decimal r = (decimal)circle1[2] + (decimal)circle2[2];
            if (r >= d)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
            
        }
    }
}
