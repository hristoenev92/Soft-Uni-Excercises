using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] a = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            StringBuilder result = new StringBuilder();
            BigInteger baseN = a[0];
            BigInteger base10 = a[1];


            while (base10 > 0)
            {
                string rem = (base10 % baseN).ToString();
                result.Insert(0, rem);
                base10 /= baseN;
            }
            Console.WriteLine(result);
        }
    }
}

