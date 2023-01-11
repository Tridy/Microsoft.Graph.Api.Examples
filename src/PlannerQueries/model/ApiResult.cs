using System.Numerics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    public class ApiResult<T>
    {
        [JsonPropertyName("@odata.context")]
        public string Context { get; set; }
        public int odatacount { get; set; }

        [JsonPropertyName("value")]
        public T[] Items { get; set; }
    }
}