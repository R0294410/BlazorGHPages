using BlazorApp_R0294410.Models;
using System.Text.Json;

namespace BlazorApp_R0294410.Pages.Movies
{
    public partial class Movies
    {
        public string SearchTerm { get; set; }
        public Movie[] ListMovies { get; set; }
        public Movie NewMovie { get; set; }
        string apiKey = "9aa2196e";
        HttpRequestMessage request;
        HttpResponseMessage response;
        HttpClient client;
        MovieResponse Response { get; set; }

        public async Task SearchMovie()
        {
            client = new HttpClient();
            // Send Request to API
            request = new HttpRequestMessage()
            {
                // Set HTTP method
                Method = HttpMethod.Get,
                // Set destination of request
                RequestUri = new Uri(@$"https://www.omdbapi.com/?s={SearchTerm}&type=movie&apikey={apiKey}")
            };
            // Send request and receive response
            response = await client.SendAsync(request);
            using Stream stream = await response.Content.ReadAsStreamAsync();
            //stream.Flush();
            Response = await JsonSerializer.DeserializeAsync<MovieResponse>(stream) ;

            ListMovies = Response.Search;
            StateHasChanged();

        }
    }
}
