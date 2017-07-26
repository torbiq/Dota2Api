using System;

namespace Dota2Api.ConvertableClasses
{
    public class League
    {
        public string name { get; private set; }
        public int leagueID { get; private set; }
        public string description { get; private set; }
        public Uri tournamentURL { get; private set; }
        public League(string name, int leagueID, string description, Uri tournamentURL) {
            this.name = name;
            this.leagueID = leagueID;
            this.description = description;
            this.tournamentURL = tournamentURL;
        }
    }
}
