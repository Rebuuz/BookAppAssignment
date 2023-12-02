using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> toDoList = new List<string>();
        string options;

        do
        {
            Console.Clear();
            Console.WriteLine("Gör en To-Do-lista!");
            Console.WriteLine("Välj något av valen nedan:");
            Console.WriteLine("1. Lägg till i listan.");
            Console.WriteLine("2. Se listan.");
            Console.WriteLine("3. Klar.");
            Console.WriteLine("4. Avsluta.");
            
            options = Console.ReadLine()!;

            switch (options)
            {
                case "1":
                    Console.Write("Lägg till: ");
                    string addToDo = Console.ReadLine()!;
                    toDoList.Add(addToDo);
                    Console.WriteLine($"{addToDo} är tillagd.");
                    Console.ReadLine();
                    break;
                case "2": 
                    Console.WriteLine("Att göra idag: ");
                    foreach (string item in toDoList)
                    {
                        Console.WriteLine($"- {item}");
                    }
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Känner du att du är klar med listan?");
                    Console.WriteLine("Tryck 4 för att avsluta eller tryck 3 för att fortsätta");
                    string newOption = Console.ReadLine()!;
                    if (newOption == "4")
                    {
                        Environment.Exit(0);
                    }
                    else if (newOption != "3")
                    {
                        Console.WriteLine("Vänligen välj 4 för att avsluta eller 3 för att fortsätta göra listan.");
                        Console.ReadLine();
                    }
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, välj något annat alternativ.");
                    break;
            }
        }
        while (true);

    }

}
