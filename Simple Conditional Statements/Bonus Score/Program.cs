using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = 0.0;
            if (a <= 100) b = a + 5.0;
            else if (a <= 1000) b = a + (a * 2.0 / 10);
            else b = a + (a * 1.0 / 10);
            if (a % 2 == 0) b = b + 1.0;
            else if (a % 5 == 0) b = b + 2.0;
            Console.WriteLine(b-a);
            Console.WriteLine(b);
        }
    }
}
