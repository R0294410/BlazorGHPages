using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Pages.Movies
{
    public partial class MovieComponent
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public string Poster { get;set; }
        [Parameter]
        public string Year { get; set; }
    }
}
