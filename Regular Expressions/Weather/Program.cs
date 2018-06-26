using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]{2}.[0-9]+)([a-zA-Z]+)\|";
            Dictionary<string, decimal> cityTemp = new Dictionary<string, decimal>();
            Dictionary<string, string> cityType = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    cityTemp[m.Groups[1].Value] = decimal.Parse(m.Groups[2].Value);
                    cityType[m.Groups[1].Value] = m.Groups[3].Value;
                }
                input = Console.ReadLine();
            }
            foreach (var city in cityTemp.OrderBy(x=>x.Value))
            {
                Console.WriteLine("{0} => {1:f2} => {2}",city.Key,city.Value,cityType[city.Key]);
            }
            
        }
    }
}
