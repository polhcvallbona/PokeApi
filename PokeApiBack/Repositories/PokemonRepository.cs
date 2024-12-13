using Newtonsoft.Json;
using PokeApiBack.Models;
using PokeApiBack.Models.PokeApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBack.Repositories
{
    public class PokemonRepository
    {

        public class RootObject
        {
            public List<Pokemon> data { get; set; }
        }
        public static async Task<List<Pokemon>> GetAllPokemonsByName(string pokemonName)
        {
            HttpClient httpClient = new HttpClient();
            var requestResult = await httpClient.GetAsync($"https://api.pokemontcg.io/v2/cards?q=name:{pokemonName}");
            
            string jsonString = await requestResult.Content.ReadAsStringAsync();

            RootObject res = (RootObject)DeserializeObject(typeof(RootObject), jsonString);
            
            return res.data;
        }

        public static async Task<List<string>> GetAllPokemonNames()
        {
            HttpClient httpClient = new HttpClient();
            var requestResult = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?limit=1302");

            string jsonString = await requestResult.Content.ReadAsStringAsync();

            PokeApiRootObj res = (PokeApiRootObj)DeserializeObject(typeof(PokeApiRootObj), jsonString);

            return res.results.Select(x => x.name).Where(x => !x.Contains("-")).OrderBy(x => x).ToList();
        } 

        public static object DeserializeObject(Type type, string jsonString)
        {
            var res = JsonConvert.DeserializeObject(jsonString, type);
            return res;
        }

    }
}
