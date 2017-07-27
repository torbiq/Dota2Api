using Newtonsoft.Json;

namespace Dota2API.Convertable {
    public class RootObject<T> where T : class {
        [JsonProperty(PropertyName = "result")]
        public T result { get; private set; }
    }
}