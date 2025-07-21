using OOPAdventure;
namespace oop_adventure
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello What is your name: ");
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
