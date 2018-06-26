using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Key_Replacer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string patternStart = @"^[\w0-9]+[|<\\]";
            string patternEnd = @"[|<\\][a-zA-Z0-9]+$";
            string startKey = Regex.Match(inputKey, patternStart).ToString().Trim('|', '\\', '<');
            string endKey = Regex.Match(inputKey, patternEnd).ToString().Trim('|', '\\', '<');

            string pattern = $"{startKey}(.*?){endKey}";//vzima vsichko ot startKey do endKey vkluchitelno
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();
            foreach  (Match item in matches)
            {
                result.Append(item.Groups[1].Value);// group 1 e chasta mejdu startKey i endKey
            }
            if (result.ToString() == "")
            {
                Console.WriteLine("Empty result");
            }
            else Console.WriteLine(result.ToString());
        }
    }
}
