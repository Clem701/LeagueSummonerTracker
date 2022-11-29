using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SummonerSpells.Models;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SummonerSpells
{
    public class ApiHandler
    {

        private string ApiKey = "";

        private HttpClient client = new HttpClient();

        public SummonerDTO BaseSummoner { get; set; }

        public CurrentGameInfo CurrentGameInfo { get; set; }

        public CurrentGameParticipant CurrentGameParticipant { get; set; }

        public List<Spells> Spells { get; set; } = new List<Spells>();

        public List<Champion> Champions { get; set; } = new List<Champion>();

        public ApiHandler(string regionBaseUrl)
        {
            client.BaseAddress = new Uri(regionBaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Riot-Token", this.ApiKey);

        }

        public async Task<SummonerDTO> GetSummoner(string name)
        {
            string subUrl = "lol/summoner/v4/summoners/by-name/" + name;
            HttpResponseMessage response = await client.GetAsync(subUrl);
            var json = await response.Content.ReadAsStringAsync();
            this.BaseSummoner = JsonConvert.DeserializeObject<SummonerDTO>(json);
            return this.BaseSummoner;

        }

        public async Task<CurrentGameInfo> GetGameInfo()
        {
            string subUrl = "lol/spectator/v4/active-games/by-summoner/" + this.BaseSummoner.Id;
            HttpResponseMessage response = await client.GetAsync(subUrl);
            var json = await response.Content.ReadAsStringAsync();
            this.CurrentGameInfo = JsonConvert.DeserializeObject<CurrentGameInfo>(json);
            return this.CurrentGameInfo;
        }

        public async Task<List<Champion>> GetEnemyChampsById(List<long> participantIds)
        {
            string Url = "http://ddragon.leagueoflegends.com/cdn/12.20.1/data/en_US/champion.json";
            HttpResponseMessage response = await client.GetAsync(Url);
            var json = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(json);
            foreach (var item in data["data"])
            {
                if (participantIds.Contains((long)item.First["key"]))
                {
                    var champion = JsonConvert.DeserializeObject<Champion>(item.First.ToString());
                    Champions.Add(champion);
                }
            }
            return this.Champions;
        }

        public async Task<List<Spells>> GetSpells(List<long> spellIds)
        {
            string Url = "http://ddragon.leagueoflegends.com/cdn/12.20.1/data/en_US/summoner.json";
            HttpResponseMessage response = await client.GetAsync(Url);
            var json = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(json);
            foreach (var item in data["data"])
            {
                if (spellIds.Contains((long)item.First["key"]))
                {
                    var spell = JsonConvert.DeserializeObject<Spells>(item.First.ToString());
                    Spells.Add(spell);
                }
            }
            return this.Spells;
        }

    }

}

/// /lol/summoner/v4/summoners/by-name/{summonerName}
