using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posledno_upr_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                list.Add(r.Next(0,7));
            }
            list.RemoveAll(x=>x==0);
            Console.WriteLine(String.Join(" ",list));
            Console.WriteLine(list.Count);
        }
    }
}
