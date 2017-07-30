using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// Represents in-game item info structure.
    /// </summary>
    public class GameItem {
        /// <summary>
        /// ID of item.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public ItemID id { get; set; }

        /// <summary>
        /// The tokenized string for the name of item.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        /// <summary>
        /// The in-game gold cost of the item.
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public int cost { get; set; }

        /// <summary>
        /// Boolean - true if the item is only available in the secret shop.
        /// </summary>
        [JsonProperty(PropertyName = "secret_shop")]
        public bool secretShop { get; set; }

        /// <summary>
        /// Boolean - true if the item is available in the side shop.
        /// </summary>
        [JsonProperty(PropertyName = "side_shop")]
        public bool sideShop { get; set; }

        /// <summary>
        /// Boolean - true if the item is a recipe type item.
        /// </summary>
        [JsonProperty(PropertyName = "recipe")]
        public bool recipe { get; set; }

        /// <summary>
        /// The localized name of the hero for use in name display. You will get it only if specifie 'language' parameter.
        /// </summary>
        [JsonProperty(PropertyName = "localized_name")]
        public string localizedName { get; set; }
    }
}