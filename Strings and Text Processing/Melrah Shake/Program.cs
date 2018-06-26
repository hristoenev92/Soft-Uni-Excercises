using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChars = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = randomChars.IndexOf(pattern);
                int lastIndex = randomChars.LastIndexOf(pattern);

                if (firstIndex != -1 && lastIndex != -1 && pattern != string.Empty)
                {
                    Console.WriteLine("Shaked it.");

                    StringBuilder builder = new StringBuilder();
                    builder.Append(randomChars);
                    builder.Remove(firstIndex, pattern.Length);
                    lastIndex -= pattern.Length;
                    builder.Remove(lastIndex, pattern.Length);
                    randomChars = builder.ToString();
                    int patternRemoveIndex = pattern.Length / 2;
                    builder = new StringBuilder();
                    builder.Append(pattern);
                    builder.Remove(patternRemoveIndex, 1);
                    pattern = builder.ToString();
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);
                    break;
                }
            }
        }
    }
}
