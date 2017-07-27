using Dota2API.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    public class MatchDetails {
        /// <summary>
        /// List of players in the match.
        /// </summary>
        [JsonProperty(PropertyName = "players")]
        public System.Collections.Generic.List<Player> players { get; private set; }

        /// <summary>
        /// Dictates the winner of the match, true for radiant; false for dire.
        /// </summary>
        [JsonProperty(PropertyName = "radiant_win")]
        public bool radiantWin { get; private set; }

        /// <summary>
        /// The length of the match, in seconds since the match began.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public uint duration { get; private set; }

        /// <summary>
        /// The pre game duration.
        /// </summary>
        [JsonProperty(PropertyName = "pre_game_duration")]
        public uint preGameDuration { get; private set; }

        /// <summary>
        /// Unix timestamp of when the match began.
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public uint startTime { get; private set; }

        /// <summary>
        /// The matches unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "match_id")]
        public UInt64 matchID { get; private set; }

        /// <summary>
        /// A sequence number. It represents the order matches were recorded.
        /// </summary>
        [JsonProperty(PropertyName = "match_seq_num")]
        public UInt64 matchSeqNum { get; private set; }

        // A particular teams tower status is given as a 16-bit unsigned integer.
        // The rightmost 11 bits represent individual towers belonging to that team;
        // see below for a visual representation.
        // ┌─┬─┬─┬─┬─────────────────────── Not used.
        // │ │ │ │ │ ┌───────────────────── Ancient Bottom
        // │ │ │ │ │ │ ┌─────────────────── Ancient Top
        // │ │ │ │ │ │ │ ┌───────────────── Bottom Tier 3
        // │ │ │ │ │ │ │ │ ┌─────────────── Bottom Tier 2
        // │ │ │ │ │ │ │ │ │ ┌───────────── Bottom Tier 1
        // │ │ │ │ │ │ │ │ │ │ ┌─────────── Middle Tier 3
        // │ │ │ │ │ │ │ │ │ │ │ ┌───────── Middle Tier 2
        // │ │ │ │ │ │ │ │ │ │ │ │ ┌─────── Middle Tier 1
        // │ │ │ │ │ │ │ │ │ │ │ │ │ ┌───── Top Tier 3
        // │ │ │ │ │ │ │ │ │ │ │ │ │ │ ┌─── Top Tier 2
        // │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ ┌─ Top Tier 1
        // │ │ │ │ │ │ │ │ │ │ │ │ │ │ │ │
        // 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0

        [JsonProperty(PropertyName = "tower_status_radiant")]
        public UInt16 towerStatusRadiant { get; private set; }

        [JsonProperty(PropertyName = "tower_status_dire")]
        public UInt16 towerStatusDire { get; private set; }
        
        // A particular teams tower status is given as an 8-bit unsigned integer.
        // The rightmost 6 bits represent the barracks belonging to that team;
        // see below for a visual representation.
        // ┌─┬───────────── Not used.
        // │ │ ┌─────────── Bottom Ranged
        // │ │ │ ┌───────── Bottom Melee
        // │ │ │ │ ┌─────── Middle Ranged
        // │ │ │ │ │ ┌───── Middle Melee
        // │ │ │ │ │ │ ┌─── Top Ranged
        // │ │ │ │ │ │ │ ┌─ Top Melee
        // │ │ │ │ │ │ │ │
        // 0 0 0 0 0 0 0 0

        [JsonProperty(PropertyName = "barracks_status_radiant")]
        public byte barracksStatusRadiant { get; private set; }

        [JsonProperty(PropertyName = "barracks_status_dire")]
        public byte barracksStatusDire { get; private set; }

        /// <summary>
        /// The server cluster the match was played upon. Used for downloading replays of matches.
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public uint cluster { get; private set; }

        /// <summary>
        /// The time in seconds since the match began when first-blood occurred.
        /// </summary>
        [JsonProperty(PropertyName = "first_blood_time")]
        public uint firstBloodTime { get; private set; }

        [JsonProperty(PropertyName = "lobby_type")]
        public LobbyType lobbyType { get; private set; }

        /// <summary>
        /// The amount of human players within the match.
        /// </summary>
        [JsonProperty(PropertyName = "human_players")]
        public uint humanPlayers { get; private set; }

        /// <summary>
        /// The league that this match was a part of. A list of league IDs can be found via the GetLeagueListing method.
        /// </summary>
        [JsonProperty(PropertyName = "leagueid")]
        public uint leagueID { get; private set; }

        /// <summary>
        /// The number of thumbs-up the game has received by users.
        /// </summary>
        [JsonProperty(PropertyName = "positive_votes")]
        public uint positiveVotes { get; private set; }

        /// <summary>
        /// The number of thumbs-down the game has received by users.
        /// </summary>
        [JsonProperty(PropertyName = "negative_votes")]
        public uint negativeVotes { get; private set; }

        [JsonProperty(PropertyName = "game_mode")]
        public GameMode gameMode { get; private set; }

        /// <summary>
        /// A list of the picks and bans in the match, if the game mode is Captains Mode.
        /// </summary>
        public List<PickOrBan> picksAndBans { get; private set; }

        [JsonProperty(PropertyName = "flags")]
        public uint flags { get; private set; }

        [JsonProperty(PropertyName = "engine")]
        public Engine engine { get; private set; }

        [JsonProperty(PropertyName = "radiant_score")]
        public uint radiantScore { get; private set; }

        [JsonProperty(PropertyName = "dire_score")]
        public uint direScore { get; private set; }
    }
}