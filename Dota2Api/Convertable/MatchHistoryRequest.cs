using System;
using Dota2API.Enums;

namespace Dota2API.Convertable {
    public class MatchHistoryRequest : IFormattable {
        /// <summary>
        /// The ID of the hero that must be in the matches being queried.
        /// </summary>
        public HeroID? heroID { get; set; }

        /// <summary>
        /// Which game mode to return matches for.
        /// </summary>
        public GameMode? gameMode { get; set; }

        /// <summary>
        /// The average skill range of the match, these can be [1-3] with lower numbers being lower skill. Ignored if an account ID is specified.
        /// </summary>
        public Skill? skill { get; set; }

        /// <summary>
        /// Minimum number of human players that must be in a match for it to be returned.
        /// </summary>
        public uint? minHumanPlayers { get; set; }

        /// <summary>
        /// An account ID to get matches from. This will fail if the user has their match history hidden.
        /// </summary>
        public Int64? accountID { get; set; }

        /// <summary>
        /// The league ID to return games from.
        /// </summary>
        public uint? leagueID { get; set; }

        /// <summary>
        /// The minimum match ID to start from.
        /// </summary>
        public UInt64? startAtMatchID { get; set; }

        /// <summary>
        /// The number of requested matches to return.
        /// </summary>
        public uint? matchesRequested { get; set; }

        /// <summary>
        /// Whether or not tournament games should only be returned.
        /// </summary>
        public bool? tournament_games_only { get; set; }

        /// <summary>
        /// Key used to access info.
        /// </summary>
        public string key;

        public override string ToString() {
            string returnedString = "?";
            if (heroID != null) {
                returnedString += AddParam("hero_id=", ((int)heroID).ToString());
            }
            if (gameMode != null) {
                returnedString += AddParam("game_mode=", ((int)gameMode).ToString());
            }
            if (skill != null) {
                returnedString += AddParam("skill=", ((int)skill).ToString());
            }
            if (minHumanPlayers != null) {
                returnedString += AddParam("min_players=", minHumanPlayers.ToString());
            }
            if (accountID != null) {
                returnedString += AddParam("account_id=", accountID.ToString());
            }
            if (leagueID != null) {
                returnedString += AddParam("league_id=", leagueID.ToString());
            }
            if (startAtMatchID != null) {
                returnedString += AddParam("start_at_match_id=", startAtMatchID.ToString());
            }
            if (matchesRequested != null) {
                returnedString += AddParam("matches_requested=", matchesRequested.ToString());
            }
            if (tournament_games_only != null) {
                returnedString += AddParam("tournament_games_only=", tournament_games_only.ToString());
            }
            if (key != null) {
                returnedString += "key=" + key.ToString();
            }
            else {
                throw new System.NullReferenceException("Key is not assigned");
            }
            return returnedString;
        }
        public string AddParam(string paramName, string value) {
            return paramName + value + "&";
        }
        
        public string ToString(string format, IFormatProvider formatProvider) {
            return ToString();
        }
    }
}
