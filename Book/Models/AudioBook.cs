using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models;

public class AudioBook : IBook
{
    //Generell information om boken
    public string Author { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Type { get; set; } = null!;

    //Specifik information om boken
    public string Audiobook { get; set; } = "Audiobook";
    public string GetProperties()
    {
        return "Det här är en ljudbok";
    }
}
