using Newtonsoft.Json;
using System;

namespace gpayments_core.Model
{
    public class Plan
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; } //(month, week, day, year)

        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        [JsonProperty("credit_card_description")]
        public string CreditCardDescription { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }
}
