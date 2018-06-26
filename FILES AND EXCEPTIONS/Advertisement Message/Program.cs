using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = File.ReadAllText("../../phrases.txt").Split(',');

            string[] events = File.ReadAllText("../../events.txt").Split(',');

            string[] authors = File.ReadAllText("../../authors.txt").Split(',');

            string[] cities = File.ReadAllText("../../cities.txt").Split(',');

            Random phraseindex = new Random();
            Random eventindex = new Random();
            Random authorindex = new Random();
            Random citiesindex = new Random();

            int times = int.Parse(File.ReadAllText("../../times.txt"));
            List<string> output = new List<string>();
            for (int i = 0; i < times; i++)
            {
               string message=(
                    $"{phrases[phraseindex.Next(0, phrases.Length)]} "+
                    $"{events[eventindex.Next(0, events.Length)]} "+
                    $"{authors[authorindex.Next(0, authors.Length)]} - "+
                    $"{cities[citiesindex.Next(0, cities.Length)]}");
                output.Add(message);
            }
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
