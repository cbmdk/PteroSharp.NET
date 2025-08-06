using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace PteroSharp.NET.Objects.V1_0
{
    

    public class CreateServerResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public CreateServerAttributes Attributes { get; set; }
    }

    public class CreateServerAttributes
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("external_id")]
        public string External_Id { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("suspended")]
        public bool Suspended { get; set; }

        [JsonPropertyName("limits")]
        public ServerLimits Limits { get; set; }

        [JsonPropertyName("feature_limits")]
        public CreateFeatureLimits Feature_Limits { get; set; }

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
        public DateTime Updated_At { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime Created_At { get; set; }
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
        public int? Threads { get; set; }

        [JsonPropertyName("oom_disabled")]
        public bool Oom_Disabled { get; set; }
    }

    public class CreateFeatureLimits
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
        public string Startup_Command { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("installed")]
        public int Installed { get; set; }

        [JsonPropertyName("environment")]
        public Dictionary<string, string> Environment { get; set; }
    }

    // Alternative: If you prefer strong typing for environment variables
    public class ContainerEnvironment
    {
        [JsonPropertyName("SERVER_JARFILE")]
        public string Server_JarFile { get; set; }

        [JsonPropertyName("VANILLA_VERSION")]
        public string Vanilla_Version { get; set; }

        [JsonPropertyName("STARTUP")]
        public string Startup { get; set; }

        [JsonPropertyName("P_SERVER_LOCATION")]
        public string P_Server_Location { get; set; }

        [JsonPropertyName("P_SERVER_UUID")]
        public string P_Server_Uuid { get; set; }

        [JsonPropertyName("P_SERVER_ALLOCATION_LIMIT")]
        public int P_Server_Allocation_Limit { get; set; }
    }

    // If you want to use the strongly typed environment instead of Dictionary
    public class ContainerWithTypedEnvironment
    {
        [JsonPropertyName("startup_command")]
        public string Startup_Command { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("installed")]
        public int Installed { get; set; }

        [JsonPropertyName("environment")]
        public ContainerEnvironment Environment { get; set; }
    }
}
