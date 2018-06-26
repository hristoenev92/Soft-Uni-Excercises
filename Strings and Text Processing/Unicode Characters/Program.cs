using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char letter in input)
            {
                sb.Append("\\u");
                sb.Append(((int)letter).ToString("x4"));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
