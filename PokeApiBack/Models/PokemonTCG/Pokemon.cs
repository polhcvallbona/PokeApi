using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApiBack.Models
{
    public class Pokemon
    {
        public string id { get; set; }
        public string name { get; set; }
        public string supertype { get; set; }
        public List<string> subtypes { get; set; }
        public string hp { get; set; }
        public List<string> types {  get; set; }
        public string evolvesFrom { get; set; }
        public List<Weakness> weaknesses { get; set; }
        public Set set { get; set; }
        public string rarity { get; set; }
        public Images images { get; set; }
        //public List<TcgPlayer> tcgPlayer { get; set; }

        public override string ToString()
        {
            return name + set.series;
        }

    }
}
