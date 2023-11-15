using System.Text.Json.Serialization;

namespace BlazorApp_R0294410.Models
{
    public class Movie
    {
        [JsonPropertyName("Title")]
        public string Title { get; set; }
        [JsonPropertyName("Year")]
        public string Year { get; set; }
        [JsonPropertyName("imdbID")]
        public string ImdbID { get; set; }
        [JsonPropertyName("Type")]
        public string MovieType { get; set; }
        [JsonPropertyName("Poster")]
        public string Poster { get; set; }

    }
}
