using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Arena
    {
        private Bojovnik bojovnik1;
        private Bojovnik bojovnik2;
        private Kostka kostka;
        /// <summary>
        /// konstruktor arény
        /// </summary>
        /// <param name="bojovnik1"></param>
        /// <param name="bojovnik2"></param>
        /// <param name="kostka"></param>
        public Arena(Bojovnik bojovnik1, Bojovnik bojovnik2, Kostka kostka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kostka = kostka;
        }
        private void VypisBojovnika(Bojovnik b)
        {
            Console.WriteLine(b);
            Console.Write("Život: ");
            Console.WriteLine(b.GrafickyZivot());
            if (b is Mag)
            {
                Console.Write("Mana:  ");
                Console.WriteLine(((Mag)b).GrafickaMana());
            }
            if (b is Hranicar)
            {
                Console.Write($"{((Hranicar)b).Zvire()}   ");
                Console.WriteLine(((Hranicar)b).GrafickeZvire());
            }

        }
        /// <summary>
        /// grafické znázornění arény
        /// </summary>
        private void Vykresli()
        {
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            VypisBojovnika(bojovnik1);
            Console.WriteLine();
            VypisBojovnika(bojovnik2);
            Console.WriteLine();
        }
        /// <summary>
        /// vypíše zprávu a uspí systém na 500 ms - třída thread - práce s vlákny
        /// </summary>
        /// <param name="zprava"></param>
        private void VypisZpravu(string zprava)
        {
            Console.WriteLine(zprava);
            Thread.Sleep(800);
        }

        public void Zapas()
        {
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;
            if (kostka.hod() <= kostka.VratPocetSten()/2 )
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine($"Dnes se utkají {bojovnik1} s {bojovnik2}! \n");
            Console.WriteLine($"Začínat bude {b1}! \n");
            Console.WriteLine("Zápas může začít...");
            Console.ReadKey();
            // cyklus s bojem
            while (b1.Nazivu() && b2.Nazivu())
            {
                b1.Utoc(b2);
                Vykresli();
                VypisZpravu(b1.VratPosledniZpravu()); // zpráva o útoku
                VypisZpravu(b2.VratPosledniZpravu()); // zpráva o obraně
                Console.ReadKey();

                if (b2.Nazivu())
                {
                    b2.Utoc(b1);
                    Vykresli();
                    VypisZpravu(b2.VratPosledniZpravu()); // zpráva o útoku
                    VypisZpravu(b1.VratPosledniZpravu()); // zpráva o obraně
                    Console.ReadKey();
                }
                Console.WriteLine();
            }
        }
    }
}
