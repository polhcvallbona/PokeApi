using PokeApiBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBack.Services
{
    internal static class PokemonServices
    {
        public static int ComparePokemonTypes(Pokemon pokemon1, Pokemon pokemon2)
        {
            foreach(Weakness w in pokemon1.weaknesses)
            {
                if (pokemon2.types.Contains(w.type)) return 1;
            }
            foreach (Weakness w in pokemon2.weaknesses)
            {
                if (pokemon1.types.Contains(w.type)) return 2;
            }
            return 0;
        }
    }
}
