using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine().TrimStart('0');
            StringBuilder result = new StringBuilder();
            if (firstNum.Length<secondNum.Length)
            {
                string vremenno = firstNum;
                firstNum = secondNum;
                secondNum = vremenno;
            }
            secondNum=secondNum.PadLeft(firstNum.Length, '0');
            int ostatyk = 0;
            for (int i = firstNum.Length-1; i >= 0; i--)
            {
                int a = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString())+ostatyk;
                if (ostatyk==1&&i==0)
                {
                    result.Insert(0, a);
                    break;
                }
                ostatyk = 0;
                if (a>=10)
                {
                    ostatyk = 1;
                    a = a % 10;
                }
                result.Insert(0,a);  
            }
            Console.WriteLine(result.ToString());
            
        }
    }
}
