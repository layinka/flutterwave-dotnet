using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flutterwave.Net.Requests
{
    public class InitiateBVNConsentRequest
    {
        [JsonProperty("bvn", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("bvn")]
        public string BVN { get; set; }

        [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        [JsonProperty("redirect_url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }


}
