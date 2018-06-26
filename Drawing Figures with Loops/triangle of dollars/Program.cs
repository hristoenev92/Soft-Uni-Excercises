using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_of_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row<=n; row++)
            {
                for (int col = 1; col <=row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
