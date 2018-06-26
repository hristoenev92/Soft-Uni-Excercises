using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rombus_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = n;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ',s-1));
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("* ");
                    

                }
                s--;
                Console.WriteLine();
            }
            for (int i = 1; i <=n-1 ;i++)
            {
                Console.Write(new string(' ', i));
                for (int y=n-1; y >=i; y--)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
