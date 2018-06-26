using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ', n + 1) + '|' + new string(' ', n + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',n-i));
                Console.Write(new string('*',i));
                Console.Write(" | ");
                Console.WriteLine(new string('*', i));
              
               
            }
        }
    }
}
