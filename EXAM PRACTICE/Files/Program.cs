using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(';');
                int fileSize = int.Parse(input[1]);// ako e string 90/100 kogato e int edinq zero test gurmi
                string rootFolder = input[0].Split('\\').First();
                string fileExtetion = input[0].Split('\\').Last();
                if (dict.ContainsKey(rootFolder))
                {
                    if (dict[rootFolder].ContainsKey(fileExtetion))
                    {
                        dict[rootFolder][fileExtetion] = fileSize;
                    }
                    else
                    {
                        dict[rootFolder].Add(fileExtetion, fileSize);
                    }
                }
                else
                {
                    dict.Add(rootFolder,new Dictionary<string, int>());
                    dict[rootFolder].Add(fileExtetion, fileSize);
                }
               
            }
            string[] search = Console.ReadLine().Split();
            string extetionSearch = search[0].Trim();
            string rootSearch = search[2].Trim();
            bool isResult = false;
            foreach (var item in dict.Where(x => x.Key == rootSearch))
            {
                foreach (var file in item.Value.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
                {
                    string fileExtention = file.Key.Split('.').Last();
                    if (fileExtention.Equals(extetionSearch))
                    {
                        isResult = true;
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            if (isResult==false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
