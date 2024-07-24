﻿using Flutterwave.Net.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class Transactions : ITransactions
    {
        private FlutterwaveApi _flutterwaveApi { get; }

        public Transactions(FlutterwaveApi flutterwaveApi)
        {
            _flutterwaveApi = flutterwaveApi;
        }

        /// <summary>
        /// Get transaction fees
        /// </summary>
        /// <param name="amount">This is the amount of the product or service to be charged from the customer</param>
        /// <param name="currency">This is the specified currency to charge in</param>
        /// <returns>The transaction fees</returns>
        public GetTransactionFeeResponse GetTransactionFee(decimal amount,
                                                           Currency currency = Currency.NigerianNaira)
        {
            var queryParameters = new Dictionary<string, string>()
            {
                { "amount", amount.ToString() },
                { "currency", currency.GetValue() }
            };

            return _flutterwaveApi.Get<GetTransactionFeeResponse>(
                Endpoints.TRANSACTION_FEE, queryParameters);
        }

        /// <summary>
        /// Get transactions
        /// </summary>
        /// <param name="from">
        /// This is the specified date to start the list from. YYYY-MM-DD
        /// </param>
        /// <param name="to">
        /// The is the specified end period for the search . YYYY-MM-DD
        /// </param>
        /// <param name="page">
        /// This is the page number to retrieve
        /// </param>
        /// <param name="customerEmail">
        /// This is the email of the customer who carried out a transaction. Use for more specific listing.
        /// </param>
        /// <param name="status">
        /// This is the transaction status to filter the listing
        /// </param>
        /// <param name="txRef">
        /// This is the merchant reference tied to a transaction. Use for more specific listing
        /// </param>
        /// <param name="customerFullName">
        /// This is the combination of the customer first name and last name passed to rave during transaction.
        /// </param>
        /// <param name="currency">
        /// This is the currency the transaction list should come in
        /// </param>
        /// <returns>A list of all transactions</returns>
        public GetTransactionsResponse GetTransactions(string from = null,
                                                       string to = null,
                                                       int page = 1,
                                                       string customerEmail = null,
                                                       TransactionStatus? status = null,
                                                       string txRef = null,
                                                       string customerFullName = null,
                                                       Currency currency = Currency.NigerianNaira)
        {
            if (page <= 0)
                page = 1;

            var queryParameters = new Dictionary<string, string>()
            {
                { "page", page.ToString() },
                { "currency", currency.GetValue() }
            };

            if (!string.IsNullOrWhiteSpace(from))
                queryParameters.Add("from", from);
            
            if (!string.IsNullOrWhiteSpace(to))
                queryParameters.Add("to", to);

            if (!string.IsNullOrWhiteSpace(customerEmail))
                queryParameters.Add("customer_email", customerEmail);

            if (status != null)
                queryParameters.Add("status", status.GetValue());

            if (!string.IsNullOrWhiteSpace(txRef))
                queryParameters.Add("tx_ref", txRef);

            if (!string.IsNullOrWhiteSpace(customerFullName))
                queryParameters.Add("customer_fullname", customerFullName);

            return _flutterwaveApi.Get<GetTransactionsResponse>(
                Endpoints.TRANSACTIONS, queryParameters);
        }

        /// <summary>
        /// Resend a failed transaction webhook to your server
        /// </summary>
        /// <param name="transactionId">
        /// This is the transaction unique identifier. It is returned in the 
        /// initiate transaction call as data.Id
        /// </param>
        /// <param name="shouldWait">
        /// If this is passed the endpoint would hold for the hook response and 
        /// return what you respond with as the response. 
        /// (This parameter is called "wait" on the offical docs)
        /// </param>
        /// <returns>Success</returns>
        public ResendTransactionWebhookResponse ResendTransactionWebhook(long transactionId, 
                                                                         bool shouldWait = false)
        {
            Dictionary<string, string> queryParameters = null;
            
            if(shouldWait)
            {
                queryParameters = new Dictionary<string, string>()
                {
                    { "wait", "1" }
                };
            }

            return _flutterwaveApi.Post<ResendTransactionWebhookResponse>(
                $"{Endpoints.TRANSACTIONS}/{transactionId}/resend-hook", queryParameters: queryParameters);
        }

        /// <summary>
        /// Verify a transaction
        /// </summary>
        /// <param name="transactionId">
        /// This is the transaction unique identifier. It is returned in the Get transactions 
        /// call as data.Id
        /// </param>
        /// <returns>The transaction with the specified id</returns>
        public VerifyTransactionResponse VerifyTransaction(long transactionId)
        {
            return _flutterwaveApi.Get<VerifyTransactionResponse>(
                $"{Endpoints.TRANSACTIONS}/{transactionId}/verify");
        }

        /// <summary>
        /// Verify a transaction
        /// </summary>
        /// <param name="transactionId">
        /// This is the transaction unique identifier. It is returned in the Get transactions 
        /// call as data.Id
        /// </param>
        /// <returns>The transaction with the specified id</returns>
        public Task<VerifyTransactionResponse> VerifyTransactionAsync(long transactionId)
        {
            return _flutterwaveApi.GetAsync<VerifyTransactionResponse>(
                $"{Endpoints.TRANSACTIONS}/{transactionId}/verify");
        }

        /// <summary>
        /// View transaction timeline
        /// </summary>
        /// <param name="transactionId">
        /// This is the transaction unique identifier. It is returned in the Get transactions 
        /// call as data.Id
        /// </param>
        /// <returns>The events for the transaction with the specified id</returns>
        public ViewTransactionTimelineResponse ViewTransactionTimeline(long transactionId)
        {
            return _flutterwaveApi.Get<ViewTransactionTimelineResponse>(
                $"{Endpoints.TRANSACTIONS}/{transactionId}/events");
        }
    }
}
