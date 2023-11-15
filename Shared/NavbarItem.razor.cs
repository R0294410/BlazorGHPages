using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Shared
{
    public partial class NavbarItem
    {
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string Url { get; set; }
        [Parameter]
        public string Icon { get; set; }

        public void GoToPage()
        {
            Navigation.NavigateTo(Url);
            StateHasChanged();
        }
    }
}
