using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace half_sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i == 0) max = a;
                if (a > max) max = a;
                sum = sum + a;
            }
            if (sum - max == max) Console.WriteLine("yes sum "+max);
            else Console.WriteLine("no diff "+Math.Abs(max-(sum-max)));
        }
    }
}
