using RestSharp;
using System.Text.RegularExpressions;
using RestSharp.Serializers.NewtonsoftJson;
using PteroSharp.Endpoints.V1_0;

using PteroSharp.Exceptions;

namespace PteroSharp
{
    public class PterodactylClient
    {
        internal RestClient HttpClient { get; set; }

        public static PterodactylClient Instance;
        
        public PterodactylV1_0 V1_0;

        public PterodactylClient(string hostname, string key)
        {
            if (key == null)
            {
                throw new Exception("No keys are provided. Provide at least a Client Key or Application Key");
            }

            if(hostname.Length <= 5)
            {
                throw new PterodactylException("Invalid host name set, Please set one.");
            }

            var regex = new Regex("http(s?)://");
            var host = regex.Match(hostname).Success ? hostname : $"https://{hostname}/";

            HttpClient = new RestClient(host,
                configureSerialization: s => s.UseNewtonsoftJson());
            HttpClient.AddDefaultHeaders(new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {key}" },
                { "Accept", "Application/vnd.pterodactyl.v1+json" }
            });

            V1_0 = new PterodactylV1_0(HttpClient);
            Instance = this;
        }
    }

    public class PterodactylApplication
    {
        internal RestClient HttpClient { get; set; }
        public static PterodactylApplication Instance;

        public PterodactylV1_0 V1_0;

        public PterodactylApplication(string hostname, string key)
        {
            GeneralPtero(hostname, key);
            Instance = this;
        }

        private void GeneralPtero(string hostname, string key)
        {
            if (key == null)
            {
                throw new Exception("No keys are provided. Provide at least a Client Key or Application Key");
            }

            if (hostname.Length <= 5)
            {
                throw new PterodactylException("Invalid host name set, Please set one.");
            }

            var regex = new Regex("http(s?)://");
            var host = regex.Match(hostname).Success ? hostname : $"https://{hostname}/";

            HttpClient = new RestClient(host,
                configureSerialization: s => s.UseNewtonsoftJson());
            HttpClient.AddDefaultHeaders(new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {key}" },
                { "Accept", "Application/vnd.pterodactyl.v1+json" }
            });

            V1_0 = new PterodactylV1_0(HttpClient);
        }
    }
}