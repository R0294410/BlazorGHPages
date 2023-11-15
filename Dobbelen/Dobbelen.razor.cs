using BlazorApp_R0294410.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp_R0294410.Pages.Dobbelen
{
    public partial class Dobbelen
    {
        public List<Player> Players { get; set; }
        public string Result { get; set; }
        public int GuessedSixes { get; set; }

        protected override async void OnInitialized()
        {
            Players = new List<Player>();
            for(int i = 1; i <= 12; i++)
            {
                Players.Add(new Player
                {
                    Name = $"Speler {i}",
                    Color = "card text-white bg-secondary"
                });
            }
        }

        public void Reset()
        {
            foreach (var player in Players)
            {
                player.Color = "card text-white bg-secondary";
            }
            Result = "";
            GuessedSixes = 0;

            StateHasChanged();
        }

        public void RollDice()
        {
            int nrSixes = 0;
            int random;
            foreach (var  player in Players)
            {
                random = new Random().Next(1, 7);
                if (random == 6)
                {
                    player.Color = "card text-white bg-success";
                    nrSixes++;
                }
                Console.WriteLine(random);
            }
            if (nrSixes == GuessedSixes)
                Result = $"{nrSixes.ToString()} speler(s) rolde een 6. Gewonnen! Juist geraden.";
            else
                Result += $"Oeps. {nrSixes.ToString()} speler(s) rolde een 6. Probeer nog eens...";
            StateHasChanged();
        }
    }
}
