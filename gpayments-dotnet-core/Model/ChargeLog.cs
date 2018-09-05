using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class ChargeLog
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("entity_description")]
        public string EntityDescription { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }
    }
}
