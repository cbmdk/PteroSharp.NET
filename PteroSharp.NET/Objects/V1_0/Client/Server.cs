using Newtonsoft.Json;

namespace PteroSharp.Objects.V1_0.Client
{
    public class Server
    {
        
        [JsonProperty("server_owner")]
        public bool IsOwner { get; set; }

    }

}
