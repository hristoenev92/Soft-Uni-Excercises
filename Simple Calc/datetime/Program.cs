using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime a = DateTime.ParseExact(s,format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime b = a.AddDays(999);
            Console.WriteLine(b.ToString(format));
        }
    }
}
