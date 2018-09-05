using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class Subscription
    {
        [JsonProperty("subscription_id")]
        public string SubscriptionId { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("plan")]
        public ListPlan Plan { get; set; }
    }
}
