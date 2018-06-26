using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_karti
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n-1; i <= 51; i++)
            {
                int m = i / 4+2;
                if(m<11)
                {
                    Console.Write(m);
                }
                else
                {
                   switch (m)
                    {
                        case 11:
                            {
                                Console.Write("vale");
                                break;
                            }
                        case 12:
                            {
                                Console.Write("dama");
                                break;
                            }
                        case 13:
                            {
                                Console.Write("pop");
                                break;
                            }
                        case 14:
                            {
                                Console.Write("aso");
                                break;
                            }
                    }
                }
                if (i % 4+1==1)
                {
                    Console.Write(" spatiq");
                }
                if (i%4 + 1 == 2)
                {
                    Console.Write(" karo");
                }
                if (i%4 + 1 == 3)
                {
                    Console.Write(" kupa");
                }
                if (i % 4 + 1 == 4)
                {
                    Console.Write(" pika");
                }
                Console.WriteLine();
            }
        }
    }
}
