using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.NET.Models
{
    public class ServerVariablesResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; } = string.Empty;

        [JsonPropertyName("data")]
        public List<EggVariable> Data { get; set; } = new List<EggVariable>();

        [JsonPropertyName("meta")]
        public VariablesMeta Meta { get; set; } = new VariablesMeta();
    }

    public class EggVariable
    {
        [JsonPropertyName("object")]
        public string Object { get; set; } = string.Empty;

        [JsonPropertyName("attributes")]
        public EggVariableAttributes Attributes { get; set; } = new EggVariableAttributes();
    }

    public class EggVariableAttributes
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("env_variable")]
        public string EnvVariable { get; set; } = string.Empty;

        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; } = string.Empty;

        [JsonPropertyName("server_value")]
        public string ServerValue { get; set; } = string.Empty;

        [JsonPropertyName("is_editable")]
        public bool IsEditable { get; set; }

        [JsonPropertyName("rules")]
        public string Rules { get; set; } = string.Empty;
    }

    public class VariablesMeta
    {
        [JsonPropertyName("startup_command")]
        public string StartupCommand { get; set; } = string.Empty;

        [JsonPropertyName("raw_startup_command")]
        public string RawStartupCommand { get; set; } = string.Empty;
    }
}
