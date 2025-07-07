using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PteroSharp.Models
{
    public class UpdateUserRequest
    {
        public string? Email { get; set; }
        
        public string? Username { get; set; }
        [JsonPropertyName("first_name")]
    public string? first_name { get; set; }
        [JsonPropertyName("last_name")]
    public string? last_name { get; set; }
        public string? Language { get; set; }
        public string? Password { get; set; }
        public bool? Admin { get; set; }
    }
}
