using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine().ToLower();
            string a = Console.ReadLine().ToLower();
            double c = double.Parse(Console.ReadLine());
            double d = 0.0;
            if (b == "coffee")
            {
                if (a == "sofia") d = c * 0.5;
                if (a == "plovdiv") d = c * 0.4;
                if (a == "varna") d = c * 0.45;
            }
            if (b == "water")
            {
                if (a == "sofia") d = c * 0.8;
                if (a == "plovdiv") d = c * 0.7;
                if (a == "varna") d = c * 0.7;
            }
            if (b == "beer")
            {
                if (a == "sofia") d = c * 1.2;
                if (a == "plovdiv") d = c * 1.15;
                if (a == "varna") d = c * 1.1;
            }
            if (b == "sweets")
            {
                if (a == "sofia") d = c * 1.45;
                if (a == "plovdiv") d = c * 1.3;
                if (a == "varna") d = c * 1.35;
            }
            if (b == "peanuts")
            {
                if (a == "sofia") d = c * 1.6;
                if (a == "plovdiv") d = c * 1.5;
                if (a == "varna") d = c * 1.55;
            }
            Console.WriteLine(d);
        }
    }
}
