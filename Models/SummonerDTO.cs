using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells.Models
{
    public class SummonerDTO
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("accountId")]
        public string accountId { get; set; }

        [JsonProperty("puuid")]
        public string puuid { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("profileIconId")]
        public int profileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public string revisionDate { get; set; }

        [JsonProperty("SummonerLevel")]
        public int SummonerLevel { get; set; }


    }
}
