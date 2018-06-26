using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a.ToLower() == b.ToLower()) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
