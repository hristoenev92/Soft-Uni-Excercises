using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = a / 10;
            int c = a % 10;
            string d = "";
            string e = "";
            if ((a < 0) || (a > 100)) Console.WriteLine("invalid number");
            else
                if (a == 0) Console.WriteLine("zero");
            else
            {
                switch (c)
                {
                    case 1:
                        e = "one";
                        break;
                    case 2:
                        e = "two";
                        break;
                    case 3:
                        e = "three";
                        break;
                    case 4:
                        e = "four";
                        break;
                    case 5:
                        e = "five";
                        break;
                    case 6:
                        e = "six";
                        break;
                    case 7:
                        e = "seven";
                        break;
                    case 8:
                        e = "eight";
                        break;
                    case 9:
                        e = "nine";
                        break;
                    case 0:
                        e = "";
                        break;


                }
                switch (b)
                {
                    case 0:
                        Console.WriteLine($"{e}");
                        break;
                    case 1:
                        if (c == 0) Console.WriteLine("ten");
                        if (c == 1) Console.WriteLine("eleven");
                        if (c == 2) Console.WriteLine("twelve");
                        if (c == 3) Console.WriteLine("thirteen");
                        if (c == 4) Console.WriteLine("fourteen");
                        if (c == 5) Console.WriteLine("fifteen");
                        if (c == 6) Console.WriteLine("sixteen");
                        if (c == 7) Console.WriteLine("seventeen");
                        if (c == 8) Console.WriteLine("eighteen");
                        if (c == 9) Console.WriteLine("nineteen");
                        break;
                    case 2:
                        d = "twenty";
                        break;
                    case 3:
                        d = "thirty";
                        break;
                    case 4:
                        d = "forty";
                        break;
                    case 5:
                        d = "fifty";
                        break;
                    case 6:
                        d = "sixty";
                        break;
                    case 7:
                        d = "seventy";
                        break;
                    case 8:
                        d = "eighty";
                        break;
                    case 9:
                        d = "ninety";
                        break;
                    case 10:
                        d = "one hundred";
                        break;
                }

                if (b > 1)
                    if (c == 0) Console.WriteLine(d);
                    else Console.WriteLine($"{d} {e}");
            }
        }
    }
}
