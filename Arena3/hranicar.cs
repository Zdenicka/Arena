using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena3
{
    internal class Hranicar : Bojovnik
    {
        private string zvire;
        private int zvireZivot;
        private int zvireMaxZivot;
        private int zvireObrana;
        private int zvireUtok;    
        /// <summary>
        /// konstruktor Hraničáře
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="zivot"></param>
        /// <param name="utok"></param>
        /// <param name="obrana"></param>
        /// <param name="kostka"></param>
        /// <param name="zvire"></param>
        /// <param name="zvireZivot"></param>
        /// <param name="zvireUtok"></param>
        /// <param name="zvireObrana"></param>
        public Hranicar (string jmeno, string zvire) : base(jmeno)
        {
            var random = new Random();
            this.jmeno = jmeno;
            this.zvire = zvire;
            zivot = random.Next(65, 96);
            maxZivot = zivot;
            utok = random.Next(12, 21);
            obrana = random.Next(6, 12);
            kostka = new Kostka(10);
            zvireZivot = random.Next(8, 22);
            zvireMaxZivot = zvireZivot;
            zvireUtok = random.Next(12, 21);
            zvireObrana = random.Next(4, 12);
        }
        public string Zvire()
        {
            return zvire;
        }
        public override void Utoc(Bojovnik souper)
        {   
            int uder = 0;
            if (zvireZivot > 0)
            {
                if (kostka.hod() <= kostka.VratPocetSten() / 3)
                {
                    int uder1 = utok + kostka.hod();
                    int uder2 = zvireUtok + kostka.hod();
                    zprava = $"{jmeno} útočí s úderem za {uder1} HP \n {zvire} útočí s úderem za {uder2} HP";
                    uder = uder1 + uder2;
                    souper.BranSe(uder);
                }
                else
                {
                    uder = utok + kostka.hod();
                    NastavZpravu(String.Format($"{jmeno} útočí s úderem za {uder} HP \n {zvire} nedokáže zaútočit"));
                    souper.BranSe(uder);
                }
            }
            else
                base.Utoc( souper); 
        }

        public override void BranSe(int uder)
        {
            if (zvireZivot > 0)
            {
                int zraneni = 2 * uder / 3  - (obrana + kostka.hod());
                int zraneni2 = uder / 3 - (zvireObrana + kostka.hod());
                if (zraneni > 0)
                {
                    zivot -= zraneni;
                    zprava = $"{jmeno} se brání a utrpěl zranění za {zraneni} HP";

                    if (zivot <= 0)
                    {
                        zivot = 0;
                        zprava += " a zemřel";
                    }
                }
                else
                {
                    zprava = $"{jmeno} odrazil útok";
                }
                if (zraneni2 > 0)
                {
                    zvireZivot -= zraneni2;
                    zprava += $" {zvire} se brání a utrpěl zranění za {zraneni2} HP";

                    if (zvireZivot <= 0)
                    {
                        zvireZivot = 0;
                        zprava += " a zemřel";
                    }
                }
                else
                {
                    zprava += $" {zvire} odrazil útok";
                }
            }
            else
                base.BranSe(uder);
        }


        public string GrafickeZvire()
        {
            return GrafickyUkazatel(zvireZivot, zvireMaxZivot);
        }
        public override string VypisBorce()
        {
            string zprava = $"Tvůj hraničář {jmeno} má následující vlastnosti: \n{maxZivot} životů \nútok {utok}\nobranu {obrana} \njeho{zvire} má \n{zvireMaxZivot} životů \nútok {zvireUtok} \na obranu {zvireObrana}\n\n";
            return zprava;
        }

    }

}
