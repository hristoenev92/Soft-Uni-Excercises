using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while(true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if(input[0]=="Insert")
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);
                    list.Insert(position, element);
                }
                if (input[0] == "Delete")
                {
                    int element = int.Parse(input[1]);
                    list.RemoveAll(item=>item == element);
                }
                if (input[0] == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0) Console.Write(list[i]+" ");
                    }
                    break;
                }
                if (input[0] == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0) Console.Write(list[i] + " ");
                    }
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
