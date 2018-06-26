using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] 
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random phraseindex = new Random();
            Random eventindex = new Random();
            Random authorindex = new Random();
            Random citiesindex = new Random();

            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"{phrases[phraseindex.Next(0, phrases.Length)]} {events[eventindex.Next(0, events.Length)]} {authors[authorindex.Next(0, authors.Length)]} - {cities[citiesindex.Next(0, cities.Length)]}");
            }
        }
    }
}
