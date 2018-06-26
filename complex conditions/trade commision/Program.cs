using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trade_commision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double comm = -1;
            if (city == "sofia")
            {
                if (s >= 0 && s <= 500) comm = s * 0.05;
                else if (s <= 1000) comm = s * 0.07;
                else if (s <= 10000) comm = s * 0.08;
                else if (s > 10000) comm = s * 0.12;
            }
            else if (city == "varna")
            {
                if (s >= 0 && s <= 500) comm = s * 0.045;
                else if (s <= 1000) comm = s * 0.075;
                else if (s <= 10000) comm = s * 0.10;
                else if (s > 10000) comm = s * 0.13;
            }
            else if (city=="plovdiv")
            {
                if (s >= 0 && s <= 500) comm = s * 0.055;
                else if (s <= 1000) comm = s * 0.08;
                else if (s <= 10000) comm = s * 0.12;
                else if (s > 10000) comm = s * 0.145;
            }
            if (comm >= 0) Console.WriteLine("{0:f2}",comm);
            else Console.WriteLine("error");

        }
    }
}
