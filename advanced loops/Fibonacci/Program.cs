using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a=1, b=1, c=1;
            for (int i = 2; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            Console.WriteLine(c);
        }
    }
}
