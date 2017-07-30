using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dota2API.Convertable {
    /// <summary>
    /// Contains info about match history got by sequence num.
    /// </summary>
    public class MatchHistoryBySequenceNum {
        public enum Status {
            Success = 0,
            MatchesRequestedMustBeGreaterThanZero = 8,
        }

        [JsonProperty(PropertyName = "status")]
        public Status status { get; private set; }

        /// <summary>
        /// A message explaining the status, should status not be 1
        /// </summary>
        [JsonProperty(PropertyName = "statusDetail")]
        public string statusDetail { get; private set; }

        /// <summary>
        /// A list of matches.
        /// </summary>
        public List<MatchDetails> matches { get; private set; }
    }
}
