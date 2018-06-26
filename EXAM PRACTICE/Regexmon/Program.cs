using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string DidimonPattern = @"[^a-zA-Z-]+";
            string BojomonPattern = @"[a-zA-Z]+-[a-zA-Z]+";
            string input = Console.ReadLine();
            while (true)
            {
                Match didi = Regex.Match(input, DidimonPattern);
                
                if (didi.Success)
                {
                    Console.WriteLine(didi);
                    int whatToDelete = didi.Index + didi.Length;
                    input = input.Substring(whatToDelete, input.Length - whatToDelete);
                }
                else
                {
                    break;
                }
                Match bojo = Regex.Match(input, BojomonPattern);
                if (bojo.Success)
                {
                    Console.WriteLine(bojo);
                    int whatToDelete = bojo.Index + bojo.Length;
                    input = input.Substring(whatToDelete, input.Length - whatToDelete);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
