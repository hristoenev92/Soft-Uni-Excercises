using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posledno_upr_zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                list.Add(r.Next(0, 6));
            }
            Console.WriteLine(String.Join(" ", list));
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]==list[i-1])
                {
                    list.RemoveAt(i);
                    i = i - 1;
                }
            }
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(list.Count);
        }
    }
}
