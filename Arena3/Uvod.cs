using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena3
{
    internal class Uvod
    {
        public void pozdrav()
        {
            Console.WriteLine("Vítejte v aréně!");
        }
        public Bojovnik Volba(string poradi)
        {            
            Console.WriteLine($"Vyber si prosím borce, který vstoupí {poradi} do arény. \n Bude to Bojovník? pak zmáčkni ¨b¨ \n Chceš vyzkoušet Mága? zmáčkni ¨m¨ \n Nebo vyšleš do boje mocného Hraničáře se zvířecím přítelem po boku? zmáčkni ¨h¨ \n");
            string vyber = Console.ReadLine() ?? "";
            vyber = vyber.ToLower().Trim();
            switch (vyber)
            {
                case "b":
                    Console.WriteLine("Vybral sis silného a statečného bojovníka");
                    Bojovnik borec = new Bojovnik(Pojmenovani());
                    return borec;
                case "m":
                    Console.WriteLine("vybral sis mocného kouzelníka");
                    borec = new Mag (Pojmenovani());
                    return borec;
                case "h":
                    Console.WriteLine("vybral sis hrdého hraničáře se zvířecím pomocníkem");
                    borec = new Hranicar(Pojmenovani(), pojmenovani2());
                    return borec;
                default:
                    Console.WriteLine("někde ses asi upsal, takže jsme ti přiřadili bojovníka");
                    borec = new Bojovnik(Pojmenovani());
                    return borec;
            }

        }
        //private string jmeno = Console.ReadLine() ?? "";
        private string Pojmenovani()
        {
            Console.WriteLine("Vymysli pro svého borce jméno a výběr potvrď enterem");
            string jmeno = Console.ReadLine() ?? "";
            return jmeno;
        }
        private string pojmenovani2()
        {
            Console.WriteLine("S jakým zvířecím pomocníkem tvůj hraničář do boje půjde?");
            string jmeno = Console.ReadLine() ?? "";
            return jmeno;
        }
    }
}
