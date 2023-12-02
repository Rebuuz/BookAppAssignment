using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models;

internal class BorrowBook : IBook
{
    //Generell information om boken
    public string Author { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Type { get; set; } = null!;

    //Specifik information om boken
    public string Borrowed { get; set; } = "Borrow Book";
    public string GetProperties()
    {
        return "Det här är en lånebok";
    }
}
