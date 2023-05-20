using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
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
        public Hranicar (string jmeno, int zivot, int utok, int obrana, Kostka kostka, string zvire, int zvireZivot, int zvireUtok, int zvireObrana) : base(jmeno, zivot, utok, obrana, kostka)
        {
            this.zvire = zvire;
            this.zvireZivot = zvireZivot;
            this.zvireMaxZivot = zvireZivot;
            this.zvireUtok = zvireUtok;
            this.zvireObrana = zvireObrana;
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
                }
                else
                {
                    uder = utok + kostka.hod();
                    NastavZpravu(String.Format($"{jmeno} útočí s úderem za {uder} HP \n {zvire} nedokáže zaútočit"));
                }
            }
            else
                base.Utoc( souper); 
            souper.BranSe(uder);
        }

        public override void BranSe(int uder)
        {
            if (zvireZivot > 0)
            {
                int zraneni = 2 / 3 * uder - (obrana + kostka.hod());
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


    }

}
