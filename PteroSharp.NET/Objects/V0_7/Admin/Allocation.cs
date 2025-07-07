using System.Diagnostics;

using Newtonsoft.Json;

namespace PteroSharp.Objects.V0_7.Admin
{

    [DebuggerDisplay("{" + nameof(IP) + "}")]
    public class Allocation
    {

        public int Id { get; set; }

        public string IP { get; set; }
    
        public string Alias { get; set; }

        public int Port { get; set; }

        [JsonProperty("assigned")]
        public bool IsAssigned { get; set; }

    }
}
