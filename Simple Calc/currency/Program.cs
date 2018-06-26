using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string valuta1 = Console.ReadLine();
            string valuta2 = Console.ReadLine();
            if (valuta1 == "BGN" && valuta2 == "EUR")
                Console.WriteLine(Math.Round(a / 1.95583,2));
            if (valuta1 == "EUR" && valuta2 == "BGN")
                Console.WriteLine(Math.Round(a * 1.95583, 2));
            if (valuta1 == "BGN" && valuta2 == "USD")
                Console.WriteLine(Math.Round(a / 1.79549, 2));
            if (valuta1 == "USD" && valuta2 == "BGN")
                Console.WriteLine(Math.Round(a * 1.79549, 2));
            if (valuta1 == "GBP" && valuta2 == "BGN")
                Console.WriteLine(Math.Round(a * 2.53405, 2));
            if (valuta1 == "BGN" && valuta2 == "GBP")
                Console.WriteLine(Math.Round(a / 2.53405, 2));
            if (valuta1 == "USD" && valuta2 == "EUR")
                Console.WriteLine(Math.Round(a * 1.79549 / 1.95583, 2));
            if (valuta1 == "EUR" && valuta2 == "USD")
                Console.WriteLine(Math.Round(a * 1.95583 / 1.79549, 2));
            if (valuta1 == "USD" && valuta2 == "GBP")
                Console.WriteLine(Math.Round(a * 1.79549 / 2.53405, 2));
            if (valuta1 == "GBP" && valuta2 == "USD")
                Console.WriteLine(Math.Round(a * 2.53405 / 1.79549, 2));
            if (valuta1 == "EUR" && valuta2 == "GBP")
                Console.WriteLine(Math.Round(a * 1.95583 / 2.53405, 2));
            if (valuta1 == "GBP" && valuta2 == "EUR")
                Console.WriteLine(Math.Round(a * 2.53405 / 1.95583, 2));
        }
    }
}
