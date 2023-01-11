using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    [DebuggerDisplay("{Name}:{Id}")]
    public class Bucket
    {
        public string odataetag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
        public string planId { get; set; }
        public string orderHint { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}