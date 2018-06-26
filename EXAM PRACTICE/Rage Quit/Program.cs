using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^0-9]+)(\d+)";
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                string word = m.Groups[1].ToString().ToUpper();
                int num = int.Parse(m.Groups[2].ToString());
                for (int i = 0; i < num; i++)
                {
                    result.Append(word);
                }
            }
            int unique = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {unique}");
            Console.WriteLine(result.ToString());
        }
    }
}
