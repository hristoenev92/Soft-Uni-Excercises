using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",a,b,c,d);
        }
    }
}
