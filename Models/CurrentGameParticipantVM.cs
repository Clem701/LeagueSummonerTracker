using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSpells.Models
{
    public class CurrentGameParticipantVM
    {
        public CurrentGameParticipant Participant { get; set; }

        public List<Spells> Spells { get; set; }

    }
}
