using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                decimal priceCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                decimal capsules = decimal.Parse(Console.ReadLine());
                int days = System.DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = (days * capsules) * priceCapsule;
                total += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
