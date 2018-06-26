using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double result = 0;
            switch (a)
            {
                case "premiere":
                    {
                        result = r * c * 12;
                        break;
                    }
                case "normal":
                    {
                        result = r * c * 7.5;
                        break;
                    }
                case "discount":
                    {
                        result = r * c * 5;
                        break;
                    }
                   
            }
            Console.Write("{0:f2}",result);
            Console.WriteLine(" leva");
         
        }
    }
}
