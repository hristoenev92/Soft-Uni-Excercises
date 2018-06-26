using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> m = new List<int>();
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                m.Add(n % 10);
                n = n / 10;
            }
            int br = 0;
            List<int> p = m;
            for (int i = 0; i < m.Count; i++)
            {
                p.RemoveAt(i);
                if (p.Contains(m[i]))
                {
                    br++;
                    break;
                }

            }
            if (br>0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
