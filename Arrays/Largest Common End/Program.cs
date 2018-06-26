using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second= Console.ReadLine().Split();
            int countleft = 0;
            int countright = 0;

            int shorter = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shorter ; i++)
            {
                if (first[i] == second[i])
                    countleft++;
                if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
                    countright++;
            }
            Console.WriteLine(Math.Max(countleft,countright));
        }
    }
}
