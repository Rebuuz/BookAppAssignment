
Console.Write("Skriv ditt förnamn: ");
string firstname = Console.ReadLine()!;

Console.WriteLine("Hej " + firstname + ",välkommen hit! Vi kommer samla in lite mer information från dig :)!");

Console.Write("Skriv ditt efternamn: ");
string lastname = Console.ReadLine()!;

Console.Write("Ange ålder: ");
int.TryParse(Console.ReadLine()!, out int age);

int date = DateTime.Now.Year - age;

Console.Write("Ange stad: ");
string city = Console.ReadLine()!;

string capitalizedCity = char.ToUpper(city[0]) + city.Substring(1);

Console.Clear();
Console.WriteLine($"Hej {firstname} {lastname}, du är {age} år gammal och bor i {capitalizedCity}. Du är född {date}. ");
Console.ReadKey();