using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PteroSharp.NET.Objects.V1_0
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class ServerDetailResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailAttributes attributes { get; set; }
    }

    public class ServerDetailAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("external_id")]
        public string external_id { get; set; }

        [JsonPropertyName("uuid")]
        public string uuid { get; set; }

        [JsonPropertyName("identifier")]
        public string identifier { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("suspended")]
        public bool suspended { get; set; }

        [JsonPropertyName("limits")]
        public ServerDetailLimits limits { get; set; }

        [JsonPropertyName("feature_limits")]
        public ServerDetailFeatureLimits feature_limits { get; set; }

        [JsonPropertyName("user")]
        public int user { get; set; }

        [JsonPropertyName("node")]
        public int node { get; set; }

        [JsonPropertyName("allocation")]
        public int allocation { get; set; }

        [JsonPropertyName("nest")]
        public int nest { get; set; }

        [JsonPropertyName("egg")]
        public int egg { get; set; }

        [JsonPropertyName("container")]
        public ServerDetailContainer container { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("relationships")]
        public ServerDetailRelationships relationships { get; set; }
    }

    public class ServerDetailLimits
    {
        [JsonPropertyName("memory")]
        public int memory { get; set; }

        [JsonPropertyName("swap")]
        public int swap { get; set; }

        [JsonPropertyName("disk")]
        public int disk { get; set; }

        [JsonPropertyName("io")]
        public int io { get; set; }

        [JsonPropertyName("cpu")]
        public int cpu { get; set; }

        [JsonPropertyName("threads")]
        public int? threads { get; set; }

        [JsonPropertyName("oom_disabled")]
        public bool oom_disabled { get; set; }
    }

    public class ServerDetailFeatureLimits
    {
        [JsonPropertyName("databases")]
        public int databases { get; set; }

        [JsonPropertyName("allocations")]
        public int allocations { get; set; }

        [JsonPropertyName("backups")]
        public int backups { get; set; }
    }

    public class ServerDetailContainer
    {
        [JsonPropertyName("startup_command")]
        public string startup_command { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        [JsonPropertyName("installed")]
        public int installed { get; set; }

        [JsonPropertyName("environment")]
        public Dictionary<string, object> environment { get; set; }
    }

    public class ServerDetailRelationships
    {
        [JsonPropertyName("allocations")]
        public ServerDetailDataList<ServerDetailAllocationData> allocations { get; set; }

        [JsonPropertyName("user")]
        public ServerDetailUserData user { get; set; }

        [JsonPropertyName("subusers")]
        public ServerDetailDataList<object> subusers { get; set; }

        [JsonPropertyName("nest")]
        public ServerDetailNestData nest { get; set; }

        [JsonPropertyName("egg")]
        public ServerDetailEggData egg { get; set; }

        [JsonPropertyName("variables")]
        public ServerDetailDataList<ServerDetailVariableData> variables { get; set; }

        [JsonPropertyName("location")]
        public ServerDetailLocationData location { get; set; }

        [JsonPropertyName("node")]
        public ServerDetailNodeData node { get; set; }

        [JsonPropertyName("databases")]
        public ServerDetailDataList<object> databases { get; set; }
    }

    public class ServerDetailDataList<T>
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<T> data { get; set; }
    }

    public class ServerDetailAllocationData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailAllocationAttributes attributes { get; set; }
    }

    public class ServerDetailAllocationAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("ip")]
        public string ip { get; set; }

        [JsonPropertyName("alias")]
        public string alias { get; set; }

        [JsonPropertyName("port")]
        public int port { get; set; }

        [JsonPropertyName("notes")]
        public string notes { get; set; }

        [JsonPropertyName("assigned")]
        public bool assigned { get; set; }
    }

    public class ServerDetailUserData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailUserAttributes attributes { get; set; }
    }

    public class ServerDetailUserAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("external_id")]
        public string external_id { get; set; }

        [JsonPropertyName("uuid")]
        public string uuid { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("first_name")]
        public string first_name { get; set; }

        [JsonPropertyName("last_name")]
        public string last_name { get; set; }

        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("root_admin")]
        public bool root_admin { get; set; }

        [JsonPropertyName("2fa")]
        public bool _2fa { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }
    }

    public class ServerDetailNestData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailNestAttributes attributes { get; set; }
    }

    public class ServerDetailNestAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("uuid")]
        public string uuid { get; set; }

        [JsonPropertyName("author")]
        public string author { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }
    }

    public class ServerDetailEggData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailEggAttributes attributes { get; set; }
    }

    public class ServerDetailEggAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("uuid")]
        public string uuid { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("nest")]
        public int nest { get; set; }

        [JsonPropertyName("author")]
        public string author { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("docker_image")]
        public string docker_image { get; set; }

        [JsonPropertyName("docker_images")]
        public Dictionary<string, string> docker_images { get; set; }

        [JsonPropertyName("config")]
        public ServerDetailEggConfig config { get; set; }

        [JsonPropertyName("startup")]
        public string startup { get; set; }

        [JsonPropertyName("script")]
        public ServerDetailEggScript script { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }
    }

    public class ServerDetailEggConfig
    {
        [JsonPropertyName("files")]
        public Dictionary<string, ServerDetailFileConfig> files { get; set; }

        [JsonPropertyName("startup")]
        public ServerDetailStartupConfig startup { get; set; }

        [JsonPropertyName("stop")]
        public string stop { get; set; }

        [JsonPropertyName("logs")]
        public List<object> logs { get; set; }

        [JsonPropertyName("file_denylist")]
        public List<object> file_denylist { get; set; }

        [JsonPropertyName("extends")]
        public string extends { get; set; }
    }

    public class ServerDetailFileConfig
    {
        [JsonPropertyName("parser")]
        public string parser { get; set; }

        [JsonPropertyName("find")]
        public Dictionary<string, string> find { get; set; }
    }

    public class ServerDetailStartupConfig
    {
        [JsonPropertyName("done")]
        public string done { get; set; }
    }

    public class ServerDetailEggScript
    {
        [JsonPropertyName("privileged")]
        public bool privileged { get; set; }

        [JsonPropertyName("install")]
        public string install { get; set; }

        [JsonPropertyName("entry")]
        public string entry { get; set; }

        [JsonPropertyName("container")]
        public string container { get; set; }

        [JsonPropertyName("extends")]
        public string extends { get; set; }
    }

    public class ServerDetailVariableData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailVariableAttributes attributes { get; set; }
    }

    public class ServerDetailVariableAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("egg_id")]
        public int egg_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("env_variable")]
        public string env_variable { get; set; }

        [JsonPropertyName("default_value")]
        public string default_value { get; set; }

        [JsonPropertyName("user_viewable")]
        public bool user_viewable { get; set; }

        [JsonPropertyName("user_editable")]
        public bool user_editable { get; set; }

        [JsonPropertyName("rules")]
        public string rules { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonPropertyName("server_value")]
        public string server_value { get; set; }
    }

    public class ServerDetailLocationData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailLocationAttributes attributes { get; set; }
    }

    public class ServerDetailLocationAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("short")]
        public string Short { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }
    }

    public class ServerDetailNodeData
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("attributes")]
        public ServerDetailNodeAttributes attributes { get; set; }
    }

    public class ServerDetailNodeAttributes
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("uuid")]
        public string uuid { get; set; }

        [JsonPropertyName("public")]
        public bool Public { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("location_id")]
        public int location_id { get; set; }

        [JsonPropertyName("fqdn")]
        public string fqdn { get; set; }

        [JsonPropertyName("scheme")]
        public string scheme { get; set; }

        [JsonPropertyName("behind_proxy")]
        public bool behind_proxy { get; set; }

        [JsonPropertyName("maintenance_mode")]
        public bool maintenance_mode { get; set; }

        [JsonPropertyName("memory")]
        public int memory { get; set; }

        [JsonPropertyName("memory_overallocate")]
        public int memory_overallocate { get; set; }

        [JsonPropertyName("disk")]
        public int disk { get; set; }

        [JsonPropertyName("disk_overallocate")]
        public int disk_overallocate { get; set; }

        [JsonPropertyName("upload_size")]
        public int upload_size { get; set; }

        [JsonPropertyName("daemon_listen")]
        public int daemon_listen { get; set; }

        [JsonPropertyName("daemon_sftp")]
        public int daemon_sftp { get; set; }

        [JsonPropertyName("daemon_base")]
        public string daemon_base { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime created_at { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonPropertyName("allocated_resources")]
        public ServerDetailAllocatedResources allocated_resources { get; set; }
    }

    public class ServerDetailAllocatedResources
    {
        [JsonPropertyName("memory")]
        public int memory { get; set; }

        [JsonPropertyName("disk")]
        public int disk { get; set; }
    }
}
