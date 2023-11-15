using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Pages.Dobbelen
{
    public partial class PlayerComponent
    {
        [Parameter]
        public string Name { get; set; }
        [Parameter]
        public string Color { get; set; }
    }
}
