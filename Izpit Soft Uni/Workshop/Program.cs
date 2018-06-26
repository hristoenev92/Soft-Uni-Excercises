using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int masi = int.Parse(Console.ReadLine());
            double dylj=double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());

            double sPokr = masi*((dylj+2*0.30) * (2*0.30+shirina));
            double sKare = masi*((dylj / 2) * (dylj / 2));

            double cenapokr = sPokr * 7;
            double cenakare = sKare * 9;

            Console.WriteLine($"{(cenakare+cenapokr):f2} USD");
            Console.WriteLine($"{1.85*(cenapokr+cenakare):f2} BGN");

        }
    }
}
