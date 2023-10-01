using Flutterwave.Net.Requests;
using Flutterwave.Net.Responses;
using Flutterwave.Net.Utilities;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class Miscellaneous : IMiscellaneous
    {
        private FlutterwaveApi _flutterwaveApi { get; }

        public Miscellaneous(FlutterwaveApi flutterwaveApi)
        {
            _flutterwaveApi = flutterwaveApi;
        }

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
        public VerifyBankAccountResponse VerifyBankAccount(string accountNumber, 
                                                           string bankCode)
        {
            var data = new VerifyBankAccountRequest(accountNumber, bankCode);

            return _flutterwaveApi.Post<VerifyBankAccountResponse>(
                Endpoints.BANK_ACCOUNT_VERIFICATION, data);
        }

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
        public Task<VerifyBankAccountResponse> VerifyBankAccountAsync(string accountNumber,
                                                           string bankCode)
        {
            var data = new VerifyBankAccountRequest(accountNumber, bankCode);

            return _flutterwaveApi.PostAsync<VerifyBankAccountResponse>(
                Endpoints.BANK_ACCOUNT_VERIFICATION, data); 
        }


        /// <summary>
        /// Initiate BVN consent flow for your customer
        /// </summary>
        /// <param name="bvn">The bank verification number of the customer. It should be 11 digits.</param>
        /// <param name="firstName">The customer's first name</param>
        /// <param name="lastName">The customer's last name</param>
        /// <param name="redirectUrl">The link to redirect the customer after giving consent.</param>
        /// <returns>The consent link</returns>
        public InitiateBVNConsentResponse InitiateBVNConsent(string bvn, string firstName, string lastName, string redirectUrl)
        {
            var data = new InitiateBVNConsentRequest
            {
                BVN=bvn,
                FirstName=firstName,
                LastName=lastName,
                RedirectUrl=redirectUrl
            };
            return _flutterwaveApi.Post<InitiateBVNConsentResponse>($"{Endpoints.BVN_INITIATE_CONSENT}", data);
        }

        /// <summary>
        /// Initiate BVN consent flow for your customer
        /// </summary>
        /// <param name="bvn">The bank verification number of the customer. It should be 11 digits.</param>
        /// <param name="firstName">The customer's first name</param>
        /// <param name="lastName">The customer's last name</param>
        /// <param name="redirectUrl">The link to redirect the customer after giving consent.</param>
        /// <returns>The consent link</returns>
        public InitiateBVNConsentResponse InitiateBVNConsentAsync(string bvn, string firstName, string lastName, string redirectUrl)
        {
            var data = new InitiateBVNConsentRequest
            {
                BVN = bvn,
                FirstName = firstName,
                LastName = lastName,
                RedirectUrl = redirectUrl
            };
            return _flutterwaveApi.Post<InitiateBVNConsentResponse>($"{Endpoints.BVN_INITIATE_CONSENT}", data);
        }

        /// <summary>
        /// Verify a BVN number
        /// </summary>
        /// <param name="consent_reference">The reference for the consent attempt.</param>
        /// <returns>The customers details</returns>
        public VerifyBVNResponse VerifyBVN(string consent_reference)
        {
            return _flutterwaveApi.Get<VerifyBVNResponse>($"{Endpoints.BVN_VERIFICATION}/{consent_reference}");
        }

        /// <summary>
        /// Verify a BVN number
        /// </summary>
        /// <param name="consent_reference">The reference for the consent attempt.</param>
        /// <returns>The customers details</returns>
        public Task<VerifyBVNResponse> VerifyBVNAsync(string consent_reference)
        {
            return _flutterwaveApi.GetAsync<VerifyBVNResponse>($"{Endpoints.BVN_VERIFICATION}/{consent_reference}" );
        }
    }
}
