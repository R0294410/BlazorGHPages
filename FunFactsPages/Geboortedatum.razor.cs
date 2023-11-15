using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Pages.FunFactsPages
{
    public partial class Geboortedatum
    {
        public DateTime DateOfBirth { get; set; }
        public DateTime CurrentDate { get; set; } = DateTime.Now;

        public void StoreDateBirth()
        {
            var dateBirth = DateOfBirth.ToString();
            Console.WriteLine(dateBirth);
            // Locally store day of birth
            Storage.SetItemAsync("dateOfBirth", dateBirth);
            // Navigate to Funfacts page using NavigateManager
            Navigation.NavigateTo("/funfacts");
        }
    }
}
