using Newtonsoft.Json;
using System;

namespace Dota2API.Convertable {
    /// <summary>
    /// League info.
    /// </summary>
    public class League {
        /// <summary>
        /// The name of the league.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string name { get; private set; }

        /// <summary>
        /// The league's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "leagueid")]
        public int leagueID { get; private set; }

        /// <summary>
        /// A description of the league.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string description { get; private set; }

        /// <summary>
        /// The league's website.
        /// </summary>
        [JsonProperty(PropertyName = "tournament_url")]
        public string tournamentURL { get; private set; }

        /// <summary>
        /// The league's website.
        /// </summary>
        public Uri GetTournamentURI() {
            return new Uri(tournamentURL);
        }
    }
}
