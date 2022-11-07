using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flutterwave.Net
{
    
    public class InitiateTransferRequest
    {
        public InitiateTransferRequest(decimal amount,
                                        string accountNumber,
                                        string accountBankCode,
                                        string reference,
                                        string narration = " ",
                                        string currency="NGN", string debitCurrency = "NGN")
        {
            Amount = amount;
            AccountNumber = accountNumber;
            AccountBank = accountBankCode;
            Currency = currency;
            Reference = reference;
            Narration = narration;
            DebitCurrency = debitCurrency;
        }

        [Required]
        [JsonProperty("account_bank")]
        public string AccountBank { get; set; }

        [Required]
        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [Required]
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [Required]
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("debit_currency")]
        public string? DebitCurrency { get; set; }

        [JsonProperty("narration")]
        public string Narration { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }


    public class TransferFeeRequest
    {

        public TransferFeeRequest()
        {

        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
