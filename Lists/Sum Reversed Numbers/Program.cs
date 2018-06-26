using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int reversed = 0;
            
            for (int i = 0; i < list.Count; i++)
            {
                while(list[i]>0)
                {
                    reversed = (reversed * 10) + (list[i] % 10);
                    list[i] /= 10;
                }
                list[i] = reversed;
                reversed = 0;
            }
            Console.WriteLine(list.Sum());
        }
    }
}
