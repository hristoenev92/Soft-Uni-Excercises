using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izpit_zad_3
{
    class Program
    {
        class Data
        {
            public string dataKey { get; set; }
            public long dataSize { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Data> dict = new Dictionary<string, Data>();
            Dictionary<string, Data> cache = new Dictionary<string, Data>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '-', '>', ' ', '|' },StringSplitOptions.RemoveEmptyEntries);
                if (input[0]== "thetinggoesskrra")
                {
                    break;
                }
                if (input.Length>1)
                {
                    string dataSet = input[2];
                    string dataKey = input[0];
                    long dataSize = long.Parse(input[1]);
                    if (dict.ContainsKey(dataSet))
                    {
                        dict[dataSet].dataSize += dataSize;
                        dict[dataSet].dataKey+=(dataKey+" ");
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].dataKey += (dataKey + " ");
                            cache[dataSet].dataSize+= dataSize;
                        }
                        else
                        {
                            cache.Add(dataSet, new Data());
                            cache[dataSet].dataKey += (dataKey + " ");
                            cache[dataSet].dataSize += dataSize;
                        }
                    }
                }
                else
                {
                    if (cache.ContainsKey(input[0]))
                    {
                        dict.Add(input[0], new Data());
                        foreach (var data in cache)
                        {
                            dict[input[0]].dataKey+=(data.Value.dataKey.ToString()+" ");
                            dict[input[0]].dataSize += data.Value.dataSize;
                        }
                    }
                    else
                    {
                        dict.Add(input[0], new Data());
                    }
                }
            }
            string dataSetMaxValue="";
            long maxValue = 0;
            foreach (var item in dict)
            {
                if (item.Value.dataSize>=maxValue)
                {
                    maxValue = item.Value.dataSize;
                    dataSetMaxValue = item.Key;
                }
            }
            string[] splitedKeys = dict[dataSetMaxValue].dataKey.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Data Set: {dataSetMaxValue}, Total Size: {dict[dataSetMaxValue].dataSize}");
            foreach (var item in splitedKeys)
            {
                Console.WriteLine("$."+item);
            }
            
        }
    }
}
