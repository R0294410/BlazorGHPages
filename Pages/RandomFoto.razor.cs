namespace BlazorApp_R0294410.Pages
{
    public partial class RandomFoto
    {
        string[] images = { "breakfast.jpg", "flower.jpg", "flower_red.jpg", "fontain.jpg", "lunch.jpg", "sunset.jpg" };
        int random = new Random().Next(0, 5);
        string imgSource;

        public void GenerateFoto()
        {
            Console.WriteLine("Loaded");
            Console.WriteLine(imgSource);
        }

        public void DisplayFoto()
        {
            Console.WriteLine("Clicked");
            Console.WriteLine(imgSource);
            int newRandom;
            do
            {
                newRandom = new Random().Next(0, 5);
            } while (newRandom == random);
            random = newRandom;
            imgSource = "/img/" + images[random];
        }
    }
}
