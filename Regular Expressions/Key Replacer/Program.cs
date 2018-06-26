using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string patternStart= @"^[\w0-9]+[|<\\]";
            string patternEnd= @"[|<\\][a-zA-Z0-9]+$";
            string startKey=Regex.Match(inputKey,patternStart).ToString().Trim('|', '\\', '<');
            string endKey= Regex.Match(inputKey, patternEnd).ToString().Trim('|', '\\', '<');
            
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <input.Length ; i++)
            {
                int startsubstring = startKey.Length + input.IndexOf(startKey);
                if (input.Contains(startKey) && input.Contains(endKey))
                {
                    
                    foreach (char item in input.Substring(startsubstring, input.IndexOf(endKey) - startsubstring))
                    {
                        result.Append(item);
                    }
                    input = input.Remove(input.IndexOf(startKey), startKey.Length);//tvurde slojno vij Key Replacer 2
                    input = input.Remove(input.IndexOf(endKey), endKey.Length);
                }
            }
            if (result.ToString() == "")
            {
                Console.WriteLine("Empty result");
            }
            else Console.WriteLine(result.ToString());
        }
    }
}
