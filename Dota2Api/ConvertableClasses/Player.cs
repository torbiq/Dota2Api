using System;
using System.Collections.Generic;
using System.Text;
using Dota2Api.Enums;

namespace Dota2Api.ConvertableClasses
{
    /// <summary>
    /// Represents player info from MatchDetails.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// 32-bit account ID.
        /// </summary>
        public int accoundID { get; private set; }
        /// <summary>
        /// Player scoretab position and side.
        /// </summary>
        public PlayerSlot playerSlot { get; private set; }
        /// <summary>
        /// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        public HeroID heroID { get; private set; }
        /// <summary>
        /// ID of the top-left inventory item.
        /// </summary>
        public ItemID item0 { get; private set; }
        /// <summary>
        /// ID of the top-center inventory item.
        /// </summary>
        public ItemID item1 { get; private set; }
        /// <summary>
        /// ID of the top-right inventory item.
        /// </summary>
        public ItemID item2 { get; private set; }
        /// <summary>
        /// ID of the bottom-left inventory item.
        /// </summary>
        public ItemID item3 { get; private set; }
        /// <summary>
        /// ID of the bottom-center inventory item.
        /// </summary>
        public ItemID item4 { get; private set; }
        /// <summary>
        /// ID of the bottom-right inventory item.
        /// </summary>
        public ItemID item5 { get; private set; }
        /// <summary>
        /// The amount of kills attributed to this player.
        /// </summary>
        public int kills { get; private set; }
        /// <summary>
        /// The amount of times this player died during the match.
        /// </summary>
        public int deaths { get; private set; }
        /// <summary>
        /// The amount of assists attributed to this player.
        /// </summary>
        public int assists { get; private set; }
        /// <summary>
        /// Leaver status of player (0 stands for non-leaving).
        /// </summary>
        public LeaverStatus leaverStatus { get; private set; }
        /// <summary>
        /// The amount of gold the player had remaining at the end of the match.
        /// </summary>
        public int gold { get; private set; }
        /// <summary>
        /// The amount of last-hits the player got during the match.
        /// </summary>
        public int lastHits { get; private set; }
        /// <summary>
        /// The amount of denies the player got during the match.
        /// </summary>
        public int denies { get; private set; }
        /// <summary>
        /// The player's overall gold/minute.
        /// </summary>
        public int goldPerMin { get; private set; }
        /// <summary>
        /// The player's overall experience/minute.
        /// </summary>
        public int xpPerMin { get; private set; }
        /// <summary>
        /// The amount of gold the player spent during the match.
        /// </summary>
        public int goldSpent { get; private set; }
        /// <summary>
        /// The amount of damage the player dealt to heroes.
        /// </summary>
        public int heroDamage { get; private set; }
        /// <summary>
        /// The amount of damage the player dealt to towers.
        /// </summary>
        public int towerDamage { get; private set; }
        /// <summary>
        /// The amount of health the player had healed on heroes.
        /// </summary>
        public int heroHealing { get; private set; }
        /// <summary>
        /// The player's level at match end.
        /// </summary>
        public Level level { get; private set; }
        /// <summary>
        /// A list detailing a player's ability upgrades.
        /// </summary>
        public AbilityUpgrades abilityUpgrades { get; private set; }
        ///// <summary>
        ///// Additional playable units owned by the player.
        ///// <summary>
        //public AdditionalUnits additionalUnits { get; private set; }
    }
}
