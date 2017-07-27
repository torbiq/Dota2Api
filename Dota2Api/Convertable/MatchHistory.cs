using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    public class MatchHistory {
        public enum Status {
            Success = 1,
            UserIsAnonymous = 15,
        }

        [JsonProperty(PropertyName = "status")]
        public Status status { get; private set; }

        /// <summary>
        /// A message explaining the status, should status not be 1.
        /// </summary>
        [JsonProperty(PropertyName = "statusDetail")]
        public Status statusDetail { get; private set; }

        /// <summary>
        /// The number of matches in this response.
        /// </summary>
        [JsonProperty(PropertyName = "num_results")]
        public int numResults { get; private set; }

        /// <summary>
        /// The total number of matches for the query.
        /// </summary>
        [JsonProperty(PropertyName = "total_results")]
        public int totalResults { get; private set; }

        /// <summary>
        /// The number of matches left for this query.
        /// </summary>
        [JsonProperty(PropertyName = "results_remaining")]
        public int resultsRemaining { get; private set; }

        /// <summary>
        /// A list of matches.
        /// </summary>
        [JsonProperty(PropertyName = "matches")]
        public List<MatchDetails> matches { get; private set; }
    }
}
