using Dota2API.Enums;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class AdditionalUnit {
        [JsonProperty(PropertyName = "unitname")]
        public string unitname { get; set; }

        [JsonProperty(PropertyName = "item_0")]
        public ItemID item_0 { get; set; }

        [JsonProperty(PropertyName = "item_1")]
        public ItemID item_1 { get; set; }

        [JsonProperty(PropertyName = "item_2")]
        public ItemID item_2 { get; set; }

        [JsonProperty(PropertyName = "item_3")]
        public ItemID item_3 { get; set; }

        [JsonProperty(PropertyName = "item_4")]
        public ItemID item_4 { get; set; }

        [JsonProperty(PropertyName = "item_5")]
        public ItemID item_5 { get; set; }

        [JsonProperty(PropertyName = "backpack_0")]
        public ItemID backpack_0 { get; set; }

        [JsonProperty(PropertyName = "backpack_1")]
        public ItemID backpack_1 { get; set; }

        [JsonProperty(PropertyName = "backpack_2")]
        public ItemID backpack_2 { get; set; }
    }
}