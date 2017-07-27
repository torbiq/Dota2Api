using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class MatchHistoryResult {
        [JsonProperty(PropertyName = "players")]
        public System.Collections.Generic.List<MatchHistoryPlayer> players { get; private set; }

        [JsonProperty(PropertyName = "radiant_win")]
        public bool radiantWin { get; private set; }

        [JsonProperty(PropertyName = "duration")]
        public int duration { get; private set; }

        [JsonProperty(PropertyName = "pre_game_duration")]
        public int preGameDuration { get; private set; }

        [JsonProperty(PropertyName = "start_time")]
        public int startTime { get; private set; }

        [JsonProperty(PropertyName = "match_id")]
        public long matchID { get; private set; }

        [JsonProperty(PropertyName = "match_seq_num")]
        public long matchSeqNum { get; private set; }

        [JsonProperty(PropertyName = "tower_status_radiant")]
        public int towerStatusRadiant { get; private set; }

        [JsonProperty(PropertyName = "tower_status_dire")]
        public int towerStatusDire { get; private set; }

        [JsonProperty(PropertyName = "barracks_status_radiant")]
        public int barracksStatusradiant { get; private set; }

        [JsonProperty(PropertyName = "barracks_status_dire")]
        public int barracksStatusDire { get; private set; }

        [JsonProperty(PropertyName = "cluster")]
        public int cluster { get; private set; }

        [JsonProperty(PropertyName = "first_blood_time")]
        public int firstBloodTime { get; private set; }

        [JsonProperty(PropertyName = "lobby_type")]
        public LobbyType lobbyType { get; private set; }

        [JsonProperty(PropertyName = "human_players")]
        public int humanPlayers { get; private set; }

        [JsonProperty(PropertyName = "leagueid")]
        public int leagueID { get; private set; }

        [JsonProperty(PropertyName = "positive_votes")]
        public int positiveVotes { get; private set; }

        [JsonProperty(PropertyName = "negative_votes")]
        public int negativeVotes { get; private set; }

        [JsonProperty(PropertyName = "game_mode")]
        public GameMode gameMode { get; private set; }

        [JsonProperty(PropertyName = "flags")]
        public int flags { get; private set; }

        [JsonProperty(PropertyName = "engine")]
        public Engine engine { get; private set; }

        [JsonProperty(PropertyName = "radiant_score")]
        public int radiantScore { get; private set; }

        [JsonProperty(PropertyName = "dire_score")]
        public int direScore { get; private set; }
    }
}