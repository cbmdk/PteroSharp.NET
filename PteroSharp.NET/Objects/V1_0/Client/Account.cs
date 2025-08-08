using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using PteroSharp.Models;
using RestSharp;

namespace PteroSharp.Objects.V1_0.Client
{

    [DebuggerDisplay("{" + nameof(Username) + "}")]
    public partial class Account
    {
        private readonly IRestClient _client;

        public Account()
        {
            //_client = PterodactylClient.Instance.HttpClient;
        }


        public int Id { get; set; }

        [JsonProperty("admin")]
        public bool IsAdmin { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Uuid { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        public string Language { get; set; }

        

    }

    public partial class Account2FA
    {

        [JsonProperty("image_url_data")]
        public string ImageUrlData { get; set; }
    }

    public partial class Account2FATokens
    {

        public string[] Tokens { get; set; }

    }
}
