using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena2
{
    internal class Uvod
    {
        private string vyber;
        public void pozdrav()
        {
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Vyber si prosím borce, který jako první vstoupí do arény. \n Bude to Bojovník? pak zmáčkni ¨b¨ \n Chceš vyzkoušet Mága? zmáčkni ¨m¨ \n Nebo vyšleš do boje mocného Hraničáře se zvířecím přítelem po boku? zmáčkni ¨h¨ \n");
        }
        public void volba() 
        {
            string vyber = Console.ReadLine() ?? "";
            vyber = vyber.ToLower().Trim();

            if (vyber == "b")
            {
                Console.WriteLine("Vybral sis silného a statečného bojovníka");
                //Bojovnik borec1 = new Bojovnik(jmeno);
            }
            if (vyber == "m")
            {
                //Bojovnik borec1 = new Mag;
                Console.WriteLine("vybral sis mocného kouzelníka");
            }
            if (vyber == "h")
            {
                Console.WriteLine("vybral sis hrdého hraničáře se zvířecím pomocníkem");

                //Bojovnik borec1 = new Hranicar();
            }
            else
            {
                Console.WriteLine("někde ses asi upsal, zkus svůj výběr zadat znovu");
                volba();
            }
        }
        private string jmeno = Console.ReadLine() ?? "";


        // výběr jména bude chtít udělat ve vlastní fci
    }
}
