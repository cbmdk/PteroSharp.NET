using Newtonsoft.Json;

namespace PteroSharp.Objects.V0_7.Admin.Options
{
    public class DatabaseOptions
    {

        [JsonProperty("database")]
        public string DatabaseName { get; set; }

        public string Remote { get; set; }

        public string Host { get; set; }

    }
}
