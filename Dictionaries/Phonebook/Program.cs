using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0]!="END")
            {
                if (command[0] == "A")
                {
                    phonebook[command[1]]=command[2];
                }
                if(command[0]=="S")
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
                    }
                    else Console.WriteLine($"Contact {command[1]} does not exist.");
                }
                if(command[0]== "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    
                }
                if (command[0] == "END") break;
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
