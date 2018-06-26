using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double qua = double.Parse(Console.ReadLine());
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine("{0:f2}",qua*2.5);
                else if(fruit == "apple") Console.WriteLine("{0:f2}", qua *1.2);
                else if (fruit == "orange") Console.WriteLine("{0:f2}", qua *0.85);
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", qua *1.45);
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", qua *2.7);
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", qua *5.5);
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", qua *3.85);
                else Console.WriteLine("error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") Console.WriteLine("{0:f2}", qua *2.7);
                else if (fruit == "apple") Console.WriteLine("{0:f2}", qua *1.25);
                else if (fruit == "orange") Console.WriteLine("{0:f2}", qua *0.9);
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", qua *1.6);
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", qua *3);
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", qua *5.6);
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", qua *4.2);
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");

        }
    }
}
