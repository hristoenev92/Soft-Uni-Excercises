using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            Console.WriteLine(a);
        }
    }
}
