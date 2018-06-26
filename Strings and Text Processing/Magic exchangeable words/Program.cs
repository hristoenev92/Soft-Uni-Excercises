using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            bool result=true;
            Dictionary<char, char> dict = new Dictionary<char, char>();
            string shorWord;string longWord;
            if (input[0].Length<=input[1].Length)
            {
                shorWord = input[0];
                longWord = input[1];
            }
            else
            {
                shorWord = input[1];
                longWord = input[0];
            }
            for (int i = 0; i < shorWord.Length; i++)
            {
                if (!dict.ContainsKey(shorWord[i]))
                {
                    dict.Add(shorWord[i], longWord[i]);
                }
                else
                {
                    if (dict[shorWord[i]] == longWord[i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false; break;
                    }
                }
            }
            for (int i = shorWord.Length; i < longWord.Length; i++)
            {
                if (!dict.ContainsValue(longWord[i]))
                {
                    result = false; break;
                }
            }
            if (dict.Values.Distinct().Count()!=dict.Values.Count())
            {
                result = false;
            }
            if (result)
                Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
