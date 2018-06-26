using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lenght
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            switch (b)
            {
                case "m":

                    if (c == "cm") { Console.WriteLine(a * 100); }
                    if (c == "mm") { Console.WriteLine(a * 1000); }
                    if (c == "mi") { Console.WriteLine(a * 0.000621371); }
                    if (c == "in") { Console.WriteLine(a * 39.3701); }
                    if (c == "km") { Console.WriteLine(a * 0.001); }
                    if (c == "ft") { Console.WriteLine(a * 3.28084); }
                    if (c == "yd") { Console.WriteLine(a * 1.09361); }
                    if (c == "m") { Console.WriteLine(a); }
                    break;
                case "cm":

                    if (c == "m") { Console.WriteLine(a * 0.01); }
                    if (c == "mm") { Console.WriteLine(a * 10); }
                    if (c == "mi") { Console.WriteLine((a * 0.01) * 0.000621371); }
                    if (c == "in") { Console.WriteLine(a * 0.3937007874); }
                    if (c == "km") { Console.WriteLine((a * 0.01) * 0.001); }
                    if (c == "ft") { Console.WriteLine(a * 0.0328084); }
                    if (c == "yd") { Console.WriteLine(a * 0.0109361); }
                    if (c == "cm") { Console.WriteLine(a); }
                    break;
                case "mi":

                    if (c == "m") { Console.WriteLine(a * 1609.344); }
                    if (c == "mm") { Console.WriteLine(a * 1609344); }
                    if (c == "cm") { Console.WriteLine(a * 160934.40); }
                    if (c == "in") { Console.WriteLine(a * 63360); }
                    if (c == "km") { Console.WriteLine(a * 1.60934); }
                    if (c == "ft") { Console.WriteLine(a * 5280); }
                    if (c == "yd") { Console.WriteLine(a * 1760); }
                    if (c == "mi") { Console.WriteLine(a); }
                    break;

                case "in":

                    if (c == "m") { Console.WriteLine(a * 0.0254); }
                    if (c == "mm") { Console.WriteLine(a * 25.4); }
                    if (c == "cm") { Console.WriteLine(a * 2.54); }
                    if (c == "mi") { Console.WriteLine(a / 63360.00); }
                    if (c == "km") { Console.WriteLine(a / 39370.08); }
                    if (c == "ft") { Console.WriteLine(a * 0.0833333); }
                    if (c == "yd") { Console.WriteLine(a * 0.0277778); }
                    if (c == "in") { Console.WriteLine(a); }
                    break;

                case "km":

                    if (c == "m") { Console.WriteLine(a * 1000); }
                    if (c == "mm") { Console.WriteLine(a * 1000000); }
                    if (c == "cm") { Console.WriteLine(a * 100000); }
                    if (c == "mi") { Console.WriteLine(a * 0.62137119); }
                    if (c == "in") { Console.WriteLine(a * 39370.08); }
                    if (c == "ft") { Console.WriteLine(a * 3280.83989501); }
                    if (c == "yd") { Console.WriteLine(a * 1093.6133); }
                    if (c == "km") { Console.WriteLine(a); }
                    break;


                case "ft":

                    if (c == "m") { Console.WriteLine(a * 0.3048); }
                    if (c == "mm") { Console.WriteLine(a * 304.8); }
                    if (c == "cm") { Console.WriteLine(a * 30.48); }
                    if (c == "mi") { Console.WriteLine(a * 0.000189394); }
                    if (c == "in") { Console.WriteLine(a * 12); }
                    if (c == "yd") { Console.WriteLine(a * 0.333333); }
                    if (c == "km") { Console.WriteLine(a * 0.0003048); }
                    if (c == "ft") { Console.WriteLine(a); }
                    break;

                case "yd":

                    if (c == "m") { Console.WriteLine(a * 0.9144); }
                    if (c == "mm") { Console.WriteLine(a * 914.4); }
                    if (c == "cm") { Console.WriteLine(a * 91.44); }
                    if (c == "mi") { Console.WriteLine(a * 0.000568182); }
                    if (c == "in") { Console.WriteLine(a * 36); }
                    if (c == "ft") { Console.WriteLine(a * 3); }
                    if (c == "km") { Console.WriteLine(a * 0.0009144); }
                    if (c == "yd") { Console.WriteLine(a); }
                    break;
                case "mm":
                    if (c == "m") { Console.WriteLine(a * 0.001); }
                    if (c == "ft") { Console.WriteLine(a * 0.00328084); }
                    if (c == "cm") { Console.WriteLine(a * 0.1); }
                    if (c == "mi") { Console.WriteLine(a / 1609344.01); }
                    if (c == "in") { Console.WriteLine(a * 0.0393701); }
                    if (c == "yd") { Console.WriteLine(a * 0.00109361); }
                    if (c == "km") { Console.WriteLine(a / 1000000); }
                    if (c == "mm") { Console.WriteLine(a); }
                    break;

            }
        }
    }
}
