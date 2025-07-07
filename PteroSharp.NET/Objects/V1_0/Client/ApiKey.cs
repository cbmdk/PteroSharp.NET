using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace PteroSharp.Objects.V1_0.Client
{
    public class ApiKey
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ApiKeyAttributes Attributes { get; set; }

        [JsonPropertyName("meta")]
        public ApiKeyMeta Meta { get; set; }
    }

    public class ApiKeyAttributes
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("allowed_ips")]
        public List<string> AllowedIps { get; set; }

        [JsonPropertyName("last_used_at")]
        public DateTime? LastUsedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class ApiKeyMeta
    {
        [JsonPropertyName("secret_token")]
        public string SecretToken { get; set; }
    }
    public class ApiKey2
    {

        public string Identifier { get; set; }
        
        public string Description { get; set; }

        public string[] AllowedIps { get; set; }

        [JsonProperty("last_used_at")]
        public DateTime LastUsedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        public Meta Token { get; set; }

    }

    public class Meta
    {
        public string Secret_token { get; set; }
    }
}
