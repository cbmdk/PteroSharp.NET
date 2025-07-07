using Newtonsoft.Json;
using PteroSharp.Objects.Components;
using PteroSharp.Objects.V0_7.Client.ServerAttributes;

namespace PteroSharp.Objects.V0_7.Admin.Options
{
    public class ServerOptions
    {

        public string Name { get; set; }

        [JsonProperty("user")]
        public int UserId { get; set; }

        [JsonProperty("egg")]
        public int EggId { get; set; }

        [JsonProperty("docker_image")]
        public string DockerImage { get; set; }

        public Limits Limits { get; set; }

        [JsonProperty("feature_limits")]
        public ServerFeatureLimits FeatureLimits { get; set; }

    }
}