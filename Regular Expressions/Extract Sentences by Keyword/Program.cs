using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '!','.','?'},StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";

            foreach (var item in text)
            {
                if (Regex.IsMatch(item,pattern))
                {
                Console.WriteLine(item.Trim());
                }
            }
        }
    }
}
