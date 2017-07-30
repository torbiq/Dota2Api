using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Dota2API.Convertable;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;
using Dota2API.Enums;

namespace Dota2API.Core {
    public class DotaWebAPI {
        private string key;
        private Language language;

        private readonly string getMatchDetailsURL = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V1/";
        private readonly string getMatchHistoryURL = "https://api.steampowered.com/IDOTA2Match_205790/GetMatchHistory/v1/";
        private readonly string getHeroesURL = "https://api.steampowered.com/IEconDOTA2_205790/GetHeroes/v1/";
        private readonly string getGameItemsURL = "https://api.steampowered.com/IEconDOTA2_205790/GetGameItems/v1/";
        private readonly string getLeagueListingURL = "http://api.steampowered.com/IDOTA2Match_<ID>/GetLeagueListing/v1/";

        /// <summary>
        /// Initializating of dota 2 api.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="language">Default language to work with.</param>
        public DotaWebAPI(string key, Language language = Language.english) {
            this.key = key;
            this.language = language;
        }

        /// <summary>
        /// Detailed info about passed match.
        /// </summary>
        /// <param name="match_id">Unique match ID.</param>
        public MatchDetails GetMatchDetails(UInt64 match_id)  {
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
        public List<Hero> GetHeroes(Language? language = null, bool itemizedOnly = false) {
            string resultJSON = GetStringAsync(getHeroesURL
                + "?"
                + "language=" + (language == null ? this.language : language.Value).ToString() + "&"
                + (itemizedOnly ? "itemizedonly=true&" : "")
                + "key=" + key).Result;
            RootObject<Heroes> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<Heroes>>(resultJSON);
            return deseralizedJSON.result.heroes;
        }

        /// <summary>
        /// Game items list.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="language">The language to provide item names in.</param>
        public List<GameItem> GetGameItems(Language? language = null) {
            string resultJSON = GetStringAsync(getGameItemsURL
                + "?"
                + "language=" + (language == null ? this.language : language.Value).ToString() + "&"
                + "key=" + key).Result;
            var deseralizedJSON = JsonConvert.DeserializeObject<RootObject<GameItems>>(resultJSON);
            return deseralizedJSON.result.items;
        }

        /// <summary>
        /// All leagues list.
        /// </summary>
        /// <param name="language">The language to provide leagues info in.</param>
        public List<League> GetLeagueListing(Language? language = null) {
            string resultJSON = GetStringAsync(getLeagueListingURL
                + "?"
                + "language=" + (language == null ? this.language : language.Value).ToString() + "&"
                + "key=" + key).Result;
            var deseralizedJSON = JsonConvert.DeserializeObject<RootObject<LeagueListing>>(resultJSON);
            return deseralizedJSON.result.leagues;
        }

        /// <summary>
        /// A list of matches ordered by their sequence num.
        /// </summary>
        /// <param name="key">API key.</param>
        /// <param name="startAtMatchSeqNum">The match sequence number to start returning results from.</param>
        /// <param name="matchesRequested">The amount of matches to return.</param>
        public MatchHistoryBySequenceNum GetMatchHistoryBySequenceNum(UInt64? startAtMatchSeqNum = null, uint matchesRequested = 0) {
            string resultJSON = GetStringAsync(getHeroesURL
                + "?"
                + (startAtMatchSeqNum == null ? "" : "start_at_match_seq_num=" + startAtMatchSeqNum.Value + "&")
                + (matchesRequested == 0 ? "" : "matches_requested=" + matchesRequested + "&")
                + "key=" + key).Result;
            var deseralizedJSON = JsonConvert.DeserializeObject<RootObject<MatchHistoryBySequenceNum>>(resultJSON);
            return deseralizedJSON.result;
        }

        /// <summary>
        /// A list of matches, filterable by various parameters.
        /// </summary>
        /// <param name="request">Match history request see <see cref="MatchHistoryRequest"/>.</param>
        public MatchHistory GetMatchHistory(MatchHistoryRequest request) {
            string resultJSON = GetStringAsync(getMatchHistoryURL + request.ToString() + "key=" + key).Result;
            RootObject<MatchHistory> deseralizedJSON = JsonConvert.DeserializeObject<RootObject<MatchHistory>>(resultJSON);
            return deseralizedJSON.result;
        }

        /// <summary>
        /// Async http request dummy.
        /// </summary>
        /// <param name="address">URL</param>
        private async Task<string> GetStringAsync(string address) {
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
