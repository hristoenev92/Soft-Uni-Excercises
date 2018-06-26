using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            string input = File.ReadAllText("../../input.txt");
            List<string> output = new List<string>();
            foreach (char character in input)
            {
                output.Add($"{character} -> {character - 'a'}");
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
