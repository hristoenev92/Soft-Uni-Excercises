using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> broadcast = new List<string>();
            List<string> messages = new List<string>();
            string[] command = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.None);
            while (command[0] != "Hornet is Green")
            {
               
                if (command[0].All(c => char.IsDigit(c)))
                {
                    char[] toList = command[0].ToCharArray();
                    Array.Reverse(toList);
                    messages.Add(new string(toList)+ " -> " + command[1]);
                }
                if (!command[0].Any(c=>char.IsDigit(c)))
                {
                    string toList = "";
                    foreach (char character in command[1])
                    {
                        if (char.IsLower(character))
                        {
                            toList += char.ToUpper(character);
                        }
                        else if (char.IsUpper(character))
                        {
                            toList += char.ToLower(character);
                        }
                        else toList += character; 
                    }
                    broadcast.Add(toList + " -> " + command[0]);
                }
                command = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.None);
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count>0)
            {
                foreach (var item in broadcast)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (broadcast.Count >0)
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
