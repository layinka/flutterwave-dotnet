﻿namespace Flutterwave.Net
{
    public interface IMiscellaneous
    {
        /// <summary>
        /// Verify a bank account number
        /// </summary>
        /// <param name="accountNumber">
        /// Account number to be verified
        /// </param>
        /// <param name="bankCode">
        /// Bank code. It is returned in the Get banks call as data.Code
        /// </param>
        /// <returns>The bank account name and number</returns>
        public VerifyBankAccountResponse VerifyBankAccount(string accountNumber, string bankCode);


        /// <summary>
        /// Verify a BVN number
        /// </summary>
        /// <param name="bvn">The Valid BVN Number you want to verify</param>
        /// <returns>The customers details</returns>
        public VerifyBVNResponse VerifyBVN(string bvn);
    }
}
