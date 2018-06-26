using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stipendiq
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double zaplata = double.Parse(Console.ReadLine());

            double socStip =Math.Floor(zaplata * 0.35);
            double otlStip = Math.Floor(uspeh * 25);
            if (dohod<zaplata)
                if(uspeh>=5.5)
                    if(socStip>otlStip) Console.WriteLine($"You get a Social scholarship {socStip} BGN");
            else Console.WriteLine($"You get a scholarship for excellent results {otlStip} BGN");
            else if (uspeh>4.5) Console.WriteLine($"You get a Social scholarship {socStip} BGN");
            else Console.WriteLine("You cannot get a scholarship!");
            else if (uspeh >= 5.5) Console.WriteLine($"You get a scholarship for excellent results {otlStip} BGN");
            else Console.WriteLine("You cannot get a scholarship!");


         
        }
    }
}
