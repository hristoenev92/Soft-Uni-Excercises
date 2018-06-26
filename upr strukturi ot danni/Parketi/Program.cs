using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parketi
{
    class parket
    {
        public string tip { get; set; }
        public string name { get; set; }
        public decimal cena { get; set; }
    }
    class Program
    {
        static parket Input(string[] input)
        {
            parket newParket = new parket();
            newParket.tip = input[0];
            newParket.name = input[1];
            newParket.cena = decimal.Parse(input[2]);
            return newParket;
        }
        static void Main(string[] args)
        {
            List<parket> list = new List<parket>();
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="end")
                {
                    break;
                }
                if (command[0]=="add")
                {
                    list.Add(Input(command));
                }
                if (command[0]=="edit")
                {
                    //parket toEdit = new parket();
                    //toEdit.name = command[1];
                    //int a = list.IndexOf(toEdit);//preraboti!!!!
                    //foreach (var item in list)
                    //{ 
                    //    if (item.name == command[1])
                    //    {
                    //        a = list.IndexOf(item);
                    //        list.RemoveAt(a);
                    //        break;
                    //    }
                    //}
                    //toEdit.tip = Console.ReadLine();
                    //toEdit.name = Console.ReadLine();
                    //toEdit.cena=
                }
            }
            Console.Write("vyvedete cena za sravnenie:");
            decimal cenaSravnenie = decimal.Parse(Console.ReadLine());
            foreach (var item in list)
            {
                if (cenaSravnenie>item.cena)
                {
                    Console.WriteLine($"{item.tip} , {item.name} - {item.cena}");
                }
            }
            
        }
    }
}
