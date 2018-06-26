using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (;  n!=0 ; n=n/10)
            {
                a = (n % 10)+a;
            }
            Console.WriteLine(a);
        }
    }
}
