using System.Text.Json.Serialization;

namespace BlazorApp_R0294410.Models
{
    public class MovieResponse
    {
        [JsonPropertyName("Search")]
        public Movie[]? Search {get; set; }
        [JsonPropertyName("totalResults")]
        public string TotalResult { get; set; }

        [JsonPropertyName("Response")]
        public string Response { get; set; }
    }
}
