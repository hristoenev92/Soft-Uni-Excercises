using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace left_or_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int suml = 0;
            int sumr = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                suml = suml + a;
            }
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sumr = sumr + a;
            }
            if (suml - sumr == 0) Console.WriteLine("yes sum " + suml);
            else Console.WriteLine("no diff "+  Math.Abs(suml-sumr));
        }
    }
}