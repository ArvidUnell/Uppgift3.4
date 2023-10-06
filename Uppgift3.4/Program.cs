using System;
using System.Diagnostics.SymbolStore;

namespace Uppgift3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv hur många minuter och sekunder lång din låt är separerade med ett :");
            string svar = Console.ReadLine();

            byte kolonIndex = (byte)svar.IndexOf(':');
            byte minuter = byte.Parse(svar[..kolonIndex]);
            byte sekunder = byte.Parse(svar[(kolonIndex + 1)..]);

            short totSekunder = (short)(minuter * 60 + sekunder);

            if (totSekunder >= 165 && totSekunder <= 260)
            {
                Console.WriteLine("Din låt får spelas på radiostationen!");
            }
            else
            {
                Console.WriteLine("Din låt får inte spelas på radiostationen.");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}