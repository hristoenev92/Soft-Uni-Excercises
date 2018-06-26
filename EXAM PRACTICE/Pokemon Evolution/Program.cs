using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        class PokemonStats
        {
            public string evolutionType { get; set; }
            public long evolutionIndex { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<PokemonStats>> dict = new Dictionary<string, List<PokemonStats>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ','-','>' },StringSplitOptions.RemoveEmptyEntries);
                string pokemonName = input[0];
                if (input[0]== "wubbalubbadubdub" )
                {
                    break;
                }
                if (input.Length<2 && dict.ContainsKey(pokemonName))
                {
                    Console.WriteLine($"# {pokemonName}");
                    foreach (var pokemon in dict[pokemonName])
                    {
                        Console.WriteLine($"{pokemon.evolutionType} <-> {pokemon.evolutionIndex}");
                    }
                }
                else
                if (input.Length==3)
                {
                    PokemonStats pokemon = new PokemonStats();
                    pokemon.evolutionType = input[1];
                    pokemon.evolutionIndex =long.Parse(input[2]);
                    if (dict.ContainsKey(pokemonName))
                    {
                        dict[pokemonName].Add(pokemon);
                    }
                    else
                    {
                        dict.Add(pokemonName, new List<PokemonStats>());
                        dict[pokemonName].Add(pokemon);
                    }
                }
            }
            foreach (var pokemon in dict)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var stat in dict[pokemon.Key].OrderByDescending(x=>x.evolutionIndex))
                {
                    Console.WriteLine($"{stat.evolutionType} <-> {stat.evolutionIndex}");
                }
            }
        }
    }
}
