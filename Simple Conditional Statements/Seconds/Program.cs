using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = a + b + c;
            if (d < 60)
                if (d < 10) Console.WriteLine("0:0" + d);
            else Console.WriteLine("0:" + d); ;
            if (d >= 60 && d < 120)
                if((d-60)<10)Console.WriteLine("1:0"+(d-60));
            else Console.WriteLine("1:" + (d - 60));
            if (d >= 120)
                if ((d - 120) < 10) Console.WriteLine("2:0" + (d - 120));
                else Console.WriteLine("2:" + (d - 120));
        }
    }
}
