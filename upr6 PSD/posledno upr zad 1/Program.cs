using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posledno_upr_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            list.Add(1);
            list.Add(2);
            for (int i = 3; i <=n; i++)
            {
                bool fl = false;
                for (int j = 1; j < list.Count; j++)
                {
                    if (i%list[j]==0)
                    {
                        fl = true;
                        break;
                    }
                }
                if (fl == false)
                {
                list.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
