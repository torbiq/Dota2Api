using System;
using System.Collections.Generic;
using System.Text;

namespace Dota2Api.ConvertableClasses
{
    /// <summary>
    /// A list detailing a player's ability upgrades.
    /// </summary>
    public class AbilityUpgrades
    {
        /// <summary>
        /// A list detailing a player's ability upgrades.
        /// </summary>
        public List<AbilityUpgrade> list { get; private set; }

        public AbilityUpgrades(List<AbilityUpgrade> list) {
            this.list = new List<AbilityUpgrade>(list);
        }
    }
}
