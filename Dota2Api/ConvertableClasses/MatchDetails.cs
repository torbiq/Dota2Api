using System;
using System.Collections.Generic;
using System.Text;
using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses
{
    public class MatchDetails
    {
        /// <summary>
        /// List of players in the match.
        /// </summary>
        public List<Player> players { get; private set; }
        /// <summary>
        /// The season the game was played in.
        /// </summary>
        public int season { get; private set; }
        /// <summary>
        /// Dictates the winner of the match, true for radiant; false for dire.
        /// </summary>
        public bool radiantWin { get; private set; }
        /// <summary>
        /// The length of the match, in seconds since the match began.
        /// </summary>
        public int duration { get; private set; }
        /// <summary>
        /// Unix timestamp of when the match began.
        /// </summary>
        public int startTime { get; private set; }
        /// <summary>
        /// The matches unique ID.
        /// </summary>
        public int matchID { get; private set; }
        /// <summary>
        /// A 'sequence number', representing the order in which matches were recorded.
        /// </summary>
        public int matchSeqNum { get; private set; }
        /// <summary>
        /// Radiant team tower status (destroyed or not).
        /// </summary>
        public TowerStatus towerStatusRadiant { get; private set; }
        /// <summary>
        /// Dire team tower status (destroyed or not).
        /// </summary>
        public TowerStatus towerStatusDire { get; private set; }
        /// <summary>
        /// Radiant team barracks status (destroyed or not).
        /// </summary>
        public BarracksStatus barracksStatusRadiant { get; private set; }
        /// <summary>
        /// Dire team barracks status (destroyed or not).
        /// </summary>
        public BarracksStatus barracksStatusDire { get; private set; }
        /// <summary>
        /// The server cluster the match was played upon. Used for downloading replays of matches.
        /// </summary>
        public int cluster { get; private set; }
        /// <summary>
        /// The time in seconds since the match began when first-blood occurred.
        /// </summary>
        public int firstBloodTime { get; private set; }
        /// <summary>
        /// Lobby type.
        /// </summary>
        public LobbyType lobbyType { get; private set; }
        /// <summary>
        /// The amount of human players within the match.
        /// </summary>
        public int humanPlayers { get; private set; }
        /// <summary>
        /// The league that this match was a part of. A list of league IDs can be found via the GetLeagueListing method.
        /// </summary>
        public int leagueID { get; private set; }
        /// <summary>
        /// The number of thumbs-up the game has received by users.
        /// </summary>
        public int positiveVotes { get; private set; }
        /// <summary>
        /// The number of thumbs-down the game has received by users.
        /// </summary>
        public int negativeVotes { get; private set; }
        /// <summary>
        /// Game mode.
        /// </summary>
        public GameMode gameMode { get; private set; }
        /// <summary>
        /// A list of the picks and bans in the match, if the game mode is Captains Mode.
        /// </summary>
        public List<PickOrBan> picksBans { get; private set; }
        /// <summary>
        /// ???
        /// </summary>
        public object flags { get; private set; }
        /// <summary>
        /// Engine version used for game (0 - for old Source 1, 1 - for Source 2)
        /// </summary>
        public Engine engine { get; private set; }
        /// <summary>
        /// Radint team score.
        /// </summary>
        public int radiantScore { get; private set; }
        /// <summary>
        /// Dire team score.
        /// </summary>
        public int direScore { get; private set; }
    }
}
