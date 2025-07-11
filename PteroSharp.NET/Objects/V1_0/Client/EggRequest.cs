using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.NET.Objects.V1_0.Client
{
    // Fixed: Data should be a List<EggData>, not a single EggData
    public class EggListResonse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<EggData>Data { get; set; }
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

        [JsonPropertyName("docker_images")]
        public Dictionary<string, string> DockerImages { get; set; }

        [JsonPropertyName("config")]
        public EggConfig Config { get; set; }

        [JsonPropertyName("startup")]
        public string Startup { get; set; }

        [JsonPropertyName("script")]
        public InstallScript Script { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("relationships")]
        public EggRelationships Relationships { get; set; }
    }

    public class EggConfig
    {
        [JsonPropertyName("files")]
        public Dictionary<string, FileConfig> Files { get; set; }

        [JsonPropertyName("startup")]
        public StartupConfig Startup { get; set; }

        [JsonPropertyName("stop")]
        public string Stop { get; set; }

        [JsonPropertyName("logs")]
        public List<object> Logs { get; set; }

        [JsonPropertyName("file_denylist")]
        public List<object> FileDenylist { get; set; }

        [JsonPropertyName("extends")]
        public object Extends { get; set; }
    }

    public class FileConfig
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
    }

    public class InstallScript
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
        public NestRelation Nest { get; set; }

        [JsonPropertyName("servers")]
        public ServerListRelation Servers { get; set; }

        [JsonPropertyName("config")]
        public ConfigRelation Config { get; set; }

        [JsonPropertyName("variables")]
        public VariableListRelation Variables { get; set; }
    }

    public class NestRelation
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
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class ServerListRelation
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<Server> Data { get; set; }
    }

    public class Server
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerAttributes Attributes { get; set; }
    }

    public class ServerAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("external_id")]
        public object ExternalId { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("suspended")]
        public bool Suspended { get; set; }

        [JsonPropertyName("limits")]
        public ServerLimits Limits { get; set; }

        [JsonPropertyName("feature_limits")]
        public FeatureLimits FeatureLimits { get; set; }

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

        [JsonPropertyName("container")]
        public Container Container { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class ServerLimits
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
        public object Threads { get; set; }

        [JsonPropertyName("oom_disabled")]
        public bool OomDisabled { get; set; }
    }

    public class FeatureLimits
    {
        [JsonPropertyName("databases")]
        public int Databases { get; set; }

        [JsonPropertyName("allocations")]
        public int Allocations { get; set; }

        [JsonPropertyName("backups")]
        public int Backups { get; set; }
    }

    public class Container
    {
        [JsonPropertyName("startup_command")]
        public string StartupCommand { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("installed")]
        public int Installed { get; set; }

        [JsonPropertyName("environment")]
        public Dictionary<string, string> Environment { get; set; }
    }

    public class ConfigRelation
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public object Attributes { get; set; }
    }

    public class VariableListRelation
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<EggVariable> Data { get; set; }
    }

    public class EggVariable
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public EggVariableAttributes Attributes { get; set; }
    }

    public class EggVariableAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("egg_id")]
        public int EggId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("env_variable")]
        public string EnvVariable { get; set; }

        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        [JsonPropertyName("user_viewable")]
        public bool UserViewable { get; set; }

        [JsonPropertyName("user_editable")]
        public bool UserEditable { get; set; }

        [JsonPropertyName("rules")]
        public string Rules { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

// Usage example:
// var response = JsonSerializer.Deserialize<EggListResponse>(jsonString);
// var eggs = response.Data.Select(x => x.Attributes).ToList();