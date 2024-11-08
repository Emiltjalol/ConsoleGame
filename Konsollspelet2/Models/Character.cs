namespace Konsollspelet2;

public class Character
{
    public string Name { get; set; }
    public int Hunger { get; set; } = 100;
    public int X { get; set; }
    public int  Y { get; set; }
    

    public Character(string name)
    {
        Name = name;
    }

    public static Character CreateCharacter()
    {
        Console.WriteLine("Välj ett namn på din karaktär");
        string name = Console.ReadLine();
        return new Character(name);
    }
}