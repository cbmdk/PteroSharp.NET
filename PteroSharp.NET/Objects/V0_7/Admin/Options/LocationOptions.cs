using Newtonsoft.Json;

namespace PteroSharp.Objects.V0_7.Admin.Options
{
    public class LocationOptions
    {

        [JsonProperty("short")]
        public string ShortCode { get; set; }

        [JsonProperty("long")]
        public string Description { get; set; }

    }
}
