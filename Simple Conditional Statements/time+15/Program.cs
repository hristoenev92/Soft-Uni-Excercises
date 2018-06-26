using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int d = m + 15;
            if (d > 59) {
                h = h + 1;
                d = d - 60;
                if (h == 24)
                {
                    h = 0;
                    if (d < 10) Console.WriteLine(h + ":0" + d);
                    else
                        Console.WriteLine(h + ":" + d);
                }
                else if (d < 10) Console.WriteLine(h + ":0" + d);
                else
                    Console.WriteLine(h + ":" + d);
            }
            else if (d < 10) Console.WriteLine(h + ":0" + d);
            else Console.WriteLine(h + ":" + d);
         
        }
    }
}
