using System.Globalization;

namespace BlazorApp_R0294410.Pages.FunFactsPages
{
    public partial class Funfacts
    {
        public string StoredDate { get; set; }
        public string FullDateBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullCurrentDate { get; set; }
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public double DaysAlive { get; set; }
        public string ExpectedDeathDate { get; set; }
        private CultureInfo CultureInfo { get; set; } = new CultureInfo("nl-be");

        protected override async void OnInitialized()
        {
            StoredDate = await Storage.GetItemAsync<string>("dateOfBirth");
            
            Console.WriteLine(StoredDate);
            if (!DateTime.TryParse(StoredDate, out DateTime date))
                Console.Error.WriteLine("Incorrect date!");
            else
            {
                DateOfBirth = date;
                // Calculate days alive
                int calculatedDays = (int)(CurrentDate - DateOfBirth).TotalDays;
                double expectedRemainingDays = Math.Round((80.3 * 365) - calculatedDays) * 24 * 3600 * 100;
                // Assign values to components
                FullDateBirth = GenerateFullDate(DateOfBirth);
                FullCurrentDate = GenerateFullDate(CurrentDate);
                DaysAlive = calculatedDays;
                ExpectedDeathDate = DateTime.Now.AddMilliseconds(expectedRemainingDays).ToShortDateString();

                StateHasChanged();
            }
        }

        public string GenerateFullDate(DateTime date)
        {
            return $"{CultureInfo.DateTimeFormat.GetDayName(date.DayOfWeek)} {date.ToShortDateString()}";
        }

        public void BackToGeboortedatum()
        {
            Navigation.NavigateTo("/geboortedatum");
        }
    }
}
