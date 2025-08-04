using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PteroSharp.NET.Objects.V1_0
{
    
    public class ServerStatusResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public SingleServerAttributes Attributes { get; set; }
    }

    public class SingleServerAttributes
    {
        [JsonPropertyName("server_owner")]
        public bool Server_Owner { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("internal_id")]
        public int Internal_Id { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("is_suspended")]
        public bool Is_Suspended { get; set; }

        [JsonPropertyName("is_installing")]
        public bool Is_Installing { get; set; }

        [JsonPropertyName("is_transferring")]
        public bool Is_Transferring { get; set; }

        [JsonPropertyName("node")]
        public string Node { get; set; }

        [JsonPropertyName("sftp_details")]
        public SftpDetails Sftp_Details { get; set; }

        [JsonPropertyName("invocation")]
        public string Invocation { get; set; }

        [JsonPropertyName("docker_image")]
        public string Docker_Image { get; set; }

        [JsonPropertyName("egg_features")]
        public List<string> Egg_Features { get; set; }

        [JsonPropertyName("feature_limits")]
        public FeatureLimits Feature_Limits { get; set; }

        [JsonPropertyName("user_permissions")]
        public List<string> User_Permissions { get; set; }

        [JsonPropertyName("limits")]
        public Limits Limits { get; set; }
    }

    //public class SftpDetails
    //{
    //    [JsonPropertyName("ip")]
    //    public string Ip { get; set; }

    //    [JsonPropertyName("port")]
    //    public int Port { get; set; }
    //}

    //public class FeatureLimits
    //{
    //    [JsonPropertyName("databases")]
    //    public int Databases { get; set; }

    //    [JsonPropertyName("allocations")]
    //    public int Allocations { get; set; }

    //    [JsonPropertyName("backups")]
    //    public int Backups { get; set; }
    //}

    //public class Limits
    //{
    //    [JsonPropertyName("memory")]
    //    public int Memory { get; set; }

    //    [JsonPropertyName("swap")]
    //    public int Swap { get; set; }

    //    [JsonPropertyName("disk")]
    //    public int Disk { get; set; }

    //    [JsonPropertyName("io")]
    //    public int Io { get; set; }

    //    [JsonPropertyName("cpu")]
    //    public int Cpu { get; set; }

    //    [JsonPropertyName("threads")]
    //    public int? Threads { get; set; }
    //}
}
