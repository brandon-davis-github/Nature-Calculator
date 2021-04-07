using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Nature_Calculator
{
    class NaturesUtility
    {
        // reads the .csv file to build it into a dictionary return type
        public static Dictionary<string, PokemonStats> LoadPokemon()
        {
            var pokedex = new Dictionary<string, PokemonStats>();

            const string POKEDEXFILENAME = "pokedex.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using (var reader = new StreamReader(POKEDEXFILENAME))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<PokemonStats>();
                foreach (var record in records)
                {
                    pokedex[record._name] = record;
                }
            }
            return pokedex;
        }
    }
}













//public static void ReadFile()
//{
//    List<string> list = new List<string>();
//    using (StreamReader reader = new StreamReader("pokedex.txt"))
//    {
//        string line;
//        while ((line = reader.ReadLine()) != null)
//        {
//            list.Add(line);
//            Console.WriteLine(line);
//        }
//    }










//public static Dictionary<string, PokemonStats> LoadPokemon()
//{
//    var pokedex = new Dictionary<string, PokemonStats>();

//    const string POKEDEXFILENAME = "pokedex.csv";

//    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
//    {
//        HasHeaderRecord = false,
//    };
//    using (var reader = new StreamReader(POKEDEXFILENAME))
//    using (var csv = new CsvReader(reader, config))
//    {
//        var records = csv.GetRecords<PokemonStats>();
//    }
//    foreach (var pokemon in PokemonStats)
//    {
//        pokedex[pokemon[0]] = PokemonStats{_hp = pokemon[1], _attack = pokemon[2], _defense = pokemon[3], _specialAttack = pokemon[4], _specialDefense = pokemon[5], _speed = pokemon[6]};
//    }