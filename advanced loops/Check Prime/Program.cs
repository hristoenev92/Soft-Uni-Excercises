using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            if (n < 2) Console.WriteLine("Not Prime");
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0) s++;
                    if (s > 0) break;
                }
                if (s > 0) Console.WriteLine("Not Prime");
                else Console.WriteLine("Prime");
            }
        }
    }
}
