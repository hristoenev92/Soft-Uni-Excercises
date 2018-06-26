using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([0-9]+) = ([^\-\=\>\:\s]+) -> ([^\-\=\>\:\s]+):([0-9]+)";
            Dictionary<string, long> legionActivities = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionSoldiersCount = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                string legionName = match.Groups[2].Value;
                int activity = int.Parse(match.Groups[1].Value);
                string soldierType = match.Groups[3].Value;
                int soldierCount = int.Parse(match.Groups[4].Value);

                if (!legionActivities.ContainsKey(legionName))
                {
                    legionActivities.Add(legionName, activity);
                    legionSoldiersCount.Add(legionName, new Dictionary<string, long>());
                    legionSoldiersCount[legionName].Add(soldierType, soldierCount);
                }
                else
                {
                    if (legionActivities[legionName]<activity)
                    {
                        legionActivities[legionName] = activity;
                    }
                    if (legionSoldiersCount[legionName].ContainsKey(soldierType))
                    {
                        legionSoldiersCount[legionName][soldierType] += soldierCount;
                    }
                    else
                    {
                        legionSoldiersCount[legionName].Add(soldierType, soldierCount);
                    }
                }
            }
            string[] output = Console.ReadLine().Split('\\');
            long activitySearch;
            if (long.TryParse(output[0],out activitySearch))
            {
                foreach (var legion in legionSoldiersCount.Where(s => s.Value.ContainsKey(output[1])).OrderByDescending(b => b.Value[output[1]]))
                {
                    
                    if (legionActivities[legion.Key] < activitySearch)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[output[1]]}");
                    }
                }
            }
            else
            {
                foreach (var legion in legionActivities.OrderByDescending(x => x.Value))
                {
                    if (legionSoldiersCount[legion.Key].ContainsKey(output[0]))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    } 
                }
            }
        }
    }
}
