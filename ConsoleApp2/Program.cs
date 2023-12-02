using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Shoppingrundan: ");
        List<string> list = new List<string>();

        list.Add("Smör");
        list.Add("Bröd");
        list.Add("Mjölk");
        list.Add("Bananer");
        list.Add("Glass");
        list.Add("Toapapper");
        list.Add("Kattmat");
        list.Add("Ost");
        list.Add("Diskmedel");
        list.Add("Dricka");
        list.Add("Grönsaker");

        List<string> shoppingCart = new List<string>();

        Console.WriteLine("Tillgängliga varor: ");
        
        foreach (string item in list) 
        {
            Console.WriteLine($" - {item}");
        }

        bool shopping = true;

        while (shopping)
        {
            Console.WriteLine("Skriv vilka varor du vill handla. Vill du handla alltihop, skriv 'All'. Vill du avsluta, skriv 'Klar'.");
            string cart = Console.ReadLine()!;

            if (cart == "Klar" || cart == "klar")
            {
                shopping = false;
            }

            else if (list.Contains(cart))
            {
                shoppingCart.Add(cart);
                Console.WriteLine(cart + " har lagts till i din shoppingvagn!");
            }
            else if (cart == "all" || cart == "All") 
            {
                shoppingCart.AddRange(list);
                Console.WriteLine("Allt har lagts till i din kundkorg.");
                shopping = false;
            }
            else
            {
                Console.WriteLine("Produkten existerar inte, välj en annan från listan ovan!");
            }
        }

        Console.WriteLine("Du har valt följande varor: ");
        foreach(string item in shoppingCart)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine("Välkommen att handla någon mer gång!");
        Console.ReadKey();

        
    }
}



