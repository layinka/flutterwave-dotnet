using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class BVNConsent
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
