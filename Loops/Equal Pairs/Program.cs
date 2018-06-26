using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            int sum = 0;
            double max = 0;
            
            for (int i=0;i<n;i++)
            {
                sum2 = sum1;
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                sum1 = a + b;
                if (i == 0) {sum2 = sum1;}
                if (sum1!=sum2)
                {
                    sum++;
                    double diff = Math.Abs(sum1 - sum2);
                    if (diff > max) max = diff;
                }
               

            }
            if (sum == 0) Console.WriteLine("Yes, value "+sum1);
            else Console.WriteLine("No, maxdiff "+max);
        }
    }
}
