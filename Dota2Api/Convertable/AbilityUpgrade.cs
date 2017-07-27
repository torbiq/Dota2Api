using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class AbilityUpgrade {
        [JsonProperty(PropertyName = "ability")]
        public AbilityID ability { get; set; }

        [JsonProperty(PropertyName = "time")]
        public int time { get; set; }

        [JsonProperty(PropertyName = "level")]
        public Level level { get; set; }
    }
}