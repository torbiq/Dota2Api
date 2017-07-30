using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    /// <summary>
    /// Helper class for JSON parsing to list.
    /// </summary>
    public class Heroes {
        /// <summary>
        /// List of heroes.
        /// </summary>
        [JsonProperty(PropertyName = "heroes")]
        public List<Hero> heroes;
    }
}
