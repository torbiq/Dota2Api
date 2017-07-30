using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    /// <summary>
    /// Helper class for JSON parsing.
    /// </summary>
    public class LeagueListing {
        /// <summary>
        /// A list of leagues supported in-game via DotaTV.
        /// </summary>
        [JsonProperty(PropertyName = "leagues")]
        public List<League> leagues { get; private set; }
    }
}
