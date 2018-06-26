using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_exchangeable_words_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string firstWord = input[0];
            string secondWord = input[1];
            char[] fisrt = firstWord.Distinct().ToArray();
            char[] second = secondWord.Distinct().ToArray();
            if (fisrt.Length==second.Length)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
