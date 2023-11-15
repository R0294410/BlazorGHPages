using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Shared
{
    public partial class Navbar
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
