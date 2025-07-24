using oop_adventure.src.Characters;
using OOPAdventure;
namespace oop_adventure
{
     class Program
    {
        static void Main(string[] args)
        {
            var language = new English();
            Console.Write(language.ChooseYourName);
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "NoName";
            }

            var player = new Player(name);
            Console.Write($"Hello, {player.Name}");

            

        }
    }
}
