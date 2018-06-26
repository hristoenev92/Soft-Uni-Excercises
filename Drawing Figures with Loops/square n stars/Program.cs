using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_n_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                for (int y = 0; y < n - 1; y++)
                { Console.Write(" *"); }
                Console.WriteLine();

            }
        }
    }
}
