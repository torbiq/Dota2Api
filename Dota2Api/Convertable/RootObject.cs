using Newtonsoft.Json;

namespace Dota2API.Convertable {
    /// <summary>
    /// Generic class for parsing JSON results from valve servers (returned info always starts with  root object name = "result").
    /// </summary>
    /// <typeparam name="T">Casting type</typeparam>
    public class RootObject<T> where T : class {
        /// <summary>
        /// Result root object returned.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public T result { get; private set; }
    }
}