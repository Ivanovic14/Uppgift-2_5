using System;
namespace Uppgift_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en multiplikation med två decimaltal");//Meddelande till user
            Console.Write("Börja med att skriva in en decimaltal, OBS! ENDAST PUNKT FUNGERAR, EJ KOMMATECKEN!!: ");
            string sif1 = Console.ReadLine();
            float decim1 = float.Parse(sif1);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Okej, du valde alltså siffran: " +  decim1);
            Console.Write("Skriv in nästa decimaltal: ");
            string sif2 = Console.ReadLine();
            float decim2 = float.Parse(sif2);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Okej, du har valt siffran " + decim2);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Svaret på dina två valda tal är: " + (decim1 * decim2));
            Console.WriteLine("Stämmer det? Dubbelkolla gärna med en miniräknare!");

        }
    }
}