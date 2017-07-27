using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class PickOrBan {
        /// <summary>
        /// Whether this entry is a pick (true) or a ban (false).
        /// </summary>
        [JsonProperty(PropertyName = "is_pick")]
        public bool isPick { get; private set; }

        /// <summary>
        /// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
        /// </summary>
        [JsonProperty(PropertyName = "hero_id")]
        public HeroID heroID { get; private set; }

        /// <summary>
        /// The team who chose the pick or ban; 0 for Radiant, 1 for Dire.
        /// </summary>
        [JsonProperty(PropertyName = "team")]
        public Team team { get; private set; }

        /// <summary>
        /// The order of which the picks and bans were selected; 0-19.
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public PickOrder order { get; private set; }
    }
}
