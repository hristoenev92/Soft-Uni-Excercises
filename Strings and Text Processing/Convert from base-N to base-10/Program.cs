using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] a = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger result = 0;
            BigInteger baseN = a[0];
            BigInteger base10 = a[1];

            for(int i=0; base10>0;i++)
            {
                BigInteger lastDigit = base10 % 10;
                result += lastDigit * BigInteger.Pow(baseN, i);
                base10 /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
