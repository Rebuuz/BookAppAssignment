

using ConsoleApp4.Interfaces;

namespace ConsoleApp4.Models;

internal class BuyBook : IBook
{
    //Generell information om boken
    public string Author { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Type { get; set; } = null!;
    
    //Specifik information om boken
    public string Buyable { get; set; } = "Book for sell";
    public string GetProperties()
    {
        return "Det här är boken är till salu.";
    }
}
