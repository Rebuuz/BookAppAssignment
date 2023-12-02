namespace ConsoleApp4.Interfaces;

public interface IBook
{
    string Author { get; set; }
    string ISBN { get; set; }
    string Title { get; set; }
    string Type { get; set; }

    string GetProperties();
}