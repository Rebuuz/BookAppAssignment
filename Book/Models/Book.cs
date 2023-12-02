
using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models;

public class Book : IBook
{
    //Lägger till frågetecken så att säga att värdet kan vara nullable
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string ISBN { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string GetProperties()
    {
        return "";
    }

    //Konstruktor för att sätta in värden
    public Book(string title, string author, string isbn, string type)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Type = type;
    }
}
