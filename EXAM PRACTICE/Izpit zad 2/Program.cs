using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit_zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]=="3:1")
                {
                    break;
                }
                if (command[0]=="merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (endIndex > list.Count - 1)//moje bi trqbva da ima edna proverka start index<0 startindex=0!!!
                    {
                        endIndex = list.Count-1;
                    }
                    if (startIndex<0)//s tazi proverka raboti na 100/100
                    {                       
                        startIndex = 0;
                    }
                    if (startIndex<list.Count&&endIndex>=0)
                    {
                        StringBuilder result = new StringBuilder();
                        int lastPos=0;
                        for (int i = startIndex; i <= endIndex;i++)
                        {
                            result.Append(list[i]);
                            lastPos++;
                        }
                        list.RemoveRange(startIndex,lastPos);
                        list.Insert(startIndex, result.ToString());
                    }
                }
                if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    int sizeOfString = list[index].Length;
                    if (partitions > sizeOfString)
                    {
                        partitions = sizeOfString;//?????
                    }
                    if (sizeOfString % partitions == 0)
                    {
                        int sizeOfSubstrings = sizeOfString / partitions;
                        for (int i = 0; i < partitions; i++)
                        {
                            list.Insert(index +i+1,list[index].Substring(i*sizeOfSubstrings,sizeOfSubstrings));
                        }
                        list.RemoveAt(index);
                    }
                    else
                    {
                        int sizeOfSubstrings = sizeOfString / partitions;
                        int sizeOfLastSubstring = sizeOfString % partitions + sizeOfSubstrings;
                        for (int i = 0; i < partitions-1; i++)
                        {
                            list.Insert(index + i + 1, list[index].Substring(i * sizeOfSubstrings, sizeOfSubstrings));
                        }
                        list.Insert(index + partitions, list[index].Substring((partitions - 1) * sizeOfSubstrings, sizeOfLastSubstring));
                        list.RemoveAt(index);
                    }
                }
            }
            Console.WriteLine(string.Join<string>(" ",list));
        }
    }
}
