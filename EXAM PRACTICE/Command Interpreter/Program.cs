using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = 
                Console.ReadLine()
                .Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "end")
                {
                    break;
                }
                switch (command[0])
                {
                    case "reverse":
                        {
                            int start = int.Parse(command[2]);
                            int count = int.Parse(command[4]);
                            if (start + count <= list.Count && start >= 0 && count >= 0&&start< list.Count)
                            {
                                for (int i = 0; i < count/2; i++)
                                {
                                    string temp = list[start+i];
                                    list[start + i] = list[count + start - i - 1];
                                    list[count + start - 1 - i] = temp;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }
                    case "sort":
                        {
                            int start = int.Parse(command[2]);
                            int count = int.Parse(command[4]);
                            if (start + count <= list.Count && start >= 0 && count >= 0 && start < list.Count)
                            {
                                List<string> smallList = list.Skip(start).Take(count).OrderBy(x => x).ToList();
                                list.RemoveRange(start, count);
                                list.InsertRange(start, smallList);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }
                    case "rollLeft":
                        {
                            int count = int.Parse(command[1]);
                            if (count >= 0)
                            {
                                int a = count % list.Count;
                                for (int i = 0; i < a; i++)
                                {
                                    string temp = list.First();
                                    list.RemoveAt(0);
                                    list.Add(temp);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }
                    case "rollRight":
                        {
                            int count = int.Parse(command[1]);
                            if (count >= 0)
                            {
                                int a = count % list.Count;
                                for (int i = 0; i < a; i++)
                                {
                                    string temp = list.Last();
                                    list.RemoveAt(list.Count - 1);
                                    list.Insert(0, temp);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                            break;
                        }
                }
            }
            Console.WriteLine($"[{string.Join(", ",list)}]");
        }
    }
}
