using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            int s = 0;
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                { s = i * 2;
                    Console.WriteLine(new string('-', leftRight - i) + '*' + new string('-',s) + '*' + new string('-', leftRight - i));
                }
                s = n - 2;
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    s=s - i*2-2;
                    Console.WriteLine(new string('-', leftRight + i-1) + '*' + new string('-',s) + '*' + new string('-', leftRight + i-1));
                    
                }
            }
            //else
            //{
            //    for (int i=0;i<n/2;i++)
            //    {
            //       if (mid<0) Console.WriteLine(new string('-', leftRight - i) + '*'  + new string('-', leftRight - i));
            //       else Console.WriteLine(new string('-', leftRight - i) + '*' + new string('-', mid + (i * 2)) + '*' + new string('-', leftRight - i));
            //    }
            //}
        }
    }
}
