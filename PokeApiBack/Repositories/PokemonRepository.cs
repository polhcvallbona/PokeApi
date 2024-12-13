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
        public static async Task<RootObject> GetAllPokemonsByName(string pokemonName)
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetAsync($"https://api.pokemontcg.io/v2/cards?q=name:{pokemonName}");
            
            string jsonString = await res.Content.ReadAsStringAsync();

            JsonSerializer jsonSerializer = new JsonSerializer();

            using (var stringReader = new StringReader(jsonString))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                // Deserializar al objeto Pokemon
                JsonSerializer serializer = new JsonSerializer();
                RootObject ss = serializer.Deserialize<RootObject>(jsonReader);

                // Mostrar resultados
                return ss;
            }
        }

        public static async Task<List<string>> GetAllPokemonNames()
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?limit=1302");

            string jsonString = await res.Content.ReadAsStringAsync();

            JsonSerializer jsonSerializer = new JsonSerializer();

            using (var stringReader = new StringReader(jsonString))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                JsonSerializer serializer = new JsonSerializer();
                PokeApiRootObj ss = serializer.Deserialize<PokeApiRootObj>(jsonReader);

                return ss.results.Where(x => !x.name.Contains("-")).Select(x => x.name).ToList();
            }
        } 

        //public static async Task<object>

    }
}
