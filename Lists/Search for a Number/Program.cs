using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool a = true;

            for (int i = command[0]+1; i < list.Count; i++)
            {
                list.RemoveAt(i);
            }
            list.RemoveRange(0, command[1]);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == command[2]) {a = false; break; }
            }
            if (a == false)  Console.WriteLine("YES!"); 
                else Console.WriteLine("NO!");
        }
    }
}
