using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> P = new Dictionary<string, int>();
            {
                P["2"] = 2;
                P["3"] = 3;
                P["4"] = 4;
                P["5"] = 5;
                P["6"] = 6;
                P["7"] = 7;
                P["8"] = 8;
                P["9"] = 9;
                P["10"] = 10;
                P["J"] = 11;
                P["Q"] = 12;
                P["K"] = 13;
                P["A"] = 14;
            };

            Dictionary<string, int> T = new Dictionary<string, int>();
            {
                T["S"] = 4;
                T["H"] = 3;
                T["D"] = 2;
                T["C"] = 1;
            };
            Dictionary<string, List<int>> score = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (true)
            {
                string[] hand = input.Split(':');
                if (input == "JOKER")
                {
                    break;
                }
                string name = hand[0];
                string[] cards = hand[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var card in cards)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card.Substring(card.Length - 1);
                    int sum = P[cardPower] * T[cardType];
                    if (!score.ContainsKey(name))
                        score[name] = new List<int>();
                    if (!score[name].Contains(sum))
                        score[name].Add(sum);
                }
                input = Console.ReadLine();
            }
            foreach (var player in score)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }
        }
    }
}
