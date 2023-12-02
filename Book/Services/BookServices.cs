using ConsoleApp4.Models;

namespace ConsoleApp4.Services;

internal class BookServices
{
    private readonly List<Book> _books = [];

    public void AddBook(Book book)
    {
        if (! _books.Any(x => x.ISBN == book.ISBN))
        {
            _books.Add(book);
            Console.WriteLine("Boken är tillagd.");
        }
        else
        {
            Console.WriteLine("En bok med det här ISBN-numret finns redan.");
        }
   
    }

    //Listar boken med rätt ISBN
    public Book GetBookFromList(string isbn)
    {
        var book = _books.FirstOrDefault(x => x.ISBN == isbn);
        return book ??= null!;

    }

    //Listar alla böcker av samma typ av bok
    public List<Book> GetBooksFromList(string type)
    {
        var books = _books.Where(book => book.Type.Equals(type, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return books;

    }

    public List<Book> GetBookFromList()
    {
        return _books;
    }
}
