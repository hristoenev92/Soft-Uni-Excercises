using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double result = (((48 - h) * 3.0 / 4) + h) + (p * 2.0 / 3);
            if (year == "normal") Console.WriteLine(Math.Truncate(result));
            else if (year == "leap")
            {
                result = result + (result * 0.15);
                Console.WriteLine(Math.Truncate(result));
            }
        }
    }
}
