using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PteroSharp.NET.Objects.V1_0
{
    using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ApiResponse<T>
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("data")]
    public List<T> Data { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
}

public class ServerResponse
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("attributes")]
    public ServerAttributes Attributes { get; set; }
}

public class ServerAttributes
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

    [JsonPropertyName("relationships")]
    public Relationships Relationships { get; set; }
}

public class SftpDetails
{
    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    [JsonPropertyName("port")]
    public int Port { get; set; }
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

public class Limits
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

public class Relationships
{
    [JsonPropertyName("allocations")]
    public ApiResponse<AllocationResponse> Allocations { get; set; }

    [JsonPropertyName("variables")]
    public ApiResponse<VariableResponse> Variables { get; set; }
}

public class AllocationResponse
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("attributes")]
    public AllocationAttributes Attributes { get; set; }
}

public class AllocationAttributes
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("ip")]
    public string Ip { get; set; }

    [JsonPropertyName("ip_alias")]
    public string Ip_Alias { get; set; }

    [JsonPropertyName("port")]
    public int Port { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; }

    [JsonPropertyName("is_default")]
    public bool Is_Default { get; set; }
}

public class VariableResponse
{
    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("attributes")]
    public VariableAttributes Attributes { get; set; }
}

public class VariableAttributes
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("env_variable")]
    public string Env_Variable { get; set; }

    [JsonPropertyName("default_value")]
    public string Default_Value { get; set; }

    [JsonPropertyName("server_value")]
    public string Server_Value { get; set; }

    [JsonPropertyName("is_editable")]
    public bool Is_Editable { get; set; }

    [JsonPropertyName("rules")]
    public string Rules { get; set; }
}

public class Meta
{
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; set; }
}

public class Pagination
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("per_page")]
    public int Per_Page { get; set; }

    [JsonPropertyName("current_page")]
    public int Current_Page { get; set; }

    [JsonPropertyName("total_pages")]
    public int Total_Pages { get; set; }

    [JsonPropertyName("links")]
    public Dictionary<string, object> Links { get; set; }
}
}
