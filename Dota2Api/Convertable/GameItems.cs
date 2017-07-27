using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// GetGameItems method helping class.
    /// </summary>
    public class GameItems {
        /// <summary>
        /// List of items.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public List<GameItem> items;
    }
}
