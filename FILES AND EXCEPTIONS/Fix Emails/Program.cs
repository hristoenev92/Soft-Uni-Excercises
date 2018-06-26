using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../../input.txt");
            int index = 0;
            string name = " ";
            string email;
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                name = input[index++];
                if (name == "stop")
                {
                    break;
                }
                email = input[index++];
                if (email.EndsWith("us") || email.EndsWith("uk"))
                {

                }
                else dict[name] = email;

            }
            List<string> output = new List<string>();
            foreach (var item in dict)
            {
                output.Add($"{item.Key} -> {item.Value}");
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
