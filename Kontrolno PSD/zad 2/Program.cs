using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    class Program
    {
        class Stoka
        {
            public string name {get; set;}
            public decimal price { get; set; }
            public int quantity { get; set; }
            public decimal value { get; set; }
        }
        static void Main(string[] args)
        {
            List<Stoka> list = new List<Stoka>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                if (command=="add")
                {
                    Stoka stoka = new Stoka();
                    Console.WriteLine("Vyvedete ime");
                    stoka.name = Console.ReadLine();
                    Console.WriteLine("Vyvedete cena");
                    stoka.price = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Vyvedete kolichestvo");
                    stoka.quantity = int.Parse(Console.ReadLine());
                    stoka.value = (decimal)stoka.quantity * stoka.price;
                    list.Add(stoka);
                }
                if (command=="display")
                {
                    Console.WriteLine("vyvedete stoinost za sravneneie");
                    decimal filter = decimal.Parse(Console.ReadLine());
                    foreach (var item in list)
                    {
                        if (item.value>filter)
                        {
                            Console.WriteLine($"{item.name} : {item.quantity} + {item.price:f2} = {item.value}");
                        }
                    }
                }
            }
        }
    }
}
