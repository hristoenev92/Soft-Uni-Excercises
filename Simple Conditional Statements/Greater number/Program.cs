using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a >= b) Console.WriteLine("Greater number: {0}" ,a);
            else Console.WriteLine("Greater number: {0}" ,b);
        }
    }
}
