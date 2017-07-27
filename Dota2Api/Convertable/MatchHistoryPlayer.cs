using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class MatchHistoryPlayer {
        [JsonProperty(PropertyName = "account_id")]
        public System.Int64 accountID { get; set; }

        [JsonProperty(PropertyName = "player_slot")]
        public int playerSlot { get; private set; }

        [JsonProperty(PropertyName = "hero_id")]
        public ItemID heroID { get; private set; }

        [JsonProperty(PropertyName = "item_0")]
        public ItemID item_0 { get; private set; }

        [JsonProperty(PropertyName = "item_1")]
        public ItemID item_1 { get; private set; }

        [JsonProperty(PropertyName = "item_2")]
        public ItemID item_2 { get; private set; }

        [JsonProperty(PropertyName = "item_3")]
        public ItemID item_3 { get; private set; }

        [JsonProperty(PropertyName = "item_4")]
        public ItemID item_4 { get; private set; }

        [JsonProperty(PropertyName = "item_5")]
        public ItemID item_5 { get; private set; }

        [JsonProperty(PropertyName = "backpack_0")]
        public ItemID backpack_0 { get; private set; }

        [JsonProperty(PropertyName = "backpack_1")]
        public ItemID backpack_1 { get; private set; }

        [JsonProperty(PropertyName = "backpack_2")]
        public ItemID backpack_2 { get; private set; }

        [JsonProperty(PropertyName = "kills")]
        public int kills { get; private set; }

        [JsonProperty(PropertyName = "deaths")]
        public int deaths { get; private set; }

        [JsonProperty(PropertyName = "assists")]
        public int assists { get; private set; }

        [JsonProperty(PropertyName = "leaver_status")]
        public LeaverStatus leaverStatus { get; private set; }

        [JsonProperty(PropertyName = "last_hits")]
        public int lastHits { get; private set; }

        [JsonProperty(PropertyName = "denies")]
        public int denies { get; private set; }

        [JsonProperty(PropertyName = "gold_per_min")]
        public int goldPerMin { get; private set; }

        [JsonProperty(PropertyName = "xp_per_min")]
        public int xpPerMin { get; private set; }

        [JsonProperty(PropertyName = "level")]
        public Level level { get; private set; }

        [JsonProperty(PropertyName = "hero_damage")]
        public int heroDamage { get; private set; }

        [JsonProperty(PropertyName = "tower_damage")]
        public int towerDamage { get; private set; }

        [JsonProperty(PropertyName = "hero_healing")]
        public int heroHealing { get; private set; }

        [JsonProperty(PropertyName = "gold")]
        public int gold { get; private set; }

        [JsonProperty(PropertyName = "gold_spent")]
        public int goldSpent { get; private set; }

        [JsonProperty(PropertyName = "scaled_hero_damage")]
        public int scaledHeroDamage { get; private set; }

        [JsonProperty(PropertyName = "scaled_tower_damage")]
        public int scaledTowerDamage { get; private set; }

        [JsonProperty(PropertyName = "scaled_hero_healing")]
        public int scaledHeroHealing { get; private set; }

        [JsonProperty(PropertyName = "ability_upgrades")]
        public System.Collections.Generic.List<AbilityUpgrade> abilityUpgrades { get; private set; }

        [JsonProperty(PropertyName = "additional_units")]
        public System.Collections.Generic.List<AdditionalUnit> additionalUnits { get; private set; }
    }
}