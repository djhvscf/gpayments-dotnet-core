using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class ListPlan
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("information")]
        public Plan Plan { get; set; }
    }
}
