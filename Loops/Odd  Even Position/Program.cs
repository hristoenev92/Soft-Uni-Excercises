using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumo = 0;
            double sume = 0;
            double maxo = 0;
            double maxe = 0;
            double mino = 0;
            double mine = 0;
            string no = "No";

            for (int i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    sume = sume + a;
                    if (i == 2) { maxe = a; mine = a; }
                    if (a > maxe) maxe = a;
                    if (a < mine) mine = a;
                }
                else
                {
                    sumo = sumo + a;
                    if (i == 1) { maxo = a; mino = a; }
                    if (a > maxo) maxo = a;
                    if (a < mino) mino = a;
                }
            }
            
            Console.WriteLine("OddSum " + sumo + ",");
            if (mino == 0) Console.WriteLine("OddMin " + no + ",");
            else Console.WriteLine("OddMin " + mino + ",");
            if (maxo == 0) Console.WriteLine("OddMax " + no + ",");
            else Console.WriteLine("OddMax " + maxo + ",");
            Console.WriteLine("EvenSum " + sume + ",");
            if (mine == 0) Console.WriteLine("EvenMin " + no + ",");
            else Console.WriteLine("EvenMin " + mine + ",");
            if (maxe == 0) Console.WriteLine("EvenMax " + no + ",");
            else Console.WriteLine("EvenMax " + maxe + ",");


        }
    }
}
