using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.NET.Objects.V1_0.Client
{
    public class CreateServerRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("user")]
        public int User { get; set; }

        [JsonPropertyName("egg")]
        public int Egg { get; set; }

        [JsonPropertyName("docker_image")]
        public string docker_image { get; set; }

        [JsonPropertyName("startup")]
        public string Startup { get; set; }

        [JsonPropertyName("limits")]
        public ServerResourceLimits Limits { get; set; }

        [JsonPropertyName("feature_limits")]
        public ServerFeatureLimits feature_limits { get; set; }

        [JsonPropertyName("allocation")]
        public AllocationConfig Allocation { get; set; }

        [JsonPropertyName("environment")]
        //public Dictionary<string, string> Environment { get; set; }
        //public object Environment { get; set; }
        public Dictionary<string, string> environment { get; set; } // or Dictionary<string, object>

    }

    public class ServerResourceLimits
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
        [JsonPropertyName("oom_disabled")]
        public bool Oom_Disabled { get; set; } = false;

    }

    public class ServerFeatureLimits
    {
        [JsonPropertyName("databases")]
        public int Databases { get; set; }

        [JsonPropertyName("backups")]
        public int Backups { get; set; }

        [JsonPropertyName("allocations")]
        public int Allocations { get; set; }
    }

    public class AllocationConfig
    {
        [JsonPropertyName("default")]
        public int Default { get; set; }
    }
    //public class CreateServerRequest
    //{
    //    [Required]
    //    [JsonPropertyName("name")]
    //    public string Name { get; set; } = string.Empty;

    //    [JsonPropertyName("description")]
    //    public string? Description { get; set; }

    //    [Required]
    //    [JsonPropertyName("user")]
    //    public int User { get; set; }

    //    [Required]
    //    [JsonPropertyName("egg")]
    //    public int Egg { get; set; }

    //    [Required]
    //    [JsonPropertyName("docker_image")]
    //    public string docker_image { get; set; } = string.Empty;

    //    [Required]
    //    [JsonPropertyName("startup")]
    //    public string Startup { get; set; } = string.Empty;

    //    [Required]
    //    [JsonPropertyName("environment")]
    //    public Environment Environment { get; set; } = new();

    //    [Required]
    //    [JsonPropertyName("limits")]
    //    public ServerLimits Limits { get; set; } = new();

    //    [JsonPropertyName("feature_limits")]
    //    public FeatureLimits? feature_limits { get; set; }

    //    [Required]
    //    [JsonPropertyName("allocation")]
    //    public AllocationConfig Allocation { get; set; } = new();

    //    [JsonPropertyName("deploy")]
    //    public DeployConfig? Deploy { get; set; }

    //    [JsonPropertyName("start_on_completion")]
    //    public bool StartOnCompletion { get; set; } = true;

    //    [JsonPropertyName("skip_scripts")]
    //    public bool SkipScripts { get; set; } = false;

    //    [JsonPropertyName("oom_disabled")]
    //    public bool OomDisabled { get; set; } = false;
    //}

    //public class Environment{
    //    public string server_jarfile { get; set; }
    //    public string build_number { get; set; }
    //}
    //public class ServerLimits
    //{
    //    [Required]
    //    [JsonPropertyName("memory")]
    //    public int Memory { get; set; }

    //    [JsonPropertyName("swap")]
    //    public int Swap { get; set; } = 0;

    //    [Required]
    //    [JsonPropertyName("disk")]
    //    public int Disk { get; set; }

    //    [JsonPropertyName("io")]
    //    public int Io { get; set; } = 500;

    //    [JsonPropertyName("cpu")]
    //    public int Cpu { get; set; } = 100;
    //}

    //public class FeatureLimits
    //{
    //    [JsonPropertyName("databases")]
    //    public int? Databases { get; set; }

    //    [JsonPropertyName("allocations")]
    //    public int? Allocations { get; set; }

    //    [JsonPropertyName("backups")]
    //    public int? Backups { get; set; }
    //}

    //public class AllocationConfig
    //{
    //    [Required]
    //    [JsonPropertyName("default")]
    //    public int Default { get; set; }
    //}

    //public class DeployConfig
    //{
    //    [JsonPropertyName("locations")]
    //    public List<int>? Locations { get; set; }

    //    [JsonPropertyName("dedicated_ip")]
    //    public bool DedicatedIp { get; set; } = false;

    //    [JsonPropertyName("port_range")]
    //    public List<string>? PortRange { get; set; }
    //}

    //// Response model for created server
    //public class ServerResponse
    //{
    //    [JsonPropertyName("object")]
    //    public string Object { get; set; } = string.Empty;

    //    [JsonPropertyName("attributes")]
    //    public ServerAttributes Attributes { get; set; } = new();
    //}

    //public class ServerAttributes
    //{
    //    [JsonPropertyName("id")]
    //    public int Id { get; set; }

    //    [JsonPropertyName("external_id")]
    //    public string? ExternalId { get; set; }

    //    [JsonPropertyName("uuid")]
    //    public string Uuid { get; set; } = string.Empty;

    //    [JsonPropertyName("identifier")]
    //    public string Identifier { get; set; } = string.Empty;

    //    [JsonPropertyName("name")]
    //    public string Name { get; set; } = string.Empty;

    //    [JsonPropertyName("description")]
    //    public string? Description { get; set; }

    //    [JsonPropertyName("status")]
    //    public string? Status { get; set; }

    //    [JsonPropertyName("suspended")]
    //    public bool Suspended { get; set; }

    //    [JsonPropertyName("limits")]
    //    public ServerLimits Limits { get; set; } = new();

    //    [JsonPropertyName("feature_limits")]
    //    public FeatureLimits FeatureLimits { get; set; } = new();

    //    [JsonPropertyName("user")]
    //    public int User { get; set; }

    //    [JsonPropertyName("node")]
    //    public int Node { get; set; }

    //    [JsonPropertyName("allocation")]
    //    public int Allocation { get; set; }

    //    [JsonPropertyName("nest")]
    //    public int Nest { get; set; }

    //    [JsonPropertyName("egg")]
    //    public int Egg { get; set; }

    //    [JsonPropertyName("container")]
    //    public ContainerInfo Container { get; set; } = new();

    //    [JsonPropertyName("created_at")]
    //    public DateTime CreatedAt { get; set; }

    //    [JsonPropertyName("updated_at")]
    //    public DateTime UpdatedAt { get; set; }
    //}

    //public class ContainerInfo
    //{
    //    [JsonPropertyName("startup_command")]
    //    public string StartupCommand { get; set; } = string.Empty;

    //    [JsonPropertyName("image")]
    //    public string Image { get; set; } = string.Empty;

    //    [JsonPropertyName("installed")]
    //    public bool Installed { get; set; }

    //    [JsonPropertyName("environment")]
    //    public Dictionary<string, string> Environment { get; set; } = new();
    //}

}
