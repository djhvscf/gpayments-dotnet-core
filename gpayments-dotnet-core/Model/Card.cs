using Newtonsoft.Json;

namespace gpayments_core.Model
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string Last4 { get; set; }
        [JsonProperty(PropertyName = "Exp_Year", NullValueHandling =  NullValueHandling.Ignore)]
        public int ExpirationYear { get; set; }

        [JsonProperty(PropertyName ="Exp_Month", NullValueHandling = NullValueHandling.Ignore)]
        public int ExpirationMonth { get; set; }
        public string Brand { get; set; }
        public string CVC { get; set; }
    }
}
