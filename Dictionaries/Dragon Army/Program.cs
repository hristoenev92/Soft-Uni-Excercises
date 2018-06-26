using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, double[]>>();
            int dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string dragonColor = data[0];
                string dragonType = data[1];
                double dragonDMG = 0;
                double dragonHP = 0;
                double dragonArmor = 0;

                //Default values if no input
                dragonDMG = data[2] != "null" ? double.Parse(data[2]) : 45;
                dragonHP = data[3] != "null" ? double.Parse(data[3]) : 250;
                dragonArmor = data[4] != "null" ? double.Parse(data[4]) : 10;

                if (!dragons.ContainsKey(dragonColor))
                {
                    dragons[dragonColor] = new SortedDictionary<string, double[]>();
                }

                if (!dragons[dragonColor].ContainsKey(dragonType))
                {
                    dragons[dragonColor][dragonType] = new[] { 0d, 0d, 0d };
                }

                dragons[dragonColor][dragonType] = new[] { dragonDMG, dragonHP, dragonArmor };
            }
            foreach (var type in dragons)
            {
                double avrgDMG = type.Value.Values.Average(average => average[0]);
                double avrgHP = type.Value.Values.Average(average => average[1]);
                double avrgArmor = type.Value.Values.Average(average => average[2]);

                Console.WriteLine($"{type.Key}::({avrgDMG:f2}/{avrgHP:f2}/{avrgArmor:f2})");

                foreach (var dragon in dragons[type.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> " +
                                  $"damage: {dragon.Value[0]:f0}, " +
                                  $"health: {dragon.Value[1]:f0}, " +
                                  $"armor: {dragon.Value[2]:f0}");
                }
            }
        }
    }
}
