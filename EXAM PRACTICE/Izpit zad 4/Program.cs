using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Izpit_zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new char[] { ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"([a-zA-Z]+)[^a-zA-Z](.*?)[^a-zA-Z]([a-zA-Z]+)";
            StringBuilder result = new StringBuilder();
            int i = 0;
            foreach  (Match match in Regex.Matches(input,pattern))
            {
                if (match.Groups[1].Value==match.Groups[3].Value)
                {
                    result.Append($"{match.Groups[1].Value} {values[i++]} {match.Groups[3].Value}");
                } 
            }
            Console.WriteLine(result.ToString());


        }
    }
}
