using Newtonsoft.Json;
using System;

namespace gpayments_core.Model
{
    public class Log
    {
        [JsonProperty("charge_id")]
        public string ChargeId { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("charge_by_customer")]
        public bool ChargeByCustomer { get; set; }

        [JsonProperty("charge_log")]
        public ChargeLog ChargeLog { get; set; }

        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty("created_on_pretty")]
        public string CreatedOnPretty { get; set; }

        [JsonProperty("created_on_date")]
        public string CreatedOnDate { get; set; }
    }
}
