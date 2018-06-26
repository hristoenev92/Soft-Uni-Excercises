using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string[] holidays = new string[]
            {"1-1","3-3","1-5","6-5","24-5","6-9","22-9","1-11","24-12","25-12","26-12"};
            int daycounter = 0;
            for (DateTime i = startDate;  i<=endDate; i=i.AddDays(1))
            {
                string dateFormatted = $"{i.Day}-{i.Month}";
                if (i.DayOfWeek!=DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday &&!holidays.Contains(dateFormatted))
                {
                    daycounter++;
                }
            }
            Console.WriteLine(daycounter);
        }
    }
}
