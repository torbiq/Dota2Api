using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    public class Heroes {
        /// <summary>
        /// List of heroes.
        /// </summary>
        [JsonProperty(PropertyName = "heroes")]
        public List<Hero> heroes;

        ///// <summary>
        ///// Number of results.
        ///// </summary>
        //[JsonProperty(PropertyName = "count")]
        //public int count;
    }
}
