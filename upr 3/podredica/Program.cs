using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podredica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool result = false;
            for (int i = 0; i < a.Length-2; i++)
            {
                if (a[i] == b[0] && a[i + 1] == b[1] && a[i + 2] == b[2])
                    result = true;
            }
            Console.WriteLine(result);
        }
    }
}
