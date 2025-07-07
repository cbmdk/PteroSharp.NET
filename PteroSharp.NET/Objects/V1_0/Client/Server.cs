using Newtonsoft.Json;
using PteroSharp.Objects.V0_7.Admin;
using System.Text.Json.Serialization;

namespace PteroSharp.Objects.V1_0.Client
{
    public class Server
    {
        
        [JsonProperty("server_owner")]
        public bool IsOwner { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("user")]
        public int User { get; set; }

        [JsonPropertyName("egg")]
        public int Egg { get; set; }

        [JsonPropertyName("docker_image")]
        public string docker_image { get; set; } = string.Empty;

        [JsonPropertyName("startup")]
        public string Startup { get; set; } = string.Empty;

        [JsonPropertyName("environment")]
        public Dictionary<string, string> Environment { get; set; } = new();

        [JsonPropertyName("limits")]
        public ResourceLimits Limits { get; set; } = new();

        [JsonPropertyName("feature_limits")]
        public FeatureLimits feature_limits { get; set; } = new();

        [JsonPropertyName("allocation")]
        public Allocation Allocation { get; set; } = new();
    }

    public class ResourceLimits
    {
        [JsonPropertyName("memory")]
        public int Memory { get; set; }

        [JsonPropertyName("swap")]
        public int Swap { get; set; }

        [JsonPropertyName("disk")]
        public int Disk { get; set; }

        [JsonPropertyName("io")]
        public int Io { get; set; }

        [JsonPropertyName("cpu")]
        public int Cpu { get; set; }
    }

    public class FeatureLimits
    {
        [JsonPropertyName("databases")]
        public int Databases { get; set; }

        [JsonPropertyName("backups")]
        public int Backups { get; set; }
    }

    public class Allocation
    {
        [JsonPropertyName("default")]
        public int Default { get; set; }
    }

}
