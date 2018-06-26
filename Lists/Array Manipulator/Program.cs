using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while(command[0]!="print") 
            {
                switch (command[0])
                {
                    case "add":
                        {
                            list.Insert(int.Parse(command[1]), int.Parse(command[2]));
                            break;
                        }
                    case "addMany":
                        {
                            int position = int.Parse(command[1]);
                            for (int i = 2; i < command.Length; i++)
                            {
                                int element = int.Parse(command[i]);
                                list.Insert(position++, element);
                            }
                            break;
                        }
                    case "contains":
                        {
                            Console.WriteLine(list.IndexOf(int.Parse(command[1])));
                            break;
                        }
                    case "remove":
                        {
                            int position = int.Parse(command[1]);
                            if (position<list.Count)
                            {
                                list.RemoveAt(position);
                            }
                            break;
                        }
                    case "shift":
                        {
                            int elements = int.Parse(command[1]);
                            elements = elements % list.Count;
                            List<int> temporary = list.Take(elements).ToList();
                            list.RemoveRange(0, elements);
                            list.AddRange(temporary);
                            break;
                        }
                    case "sumPairs":
                        {
                            for (int i = 0; i < list.Count-1; i++)
                            {
                                int sum = list[i] + list[i + 1];
                                list[i] = sum;
                                list.RemoveAt(i + 1);
                            }
                            break;
                        }
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine($"[{String.Join(", ",list)}]");
        }
    }
}
