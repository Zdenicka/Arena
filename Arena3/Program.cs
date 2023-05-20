using Arena3;
using System;
using System.Security.Cryptography;

namespace Arena3
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Kostka desetistenna = new Kostka(10);
            /*
            Kostka sestistenna = new Kostka(6);
           
            Bojovnik hrachomil = new Bojovnik("Hrachomil", 100, 20, 10, desetistenna);
            Bojovnik knedlomil = new Bojovnik("Knedlomil", 100, 20, 10, desetistenna);
            Bojovnik mrakoplas = new Mag("Mrakoplaš", 90, 15, 12, desetistenna, 30, 45);
            Bojovnik chodec = new Hranicar("Chodec", 70, 18, 8, desetistenna, "pes", 10, 8, 3);

            Arena arena = new Arena(chodec, mrakoplas, desetistenna);
            // zápas
            arena.Zapas();
            Console.ReadKey();
            */
            try
            {
                Uvod uvod = new Uvod();
                uvod.pozdrav();
                Bojovnik borec1 = uvod.Volba("první");
                Bojovnik borec2 = uvod.Volba("druhý");
                Arena arena = new Arena(borec1, borec2, desetistenna);
                // zápas
                arena.Zapas();
                Console.ReadKey();
            } 
            catch (Exception ex) 
            { 
                var message = ex.InnerException == null? ex.Message : ex.InnerException.Message; 
                Console.WriteLine(message);
            }


        }
    }
}
