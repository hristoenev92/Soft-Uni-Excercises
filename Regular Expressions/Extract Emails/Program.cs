using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\s[a-z][a-zA-Z0-9._-]+[@][a-z -]+)(\.[a-z]+)+";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}
