using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    [DebuggerDisplay("{Name}:{Id}")]
    public class Plan
    {
        public string odataetag { get; set; }
        public DateTime createdDateTime { get; set; }
        public string owner { get; set; }

        [JsonPropertyName("title")]
        public string Name { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public Createdby createdBy { get; set; }
        public Container container { get; set; }

        public class Createdby
        {
            public User user { get; set; }
            public Application application { get; set; }
        }

        public class User
        {
            public string displayName { get; set; }
            public string id { get; set; }
        }

        public class Application
        {
            public string displayName { get; set; }
            public string id { get; set; }
        }

        public class Container
        {
            public string containerId { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }
    }
}