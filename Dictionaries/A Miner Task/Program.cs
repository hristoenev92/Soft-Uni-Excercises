using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource =" ";
            int quantity;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while(true)
            {
                resource = Console.ReadLine();
                if (resource=="stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else dict[resource] = quantity;
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
