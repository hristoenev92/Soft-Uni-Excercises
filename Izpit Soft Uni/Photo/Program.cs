using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo
{
    class Program
    {
        static void Main(string[] args)
        {
            int snimki = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            string order = Console.ReadLine().ToLower();
            double disc = 1, cena = 0;
            
            if (type == "9x13")
            {
                cena = snimki * 0.16;
                if (snimki >= 50)
                    disc = disc + 0.05;
            }
            if (type== "10x15")
            {
                cena = snimki * 0.16;
                if (snimki >= 80)
                    disc = disc + 0.03;
            }
            if (type== "13x18")
            {
                cena = snimki * 0.38;
                if (snimki > 100)
                    disc = disc + 0.05;
                else if ((snimki >= 50) && (snimki <= 100))
                    disc = disc + 0.03;
            }
            if(type== "20x30")
            {
                cena = snimki * 2.90;
                if (snimki > 50)
                    disc = disc + 0.09;
                else if (snimki >= 10 && snimki <= 50)
                    disc = disc + 0.07;
            }
            double cenaotstypka = cena - (cena * (disc - 1));
            if (order == "online") 
            Console.WriteLine($"{cenaotstypka-(cenaotstypka*0.02):f2}BGN");
            else Console.WriteLine($"{cenaotstypka:f2}BGN");
                   
               





        }


    }
   
}
