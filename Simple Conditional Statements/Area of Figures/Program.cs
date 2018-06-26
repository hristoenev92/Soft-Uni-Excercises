using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            switch (a)
            { 
            
                case "square":
                    Console.WriteLine(Math.Pow(double.Parse(Console.ReadLine()),2));
                    break;
                case "rectangle":
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(c*d);
                    break;
                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine(r*r*Math.PI);
                    break;
                case "triangle":
                    double e = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine(e*h/2);
                    break;

            }
        }
    }
}
