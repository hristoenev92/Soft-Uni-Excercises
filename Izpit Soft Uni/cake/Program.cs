using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());
            int dyljina=int.Parse(Console.ReadLine());
            int parcheta = shirina * dyljina;
            int a;
            while(parcheta>=0)
            {
                string parche = Console.ReadLine().ToLower();
                if (Int32.TryParse(parche, out a)) parcheta = parcheta - a;
                else if (parche=="stop")
                {
                    Console.WriteLine(parcheta+" pieces are left." );
                    break;
                }
                if (parcheta < 0) Console.WriteLine("No more cake left! You need "+ Math.Abs(parcheta) +" pieces more.");

            }
        }
    }
}
