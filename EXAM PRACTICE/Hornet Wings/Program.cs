using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceBeforeBreak = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            double distanceTotal = ((double)wingFlaps / 1000) * distanceBeforeBreak;
            int time = (wingFlaps / 100) + ((wingFlaps / endurance) * 5);
            Console.WriteLine($"{distanceTotal:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
