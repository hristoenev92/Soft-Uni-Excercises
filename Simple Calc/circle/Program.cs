using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(r*r*Math.PI);
            Console.WriteLine(2*r*Math.PI);

        }
    }
}
