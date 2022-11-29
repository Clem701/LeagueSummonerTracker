using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells.Models
{
    public class Spells
    {
        [JsonProperty("key")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cooldownBurn")]
        public long Cooldown { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }



    }
}
