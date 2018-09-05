using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class SimpleCharge
    {
        [JsonProperty(PropertyName = "amount", Required = Required.Always)]
        public double Amount { get; set; }

        [JsonProperty(PropertyName = "description", Required = Required.Always)]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "entity_description", Required = Required.Always)]
        public string EntityDescription { get; set; }

        [JsonProperty(PropertyName = "currency", Required = Required.Always)]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "credit_card_number", Required = Required.Always)]
        public string CreditCardNumber { get; set; }

        [JsonProperty(PropertyName = "credit_card_security_code_number", Required = Required.Always)]
        public string CVC { get; set; }

        [JsonProperty(PropertyName = "exp_month", Required = Required.Always)]
        public int ExpirationMonth { get; set; }

        [JsonProperty(PropertyName = "exp_year", Required = Required.Always)]
        public int ExpirationYear { get; set; }
    }
}
