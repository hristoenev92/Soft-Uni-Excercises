using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatirane_na_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 123.45678;
            Console.WriteLine("{0:f2}",n);//123.46
            Console.WriteLine($"{n:f3}");//123.457
        }
    }
}
