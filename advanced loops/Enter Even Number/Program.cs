using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=3;
            while (n%2!=0)
            {
                Console.Write("Еnter even number: ");
                n = int.Parse(Console.ReadLine());
                if (n%2!=0) Console.WriteLine("Invalid number!");
                else Console.WriteLine("Even number entered: " + n);
            }
        }
    }
}
