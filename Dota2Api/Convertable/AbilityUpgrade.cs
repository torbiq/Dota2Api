using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// Contains info about ability upgrade.
    /// </summary>
    public class AbilityUpgrade {
        /// <summary>
        /// Ability ID.
        /// </summary>
        [JsonProperty(PropertyName = "ability")]
        public AbilityID ability { get; set; }

        /// <summary>
        /// Time it was upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public int time { get; set; }

        /// <summary>
        /// Wich level was player when upgraded ability.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public Level level { get; set; }
    }
}