using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_or_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumo = 0;
            int sume = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 0) sume = sume + a;
                else sumo = sumo + a;
            
            }
            if (sume - sumo == 0) Console.WriteLine("yes sum " + sume);
            else Console.WriteLine("no diff " + Math.Abs(sume - sumo));
        }
    }
}
