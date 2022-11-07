using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class Transfer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("debit_currency")]
        public string DebitCurrency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("fee")]
        public double Fee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("complete_message")]
        public string CompleteMessage { get; set; }

        [JsonProperty("requires_approval")]
        public int RequiresApproval { get; set; }

        [JsonProperty("is_approved")]
        public int IsApproved { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }
    }


    public class TransferFee
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("fee_type")]
        public string FeeType { get; set; }

        [JsonProperty("fee")]
        public int Fee { get; set; }
    }

}
