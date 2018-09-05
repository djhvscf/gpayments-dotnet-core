using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class Charge
    {
        [JsonProperty(PropertyName = "customer_key", Required = Required.Always)]
        public string CustomerKey { get; set; }
        
        [JsonProperty(PropertyName = "amount", Required = Required.Always)]
        public double Amount { get; set; }
        
        [JsonProperty(PropertyName = "description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_description", Required = Required.AllowNull)]
        public string EntityDescription { get; set; }

        [JsonProperty(PropertyName = "currency", Required = Required.AllowNull)]
        public string Currency { get; set; }
    }
}
