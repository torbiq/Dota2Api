using System;
using System.Collections.Generic;
using System.Text;
using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses
{
    /// <summary>
    /// Represents structure for pick or ban.
    /// </summary>
    public class PickOrBan
    {
        /// <summary>
        /// Whether this entry is a pick (true) or a ban (false).
        /// </summary>
        public PickStatus pickStatus { get; private set; }
        /// <summary>
        /// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        public HeroID heroID { get; private set; }
        /// <summary>
        /// The team who chose the pick or ban; 0 for Radiant, 1 for Dire.
        /// </summary>
        public Team team { get; private set; }
        /// <summary>
        /// The order of which the picks and bans were selected; 0-19.
        /// </summary>
        public int order { get; private set; }

        public PickOrBan(PickStatus pickStatus, HeroID heroID, Team team, int order) {
            this.pickStatus = pickStatus;
            this.heroID = heroID;
            this.team = team;
            this.order = order;
        }
    }
}
