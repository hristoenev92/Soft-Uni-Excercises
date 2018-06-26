using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../input.txt");
            int index = 0;
            string resource = " ";
            int quantity;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (true)
            {
                resource = input[index++];
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(input[index++]);
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else dict[resource] = quantity;

            }
            List<string> output = new List<string>();
            foreach (var item in dict)
            {
                output.Add($"{item.Key} -> {item.Value}");
            }
            File.WriteAllLines("../../Output.txt", output);
        }
    }
}
