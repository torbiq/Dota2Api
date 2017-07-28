using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Dota2API.Convertable;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;

namespace Dota2API.Network {
    public static class API {

        //public static Exception KeyNotAssigned = new Exception("Key not assigned");
        //private static List<GameItem> gameItems;
        //private static List<Hero> heroes;

        private static string key;

        private static readonly string getMatchDetailsURL = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V1/";
        private static readonly string getMatchHistoryURL = "https://api.steampowered.com/IDOTA2Match_205790/GetMatchHistory/v1/";
        private static readonly string getHeroesURL = "https://api.steampowered.com/IEconDOTA2_205790/GetHeroes/v1/";
        private static readonly string getGameItemsURL = "https://api.steampowered.com/IEconDOTA2_205790/GetGameItems/v1/";

        public static void Initialize(string key, string language = "English") {
            API.key = key;
        }

        /// <summary>
        /// Detailed info about passed match.
        /// </summary>
        /// <param name="match_id">Unique match ID.</param>
        public static MatchDetails GetMatchDetails(UInt64 match_id)  {
            string resultJSON = GetStringAsync(getMatchDetailsURL + "?match_id=" + match_id.ToString() + "&key=" + key).Result;
            RootObject<MatchDetails> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<MatchDetails>>(resultJSON);
            return deseralizedJSON.result;
        }

        /// <summary>
        /// A list of heroes within Dota 2.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="language">The language to provide hero names in.</param>
        /// <param name="itemizedOnly">Return a list of itemized heroes only.</param>
        public static List<Hero> GetHeroes(string language = null, bool itemizedOnly = false) {
            string resultJSON = GetStringAsync(getHeroesURL
                + "?"
                + (language == null ? "" : "language=" + language + "&")
                + (itemizedOnly ? "itemizedonly=true&" : "")
                + "key="+ key).Result;
            RootObject<Heroes> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<Heroes>>(resultJSON);
            return deseralizedJSON.result.heroes;
        }

        /// <summary>
        /// Game items list.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="language">The language to provide item names in.</param>
        public static List<GameItem> GetGameItems(string language = null) {
            string resultJSON = GetStringAsync(getGameItemsURL
                + "?"
                + (language == null ? "" : "language=" + language + "&")
                + "key=" + key).Result;
            RootObject<GameItems> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<GameItems>>(resultJSON);
            return deseralizedJSON.result.items;
        }

        /// <summary>
        /// A list of matches ordered by their sequence num.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="startAtMatchSeqNum">The match sequence number to start returning results from.</param>
        /// <param name="matchesRequested">The amount of matches to return.</param>
        public static MatchHistoryBySequenceNum GetMatchHistoryBySequenceNum(UInt64? startAtMatchSeqNum = null, uint matchesRequested = 0) {
            string resultJSON = GetStringAsync(getHeroesURL
                + (startAtMatchSeqNum == null ? "" : "start_at_match_seq_num=" + startAtMatchSeqNum.Value)
                + (matchesRequested == 0 ? "" : "&matches_requested=" + matchesRequested)
                + "&key=" + key).Result;
            RootObject<MatchHistoryBySequenceNum> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<MatchHistoryBySequenceNum>>(resultJSON);
            return deseralizedJSON.result;
        }

        /// <summary>
        /// A list of matches, filterable by various parameters.
        /// </summary>
        /// <param name="request">Match history request (see class's members info for more).</param>
        public static MatchHistory GetMatchHistory(MatchHistoryRequest request) {
            string resultJSON = GetStringAsync(getMatchHistoryURL + request.ToString()).Result;
            RootObject<MatchHistory> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<MatchHistory>>(resultJSON);
            return deseralizedJSON.result;
        }

        /// <summary>
        /// Async http request dummy.
        /// </summary>
        /// <param name="address">URL</param>
        private static async Task<string> GetStringAsync(string address) {
            try {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address);
                HttpClient client = new HttpClient();
                var response = await client.SendAsync(request);

                if (response.StatusCode == HttpStatusCode.Forbidden) {
                    throw new System.Exception("Api-Key most likely wrong");
                }
                else if (response.StatusCode == HttpStatusCode.ServiceUnavailable) {
                    throw new System.Exception("Server is busy or api-call limit exceeded. Please wait 30 seconds and try again. Call only ~1 request/second.");
                }

                string content = await response.Content.ReadAsStringAsync();

                return content;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
