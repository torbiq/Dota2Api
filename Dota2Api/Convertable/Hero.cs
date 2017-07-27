using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// Hero info.
    /// </summary>
    public class Hero {
        /// <summary>
        /// The tokenized string for the name of the hero.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string name { get; private set; }

        /// <summary>
        /// ID of the hero.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public HeroID id { get; private set; }

        /// <summary>
        /// The localized name of the hero for use in name display.
        /// </summary>
        [JsonProperty(PropertyName = "localized_name")]
        public string localizedName { get; private set; }
    }
}
