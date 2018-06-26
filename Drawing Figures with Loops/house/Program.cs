using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 1;
            if (n % 2 == 0) s = 2;
            for (int i = 1; i <= (n+1)/2; i++)
            {
                Console.Write(new string('-', (n - s)/2));
                Console.Write(new string('*', s));
                Console.WriteLine(new string('-', (n - s) / 2));
                s += 2;
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine('|' + new string('*', n - 2) + '|');
            }
        }
    }
}
