using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// Player detailed info.
    /// </summary>
    public class Player {
        /// <summary>
        /// 32-bit account ID.
        /// </summary>
        [JsonProperty(PropertyName = "account_id")]
        public System.Int64 accountID { get; set; }

        /// <summary>
        /// The first bit represent the player's team, false if Radiant and true if dire. The final three bits represent the player's position in that team, from 0-4.
        /// </summary>
        // ┌─────────────── Team (false if Radiant, true if Dire).
        // │ ┌─┬─┬─┬─────── Not used.
        // │ │ │ │ │ ┌─┬─┬─ The position of a player within their team (0-4).
        // │ │ │ │ │ │ │ │
        // 0 0 0 0 0 0 0 0
        [JsonProperty(PropertyName = "player_slot")]
        public byte playerSlot { get; private set; }

        /// <summary>
        /// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty(PropertyName = "hero_id")]
        public HeroID heroID { get; private set; }

        /// <summary>
        /// ID of the top-left inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_0")]
        public ItemID item_0 { get; private set; }

        /// <summary>
        /// ID of the top-center inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_1")]
        public ItemID item_1 { get; private set; }

        /// <summary>
        /// ID of the top-right inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_2")]
        public ItemID item_2 { get; private set; }

        /// <summary>
        /// ID of the bottom-left inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_3")]
        public ItemID item_3 { get; private set; }

        /// <summary>
        /// ID of the bottom-center inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_4")]
        public ItemID item_4 { get; private set; }

        /// <summary>
        /// ID of the bottom-right inventory item.
        /// </summary>
        [JsonProperty(PropertyName = "item_5")]
        public ItemID item_5 { get; private set; }

        /// <summary>
        /// ID of the left backpack item.
        /// </summary>
        [JsonProperty(PropertyName = "backpack_0")]
        public ItemID backpack_0 { get; private set; }

        /// <summary>
        /// ID of the center backpack item.
        /// </summary>
        [JsonProperty(PropertyName = "backpack_1")]
        public ItemID backpack_1 { get; private set; }

        /// <summary>
        /// ID of the right backpack item.
        /// </summary>
        [JsonProperty(PropertyName = "backpack_2")]
        public ItemID backpack_2 { get; private set; }

        /// <summary>
        /// The amount of kills attributed to this player.
        /// </summary>
        [JsonProperty(PropertyName = "kills")]
        public int kills { get; private set; }

        /// <summary>
        /// The amount of times this player died during the match.
        /// </summary>
        [JsonProperty(PropertyName = "deaths")]
        public int deaths { get; private set; }

        /// <summary>
        /// The amount of assists attributed to this player.
        /// </summary>
        [JsonProperty(PropertyName = "assists")]
        public int assists { get; private set; }

        [JsonProperty(PropertyName = "leaver_status")]
        public LeaverStatus leaverStatus { get; private set; }

        /// <summary>
        /// The amount of gold the player had remaining at the end of the match.
        /// </summary>
        [JsonProperty(PropertyName = "gold")]
        public int gold { get; private set; }

        /// <summary>
        /// The amount of last-hits the player got during the match.
        /// </summary>
        [JsonProperty(PropertyName = "last_hits")]
        public int lastHits { get; private set; }

        /// <summary>
        /// The amount of denies the player got during the match.
        /// </summary>
        [JsonProperty(PropertyName = "denies")]
        public int denies { get; private set; }

        /// <summary>
        /// The player's overall gold/minute.
        /// </summary>
        [JsonProperty(PropertyName = "gold_per_min")]
        public int goldPerMin { get; private set; }

        /// <summary>
        /// The player's overall experience/minute.
        /// </summary>
        [JsonProperty(PropertyName = "xp_per_min")]
        public int xpPerMin { get; private set; }

        /// <summary>
        /// The amount of gold the player spent during the match.
        /// </summary>
        [JsonProperty(PropertyName = "gold_spent")]
        public int goldSpent { get; private set; }

        /// <summary>
        /// The amount of damage the player dealt to heroes.
        /// </summary>
        [JsonProperty(PropertyName = "hero_damage")]
        public int heroDamage { get; private set; }

        /// <summary>
        /// The amount of damage the player dealt to towers.
        /// </summary>
        [JsonProperty(PropertyName = "tower_damage")]
        public int towerDamage { get; private set; }

        /// <summary>
        /// The amount of health the player had healed on heroes.
        /// </summary>
        [JsonProperty(PropertyName = "hero_healing")]
        public int heroHealing { get; private set; }

        /// <summary>
        /// The player's level at match end.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public Level level { get; private set; }

        /// <summary>
        /// A list detailing a player's ability upgrades.
        /// </summary>
        [JsonProperty(PropertyName = "ability_upgrades")]
        public System.Collections.Generic.List<AbilityUpgrade> abilityUpgrades { get; private set; }

        /// <summary>
        /// Additional playable units owned by the player.
        /// </summary>
        [JsonProperty(PropertyName = "additional_units")]
        public System.Collections.Generic.List<AdditionalUnit> additionalUnits { get; private set; }

        /// <summary>
        /// Undocumented. Possibly damage after armour.
        /// </summary>
        [JsonProperty(PropertyName = "scaled_hero_damage")]
        public int scaledHeroDamage { get; private set; }

        /// <summary>
        /// Undocumented.
        /// </summary>
        [JsonProperty(PropertyName = "scaled_tower_damage")]
        public int scaledTowerDamage { get; private set; }

        /// <summary>
        /// Undocumented.
        /// </summary>
        [JsonProperty(PropertyName = "scaled_hero_healing")]
        public int scaledHeroHealing { get; private set; }
    }
}