using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.NET.Models
{
    public class AllocationResponse
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("data")]
        public List<AllocationItem> Data { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class AllocationItem
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

        [JsonPropertyName("alias")]
        public string? Alias { get; set; }

        [JsonPropertyName("port")]
        public int Port { get; set; }

        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        [JsonPropertyName("assigned")]
        public bool Assigned { get; set; }
    }

    //public class Meta
    //{
    //    [JsonPropertyName("pagination")]
    //    public Pagination Pagination { get; set; }
    //}

    //public class Pagination
    //{
    //    [JsonPropertyName("total")]
    //    public int Total { get; set; }

    //    [JsonPropertyName("count")]
    //    public int Count { get; set; }

    //    [JsonPropertyName("per_page")]
    //    public int PerPage { get; set; }

    //    [JsonPropertyName("current_page")]
    //    public int CurrentPage { get; set; }

    //    [JsonPropertyName("total_pages")]
    //    public int TotalPages { get; set; }

    //    [JsonPropertyName("links")]
    //    public Dictionary<string, object> Links { get; set; }
    //}
}
