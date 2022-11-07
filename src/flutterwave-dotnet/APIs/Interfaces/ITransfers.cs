using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public interface ITransfers
    {
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
                                        Currency debitCurrency = Currency.NigerianNaira);

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
                                        Currency debitCurrency = Currency.NigerianNaira);

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
                                        Currency currency = Currency.NigerianNaira);
        /**
        /// <summary>
        /// Estimate the fee needed for a Transfer
        /// </summary>
        /// <param name="amount">This is the amount to be Transferred</param>
        /// <param name="currency">This is the specified currency the recipient will get</param>
        /// <param name="type">
        /// The type of transfer i.e mobilemoney, barter, or account
        /// </param>
        /// <returns>A list of Fees</returns>
        */
        public Task<TransferFeeResponse> GetFeeAsync(decimal amount,
                                        string type,
                                        Currency currency = Currency.NigerianNaira);
    }
}
