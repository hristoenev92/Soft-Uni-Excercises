using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if(a!=0)
                if (a < 100 || a > 200) Console.WriteLine("invalid");
        }
    }
}
