using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flutterwave.Net
{

    public class BvnData
    {
        [JsonProperty("nin", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("nin")]
        public string nin { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("gender")]
        public string gender { get; set; }

        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("surname")]
        public string surname { get; set; }

        [JsonProperty("serialNo", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("serialNo")]
        public object serialNo { get; set; }

        [JsonProperty("faceImage", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("faceImage")]
        public string faceImage { get; set; }

        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonProperty("landmarks", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("landmarks")]
        public object landmarks { get; set; }

        [JsonProperty("branchName", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("branchName")]
        public object branchName { get; set; }

        [JsonProperty("middleName", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("middleName")]
        public string middleName { get; set; }

        [JsonProperty("nameOnCard", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("nameOnCard")]
        public object nameOnCard { get; set; }

        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("dateOfBirth")]
        public string dateOfBirth { get; set; }

        [JsonProperty("lgaOfOrigin", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lgaOfOrigin")]
        public string lgaOfOrigin { get; set; }

        [JsonProperty("watchlisted", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("watchlisted")]
        public string watchlisted { get; set; }

        [JsonProperty("lgaOfCapture", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lgaOfCapture")]
        public object lgaOfCapture { get; set; }

        [JsonProperty("phoneNumber1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("phoneNumber1")]
        public string phoneNumber1 { get; set; }

        [JsonProperty("phoneNumber2", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("phoneNumber2")]
        public object phoneNumber2 { get; set; }

        [JsonProperty("maritalStatus", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("maritalStatus")]
        public string maritalStatus { get; set; }

        [JsonProperty("stateOfOrigin", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("stateOfOrigin")]
        public string stateOfOrigin { get; set; }

        [JsonProperty("enrollBankCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("enrollBankCode")]
        public object enrollBankCode { get; set; }

        [JsonProperty("enrollUserName", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("enrollUserName")]
        public string enrollUserName { get; set; }

        [JsonProperty("enrollmentDate", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("enrollmentDate")]
        public object enrollmentDate { get; set; }

        [JsonProperty("lgaOfResidence", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("lgaOfResidence")]
        public string lgaOfResidence { get; set; }

        [JsonProperty("stateOfCapture", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("stateOfCapture")]
        public string stateOfCapture { get; set; }

        [JsonProperty("additionalInfo1", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("additionalInfo1")]
        public object additionalInfo1 { get; set; }

        [JsonProperty("productReference", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("productReference")]
        public string productReference { get; set; }

        [JsonProperty("stateOfResidence", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("stateOfResidence")]
        public string stateOfResidence { get; set; }
    }

    public class BVN
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("first_name")]
        public string first_name { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("last_name")]
        public string last_name { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("reference")]
        public string reference { get; set; }

        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("callback_url")]
        public object callback_url { get; set; }

        [JsonProperty("bvn_data", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("bvn_data")]
        public BvnData bvn_data { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }
    }

    //public class BVN
    //{
    //    [JsonProperty("bvn")]
    //    public string Bvn { get; set; }

    //    [JsonProperty("first_name")]
    //    public string FirstName { get; set; }

    //    [JsonProperty("middle_name")]
    //    public string MiddleName { get; set; }

    //    [JsonProperty("last_name")]
    //    public string LastName { get; set; }


    //    [JsonProperty("date_of_birth")]
    //    public DateOnly DateOfBirth { get; set; }

    //    [JsonProperty("phone_number")]
    //    public string PhoneNumber { get; set; }

    //    [JsonProperty("registration_date")]
    //    public string RegistrationDate { get; set; }

    //    [JsonProperty("enrollment_bank")]
    //    public string EnrollmentBank { get; set; }

    //    [JsonProperty("enrollment_branch")]
    //    public string EnrollmentBranch { get; set; }

    //    [JsonProperty("image_base_64")]
    //    public string ImageBase64 { get; set; }

    //    [JsonProperty("address")]
    //    public string Address { get; set; }

    //    [JsonProperty("gender")]
    //    public string Gender { get; set; }

    //    [JsonProperty("email")]
    //    public string Email { get; set; }

    //    [JsonProperty("watch_listed")]
    //    public object WatchListed { get; set; }

    //    [JsonProperty("nationality")]
    //    public string Nationality { get; set; }

    //    [JsonProperty("marital_status")]
    //    public string MaritalStatus { get; set; }

    //    [JsonProperty("state_of_residence")]
    //    public string StateOfResidence { get; set; }

    //    [JsonProperty("lga_of_residence")]
    //    public string LgaOfResidence { get; set; }

    //    [JsonProperty("image")]
    //    public object Image { get; set; }
    //}
}
