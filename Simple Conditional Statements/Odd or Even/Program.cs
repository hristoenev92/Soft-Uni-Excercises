using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");

        }
    }
}
