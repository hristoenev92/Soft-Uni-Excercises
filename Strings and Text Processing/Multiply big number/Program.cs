using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            int secondNum = int.Parse(Console.ReadLine());
            if (secondNum==0)
            {
                Console.WriteLine("0");return;
            }
            if (secondNum==1)
            {
                Console.WriteLine(firstNum);return;
            }
            StringBuilder result = new StringBuilder();
            int ostatyk = 0;
            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int a = int.Parse(firstNum[i].ToString()) * secondNum + ostatyk;
                if (i == 0)
                {
                    result.Insert(0, a);
                    break;
                }
                ostatyk = 0;
                if (a >= 10)
                {
                    ostatyk = a/10;
                    a = a % 10;
                }
                result.Insert(0, a);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
