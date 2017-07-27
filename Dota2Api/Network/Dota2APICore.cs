using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Dota2API.Convertable;
using System.IO;
using Newtonsoft.Json;

namespace Dota2API.Network {
    public static class Dota2API {

        //public static Exception KeyNotAssigned = new Exception("Key not assigned");

        public static string getMatchDetailsURL = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V001/";
        public static string getMatchHistoryURL = "https://api.steampowered.com/IDOTA2Match_205790/GetMatchHistory/v001/";

        public static MatchHistoryResult GetMatchDetails(UInt64 match_id, string KEY) {
            string resultJSON = GetStringAsync(getMatchDetailsURL + "?match_id=" + match_id.ToString() + "&" + "key=" + KEY).Result;
            
            RootObject<MatchHistoryResult> result = JsonConvert.DeserializeObject<RootObject<MatchHistoryResult>>(resultJSON);
            Console.WriteLine(result.result.duration);
            return result.result;
        }

        public static string GetMatchHistory(MatchHistoryRequest request) {
            string resultJSON = GetStringAsync(getMatchHistoryURL + request.ToString()).Result;
            return resultJSON;
        }

        public static async Task<string> GetStringAsync(string address) {
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
