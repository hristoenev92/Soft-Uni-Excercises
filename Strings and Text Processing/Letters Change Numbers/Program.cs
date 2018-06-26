using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries );
            decimal sum=0;
            foreach(var word in input)
            {
                
                char firstLetter = word.First();
                char lastLetter = word.Last();
                decimal number = decimal.Parse(word.Substring(1, word.Length - 2));
                decimal result = 0;
                if (firstLetter >= 'A' && firstLetter <= 'Z')//char.IsUpper(firstLetter)
                {
                    result = number / (firstLetter - 64);
                }
                else
                {
                    result = number * (firstLetter - 96);
                }
                if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    result = result - (lastLetter - 64);
                }
                else
                {
                    result = result + (lastLetter - 96);
                }
                sum+=result;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
