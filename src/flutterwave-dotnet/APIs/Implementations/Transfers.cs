using Flutterwave.Net.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class Transfers: ITransfers
    {
        private FlutterwaveApi _flutterwaveApi { get; }

        public Transfers(FlutterwaveApi flutterwaveApi)
        {
            _flutterwaveApi = flutterwaveApi;
        }

        /// <summary>
        /// Start a Transfer
        /// </summary>
        /// <param name="amount">This is the amount to be Transferred</param>
        /// <param name="currency">This is the specified currency the recipient will get</param>
        /// <param name="debitCurrency">This is the specified currency the sender will be debited in</param>
        /// <param name="accountNumber">The account number to send to</param>
        /// <param name="accountBankCode">The Bank code </param>
        /// <returns>Success</returns>
        public InitiateTransferResponse InitiateTransfer(decimal amount,
                                        string accountNumber,
                                        string accountBankCode,
                                        string reference,
                                        string narration = " ",
                                        Currency currency = Currency.NigerianNaira, 
                                        Currency debitCurrency = Currency.NigerianNaira)
        {
            var data = new InitiateTransferRequest(amount,accountNumber,accountBankCode,reference,narration, currency.GetValue(), debitCurrency.GetValue());
            return _flutterwaveApi.Post<InitiateTransferResponse>(
                $"{Endpoints.TRANSFERS}", data);
        }

        /// <summary>
        /// Start a Transfer
        /// </summary>
        /// <param name="amount">This is the amount to be Transferred</param>
        /// <param name="currency">This is the specified currency the recipient will get</param>
        /// <param name="debitCurrency">This is the specified currency the sender will be debited in</param>
        /// <param name="accountNumber">The account number to send to</param>
        /// <param name="accountBankCode">The Bank code </param>
        /// <returns>Success</returns>
        public Task<InitiateTransferResponse> InitiateTransferAsync(decimal amount,
                                        string accountNumber,
                                        string accountBankCode,
                                        string reference,
                                        string narration = " ",
                                        Currency currency = Currency.NigerianNaira,
                                        Currency debitCurrency = Currency.NigerianNaira)
        {
            var data = new InitiateTransferRequest(amount, accountNumber, accountBankCode, reference, narration, currency.GetValue(), debitCurrency.GetValue());
            return _flutterwaveApi.PostAsync<InitiateTransferResponse>(
                $"{Endpoints.TRANSFERS}", data);
        }

        /// <summary>
        /// Estimate the fee needed for a Transfer
        /// </summary>
        /// <param name="amount">This is the amount to be Transferred</param>
        /// <param name="currency">This is the specified currency the recipient will get</param>
        /// <param name="type">
        /// The type of transfer i.e mobilemoney, barter, or account
        /// </param>
        /// <returns>A list of Fees for this transfer</returns>
        public TransferFeeResponse GetFee(decimal amount,
                                        string type,
                                        Currency currency = Currency.NigerianNaira)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "amount", amount.ToString() },
                { "currency", currency.GetValue() },
                { "type", type }
            };
            return _flutterwaveApi.Get<TransferFeeResponse>(
                $"{Endpoints.TRANSFERS}/fees", queryParameters);
        }

        
        /// <summary>
        /// Estimate the fee needed for a Transfer
        /// </summary>
        /// <param name="amount">This is the amount to be Transferred</param>
        /// <param name="currency">This is the specified currency the recipient will get</param>
        /// <param name="type">
        /// The type of transfer i.e mobilemoney, barter, or account
        /// </param>
        /// <returns>A list of Fees for this transfer</returns>
        public Task<TransferFeeResponse> GetFeeAsync(decimal amount,
                                        string type,
                                        Currency currency = Currency.NigerianNaira)
        {
            var queryParameters = new Dictionary<string, string>
            {
                { "amount", amount.ToString() },
                { "currency", currency.GetValue() },
                { "type", type }
            };
            return _flutterwaveApi.GetAsync<TransferFeeResponse>(
                $"{Endpoints.TRANSFERS}/fees", queryParameters);
        }
    }
}
