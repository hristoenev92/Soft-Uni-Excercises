using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char b =char.Parse(Console.ReadLine());
            if (a < 16)
            {
                if (b == 'm') Console.WriteLine("Master");
                if (b == 'f') Console.WriteLine("Miss");
            }
            if (a >= 16)
            {
                if (b == 'm') Console.WriteLine("Mr.");
                if (b == 'f') Console.WriteLine("Ms.");
            }
        }
    }
}
