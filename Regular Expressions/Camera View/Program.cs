using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skipTake = Console.ReadLine().Split();
            string pattern = @"\|<[^\|]+";
            string input = Console.ReadLine();
            List<string> list = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                int skip = int.Parse(skipTake[0]) + 2;
                int take = int.Parse(skipTake[1]);
                if (m.ToString().Length<skip+take)
                {
                    take = m.ToString().Length - skip;
                }
                string result = m.ToString().Substring(skip,take);
                list.Add(result);
            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
