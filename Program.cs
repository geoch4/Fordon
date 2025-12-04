using Fordon;


namespace Fordon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();

            Console.Write("Hur gammalt är fordonet (i år)? ");
            v.Year = int.Parse(Console.ReadLine());

            Console.Write("Har fordonet giltig försäkring? (ja/nej): ");
            string input = Console.ReadLine().ToLower();

            v.HasInsurance = (input == "ja"); // om "ja" .....true, annars false

            string result = v.CheckInspektion();
            Console.WriteLine(result);
        }
    }
}
//Övning 2 – Fordonsbesiktning
//Rita ett flödesschema för om ett fordon är godkänt:
//Om fordonet är äldre än 5 år och inte har en giltig försäkring → “Ej godkänt”.
//Om fordonet är yngre än 5 år men har giltig försäkring → “Godkänt”.
//Annars → “Måste kompletteras”.
//Skapa en klass Vehicle med attributen Year och HasInsurance.
//Lägg till metoden CheckInspection().
//I Main(): Skapa ett objekt Vehicle från input, och skriv ut resultatet.

//👉 Syfte: Koppla logik och objekt till en verklig situation.