using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.NET.Objects.V1_0.Client
{
    // Fixed: Data should be a List<EggData>, not a single EggData
    public class EggListResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<EggData> Data { get; set; }  // Changed from EggData to List<EggData>
    }

    public class EggData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public EggAttributes Attributes { get; set; }
    }

    public class EggAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nest")]
        public int Nest { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("docker_image")]
        public string docker_image { get; set; }

        [JsonPropertyName("config")]
        public EggConfig Config { get; set; }

        [JsonPropertyName("startup")]
        public string Startup { get; set; }

        [JsonPropertyName("script")]
        public EggScript Script { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public EggRelationships Relationships { get; set; }
    }

    public class EggConfig
    {
        [JsonPropertyName("files")]
        public Dictionary<string, ConfigFile> Files { get; set; }

        [JsonPropertyName("startup")]
        public StartupConfig Startup { get; set; }

        [JsonPropertyName("stop")]
        public string Stop { get; set; }

        [JsonPropertyName("logs")]
        public object Logs { get; set; }  // Changed to object to handle both array and object cases

        [JsonPropertyName("extends")]
        public object Extends { get; set; }
    }

    public class ConfigFile
    {
        [JsonPropertyName("parser")]
        public string Parser { get; set; }

        [JsonPropertyName("find")]
        public Dictionary<string, object> Find { get; set; }
    }

    public class StartupConfig
    {
        [JsonPropertyName("done")]
        public string Done { get; set; }

        [JsonPropertyName("userInteraction")]
        public List<string> UserInteraction { get; set; }
    }

    public class LogsConfig
    {
        [JsonPropertyName("custom")]
        public bool? Custom { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }
    }

    public class EggScript
    {
        [JsonPropertyName("privileged")]
        public bool Privileged { get; set; }

        [JsonPropertyName("install")]
        public string Install { get; set; }

        [JsonPropertyName("entry")]
        public string Entry { get; set; }

        [JsonPropertyName("container")]
        public string Container { get; set; }

        [JsonPropertyName("extends")]
        public object Extends { get; set; }
    }

    public class EggRelationships
    {
        [JsonPropertyName("nest")]
        public NestWrapper Nest { get; set; }

        [JsonPropertyName("servers")]
        public ServerListWrapper Servers { get; set; }  // Fixed: Should be ServerListWrapper
    }

    // Fixed: Added proper wrapper for servers list
    public class ServerListWrapper
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<ServerWrapper> Data { get; set; }
    }

    public class NestWrapper
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public NestAttributes Attributes { get; set; }
    }

    public class NestAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }
    }

    public class ServerWrapper
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public EggServerAttributes Attributes { get; set; }
    }

    public class EggServerAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("external_id")]
        public string external_id { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("suspended")]
        public bool Suspended { get; set; }

        [JsonPropertyName("limits")]
        public EggServerLimits Limits { get; set; }

        [JsonPropertyName("feature_limits")]
        public ServerFeatureLimits Feature_Limits { get; set; }

        [JsonPropertyName("user")]
        public int User { get; set; }

        [JsonPropertyName("node")]
        public int Node { get; set; }

        [JsonPropertyName("allocation")]
        public int Allocation { get; set; }

        [JsonPropertyName("nest")]
        public int Nest { get; set; }

        [JsonPropertyName("egg")]
        public int Egg { get; set; }

        [JsonPropertyName("pack")]
        public object Pack { get; set; }

        [JsonPropertyName("container")]
        public ServerContainer Container { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }
    }

    public class EggServerLimits
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

        [JsonPropertyName("threads")]
        public int? Threads { get; set; }
    }

    public class ServerFeatureLimits
    {
        [JsonPropertyName("databases")]
        public int Databases { get; set; }

        [JsonPropertyName("allocations")]
        public int Allocations { get; set; }

        [JsonPropertyName("backups")]
        public int Backups { get; set; }
    }

    public class ServerContainer
    {
        [JsonPropertyName("startup_command")]
        public string startup_command { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("installed")]
        public bool Installed { get; set; }

        [JsonPropertyName("environment")]
        public Dictionary<string, string> Environment { get; set; }
    }
}

// Usage example:
// var response = JsonSerializer.Deserialize<EggListResponse>(jsonString);
// var eggs = response.Data.Select(x => x.Attributes).ToList();