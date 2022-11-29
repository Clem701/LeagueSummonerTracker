using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells.Models
{
    public class Champion
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        [JsonProperty("key")]
        public long Key { get; set; }


        [JsonProperty("info")]
        public ChampInfo Info { get; set; }
    }
}
