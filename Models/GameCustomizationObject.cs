using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells.Models
{
    public class GameCustomizationObjects
    {
        [JsonProperty("category")]
        public string Category { get; set; }


        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
