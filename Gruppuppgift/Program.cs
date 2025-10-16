using System;
using System.Collections.Generic;
class Program
{
    static List<string> inventory = new List<string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
        
        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Visa inventarie");
            Console.WriteLine("3. Avsluta");
            Console.WriteLine("Ange ditt val (1-3): ");

            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    LäggTillProdukt();
                    break;
                case "2":
                    VisaInventarie();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    static void LäggTillProdukt()
    {
        // TODO: Implementera metod för att lägga till produkt
        Console.Clear();
        Console.WriteLine("---LÄGG TILL PRODUKT---\n");
        Console.Write("Skriv in vad du vill lägga till för produkt: ");
        string produkt = Console.ReadLine();
        inventory.Add(produkt);
        Console.WriteLine("Produkt tillagd! Tryck på valfri knapp för att backa.");
        Console.ReadKey(true);
        Console.Clear();
    }
    static void VisaInventarie()
    {
      foreach (var item in inventory)
      {
        Console.WriteLine(item);
        }
    }
}