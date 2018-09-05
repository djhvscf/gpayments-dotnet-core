using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class Me
    {
        [JsonProperty("developer_key")]
        public string DeveloperKey { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bank_account_number")]
        public string BankAccountNumber { get; set; }

        [JsonProperty("bank_sinpe")]
        public string BankSinpe { get; set; }
    }
}
