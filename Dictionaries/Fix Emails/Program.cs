using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            string email;
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                name = Console.ReadLine();
                if (name=="stop")
                {
                    break;
                }
                email= Console.ReadLine();
                if (email.EndsWith("us")||email.EndsWith("uk"))
                {

                }
                else dict[name] = email;
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}
