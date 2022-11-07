﻿using Flutterwave.Net.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Flutterwave.Net
{
    public class FlutterwaveApi : IFlutterwaveApi
    {
        private HttpClient _httpClient { get; }
        public IBanks Banks { get; }
        public IMiscellaneous Miscellaneous { get; }
        public IPayments Payments { get; }
        public ISubAccounts SubAccounts { get; }
        public ITransactions Transactions { get; }

        public ITransfers Transfers { get; }

        public FlutterwaveApi(string secretKey)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(Endpoints.FLUTTERWAVE_API_BASE_URL) };
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", secretKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Banks = new Banks(this);
            Miscellaneous = new Miscellaneous(this);
            Payments = new Payments(this);
            SubAccounts = new SubAccounts(this);
            Transactions = new Transactions(this);
            Transfers = new Transfers(this);
        }

        /// <summary>
        /// Make Delete requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal T Delete<T>(string relativeUrl)
        {
            string responseStr = _httpClient.DeleteAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Delete requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal async Task<T> DeleteAsync<T>(string relativeUrl)
        {
            string responseStr = await _httpClient.DeleteAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }


        /// <summary>
        /// Make Get requests to Flutterwave API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal T Get<T>(string relativeUrl)
        {
            string responseStr = _httpClient.GetAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Get requests to Flutterwave API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <returns></returns>
        internal async Task<T> GetAsync<T>(string relativeUrl)
        {
            string responseStr = await _httpClient.GetAsync(relativeUrl)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Get requests to Flutterwave API with query parameters
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal T Get<T>(string relativeUrl, Dictionary<string, string> queryParameters)
        {
            string queryString = "?";

            foreach (var param in queryParameters)
            {
                queryString += param.Key + "=" + param.Value + "&";
            }

            string responseStr = _httpClient.GetAsync(relativeUrl + queryString)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Get requests to Flutterwave API with query parameters
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal async Task<T> GetAsync<T>(string relativeUrl, Dictionary<string, string> queryParameters)
        {
            string queryString = "?";

            foreach (var param in queryParameters)
            {
                queryString += param.Key + "=" + param.Value + "&";
            }

            string responseStr = await _httpClient.GetAsync(relativeUrl + queryString)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Post requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data">Payload to pass in body of request</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal T Post<T>(string relativeUrl, 
                           object data = null, 
                           Dictionary<string, string> queryParameters = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string queryString = "?";

            if(queryParameters != null)
            {
                foreach (var param in queryParameters)
                {
                    queryString += param.Key + "=" + param.Value + "&";
                }
            }

            string responseStr = _httpClient.PostAsync(relativeUrl + queryString, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Post requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data">Payload to pass in body of request</param>
        /// <param name="queryParameters">Dictionary of query parameters</param>
        /// <returns></returns>
        internal async Task<T> PostAsync<T>(string relativeUrl,
                           object data = null,
                           Dictionary<string, string> queryParameters = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string queryString = "?";

            if (queryParameters != null)
            {
                foreach (var param in queryParameters)
                {
                    queryString += param.Key + "=" + param.Value + "&";
                }
            }

            string responseStr = await _httpClient.PostAsync(relativeUrl + queryString, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Put requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal T Put<T>(string relativeUrl, object data = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string responseStr = _httpClient.PutAsync(relativeUrl, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync()
                                            .Result;

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }

        /// <summary>
        /// Make Put requests to Flutterwave to API
        /// </summary>
        /// <typeparam name="T">Response Data Type</typeparam>
        /// <param name="relativeUrl">endpoint</param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal async Task<T> PutAsync<T>(string relativeUrl, object data = null)
        {
            StringContent jsonData = null;

            if (data != null)
            {
                jsonData = new StringContent(JsonConvert.SerializeObject(data),
                                             Encoding.UTF8,
                                             "application/json");
            }

            string responseStr = await _httpClient.PutAsync(relativeUrl, jsonData)
                                            .Result
                                            .Content
                                            .ReadAsStringAsync();

            var responseData = JsonConvert.DeserializeObject<T>(responseStr);

            return responseData;
        }
    }
}
