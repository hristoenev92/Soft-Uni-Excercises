using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] data = input.Split('|');
                string city = data[0];
                string country = data[1];
                int population = int.Parse(data[2]);

                if (!report.ContainsKey(country))
                {
                    report[country] = new Dictionary<string, long>();
                }

                if (!report[country].ContainsKey(city))
                {
                    report[country].Add(city, 0);
                }

                report[country][city] += population;
                input = Console.ReadLine();
            }

            var sortedCountries = report.OrderByDescending(x => x.Value.Sum(y => y.Value));

            foreach (var country in sortedCountries)
            {
                List<long> sum = country.Value.Select(x => x.Value).ToList();

                Console.WriteLine("{0} (total population: {1})", country.Key, sum.Sum());

                var citiesSorted = report[country.Key].OrderByDescending(x => x.Value);

                foreach (var city in citiesSorted)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
