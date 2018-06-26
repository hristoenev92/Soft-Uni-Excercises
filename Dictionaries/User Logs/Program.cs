using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> log = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] splitArgs = input.Split('=', ' ');

                string currentIp = splitArgs[1];
                string currentUser = splitArgs[5];

                if (!log.ContainsKey(currentUser))
                    log[currentUser] = new Dictionary<string, int>();
                if (!log[currentUser].ContainsKey(currentIp))
                    log[currentUser].Add(currentIp,0);
                log[currentUser][currentIp]++;
                input = Console.ReadLine();
            }
            foreach (var user in log)
            {
                List<string> output = new List<string>();
                Console.WriteLine($"{user.Key}: ");
                foreach (var ip in log[user.Key])
                {
                    output.Add($"{ip.Key} => {ip.Value}");
                }
                Console.WriteLine($"{String.Join(", ",output)}.");
            }
        }
    }
}
