using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outer = 0;
            int inner = n;

            for (int row = 1; row <= n; row++)
            {
                if (row != n)
                {
                    Console.Write(new string('.', outer));
                    Console.Write('*');
                    Console.Write(new string('.', inner));
                    Console.Write('*');
                    Console.Write(new string('.', inner));
                    Console.Write('*');
                    Console.Write(new string('.', outer));
                    Console.WriteLine();
                    outer++;
                    inner--;
                }
                else Console.WriteLine(new string('.',n-1)+new string('*',5)+new string('.', n - 1));
                

            }
            Console.WriteLine(new string('*',n*2+3));
            outer--;
            inner++;
            for (int row = 1; row <= n; row++)
            {
                if (row !=1 )
                {
                    Console.Write(new string('.', outer));
                    Console.Write('*');
                    Console.Write(new string('.', inner));
                    Console.Write('*');
                    Console.Write(new string('.', inner));
                    Console.Write('*');
                    Console.Write(new string('.', outer));
                    Console.WriteLine();
                    outer--;
                    inner++;
                }
                else Console.WriteLine(new string('.', n - 1) + new string('*', 5) + new string('.', n - 1));
            }
        }
    }
}
