using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    public class TaskDetails
    {
        [JsonPropertyName("@odata.context")]
        public string Context { get; set; }

        [JsonPropertyName("@odata.etag")]
        public string Etag { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        public string previewType { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public References references { get; set; }

        [JsonConverter(typeof(Conv))]
        [JsonPropertyName("checklist")]
        public Dictionary<string, CheckListItem> Checklist { get; set; }


        public class References
        {
        }

        [DebuggerDisplay("{Name}")]
        public class CheckListItem
        {
            public string odatatype { get; set; }
            public bool isChecked { get; set; }
            
            [JsonPropertyName("title")]
            public string Name { get; set; }
            public string orderHint { get; set; }
            public DateTime lastModifiedDateTime { get; set; }
            public User lastModifiedBy { get; set; }
        }

        [DebuggerDisplay("{Name}:{Id}")]
        public class User
        {
            [JsonPropertyName("displayName")]
            public string Name { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }
        }
    }

}