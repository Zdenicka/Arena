using Arena2;
using System;
using System.Security.Cryptography;

namespace Arena2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostka desetistenna = new Kostka(10);
            Kostka sestistenna = new Kostka(6);
            /*
            Bojovnik hrachomil = new Bojovnik("Hrachomil", 100, 20, 10, desetistenna);
            Bojovnik knedlomil = new Bojovnik("Knedlomil", 100, 20, 10, desetistenna);
            Bojovnik mrakoplas = new Mag("Mrakoplaš", 90, 15, 12, desetistenna, 30, 45);
            Bojovnik chodec = new Hranicar("Chodec", 70, 18, 8, desetistenna, "pes", 10, 8, 3);

            Arena arena = new Arena(chodec, mrakoplas, desetistenna);
            // zápas
            arena.Zapas();
            Console.ReadKey();
            */
            Uvod uvod = new Uvod();
            uvod.pozdrav();
            uvod.volba();
        }
    }
}
