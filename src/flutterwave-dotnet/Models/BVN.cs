using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flutterwave.Net
{
    
    public class BVN
    {
        [JsonProperty("bvn")]
        public string Bvn { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }

        [JsonProperty("enrollment_bank")]
        public string EnrollmentBank { get; set; }

        [JsonProperty("enrollment_branch")]
        public string EnrollmentBranch { get; set; }

        [JsonProperty("image_base_64")]
        public object ImageBase64 { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("watch_listed")]
        public object WatchListed { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("marital_status")]
        public object MaritalStatus { get; set; }

        [JsonProperty("state_of_residence")]
        public object StateOfResidence { get; set; }

        [JsonProperty("lga_of_residence")]
        public object LgaOfResidence { get; set; }

        [JsonProperty("image")]
        public object Image { get; set; }
    }
}
