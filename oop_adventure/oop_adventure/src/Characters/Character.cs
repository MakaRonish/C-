namespace oop_adventure.src.Characters;

public abstract class Character
{
    public string Name {  get; set; }
    public Character(string name)
    {
        Name = name;
    }
}
