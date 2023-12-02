using ConsoleApp4.Models;

namespace ConsoleApp4.Services;

internal class MenuService
{

    private readonly BookServices _bookServices = new BookServices();
    public void ShowMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("# MENY #");
            Console.WriteLine();
            Console.WriteLine("1. Lägg till ny bok.");
            Console.WriteLine("2. Visa alla böcker.");
            Console.WriteLine("3. Sök på bok.");
            Console.WriteLine("4. Avsluta");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowAddMenu();
                    break;
                case "2":
                    ShowAllMenu();
                    break;
                case "3":
                    SearchBookMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }

    private void ShowAddMenu()
    {
        var book = new Book("title", "author", "isbn", "type");

        Console.Clear();
        Console.Write("Bokens titel: ");
        book.Title = Console.ReadLine()!;
        Console.Write("Författarens namn: ");
        book.Author = Console.ReadLine()!;
        Console.Write("Bokens ISBN: ");
        book.ISBN = Console.ReadLine()!;
        Console.Write("Typ av bok: ");
        book.Type = Console.ReadLine()!;

        _bookServices.AddBook(book);

    }

    private void ShowAllMenu()
    {
        var books = _bookServices.GetBookFromList();

        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} {book.Author} <{book.ISBN}>");
        }
    }

    private void SearchBookMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Sök på ISBN-nummer.");
            Console.WriteLine("2. Sök på typ av bok.");
            Console.WriteLine("3. Gå tillbaka.");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("ISBN: ");
                    string isbnSearch = Console.ReadLine()!;

                    List<Book> foundBooksByISBN = _bookServices.GetBookFromList()
                                                               .Where(book => book.ISBN.Equals(isbnSearch, StringComparison.OrdinalIgnoreCase))
                                                               .ToList();

                    if (foundBooksByISBN.Any())
                    {
                        Console.Clear();
                        Console.WriteLine("Hittad bok: ");
                        foreach (var book in foundBooksByISBN)
                        {
                            Console.WriteLine($"{book.Title} av {book.Author} ISBN {book.ISBN}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Det finns inga böcker med det angivna ISBN-numret.");
                    }
                    break;
                case "2":
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("1. Ljudbok.");
                        Console.WriteLine("2. Lånebok.");
                        Console.WriteLine("3. Till salu.");
                        Console.WriteLine("4. Gå tillbaka.");

                        var options = Console.ReadLine();  
                        switch (options) 
                        {
                            case "1":
                                List<Book> foundBooksByType = _bookServices.GetBooksFromList(options);
                                
                                if (foundBooksByType.Any())
                                {
                                    Console.Clear();
                                    Console.WriteLine("Hittade böcker: ");
                                    foreach (var books in foundBooksByType)
                                    {
                                        Console.WriteLine($"{books.Title} av {books.Author} ISBN: {books.ISBN} Typ: {books.Type}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Det finns inga böcker av den typen.");
                                }
                                break;
                            default:
                                List<Book> foundBooksByTypes = _bookServices.GetBooksFromList(options);
                                Console.WriteLine("hittade inga böcker");
                                break;
                        }
                    }

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
            Console.ReadKey();
        }
       
    }
}
