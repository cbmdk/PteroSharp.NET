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
        public AlloMeta Meta { get; set; }
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

    public class AlloMeta
    {
        [JsonPropertyName("pagination")]
        public AlloPagination Pagination { get; set; }
    }

    public class AlloPagination
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
