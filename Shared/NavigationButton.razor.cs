using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Shared
{
    public partial class NavigationButton
    {
        [Parameter]
        public string Content { get; set; }
        [Parameter]
        public string DestinationUrl { get; set; }

        public void GoToPage()
        {
            Navigation.NavigateTo($"/{DestinationUrl}");
        }
    }
}
