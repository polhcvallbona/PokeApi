using Newtonsoft.Json;
using PokeApiBack.Models;
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
        public static async Task<RootObject> /*List<Pokemon>*/ GetAllPokemonsByName(string pokemonName)
        {
            HttpClient httpClient = new HttpClient();
            var res = await httpClient.GetAsync("https://api.pokemontcg.io/v2/cards?q=name:gardevoir");
            
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

    }
}
