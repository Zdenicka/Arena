using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Arena
{
    internal class Bojovnik
    {
        protected string jmeno;
        /// <summary>
        /// aktuální stav zdraví - udáno v HP
        /// </summary>
        protected int zivot;
        /// <summary>
        /// maximální možný počet životů
        /// </summary>
        protected int maxZivot;
        /// <summary>
        /// útok v HP
        /// </summary>
        protected int utok;
        /// <summary>
        /// obrana v HP
        /// </summary>
        protected int obrana;
        /// <summary>
        /// zpráva o průběhu útoku a obrany
        /// </summary>
        protected string zprava;
        /// <summary>
        /// instance kostky
        /// </summary>
        protected Kostka kostka;
        /// <summary>
        /// konstruktor bojovníka
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="zivot"></param>
        /// <param name="utok"></param>
        /// <param name="obrana"></param>
        /// <param name="kostka"></param>
        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }
        /// <summary>
        /// vrací textovou deklaraci bojovníka
        /// </summary>
        /// <returns>jméno</returns>
        public override string ToString()
        {
            return jmeno;
        }

        public bool Nazivu()
        {
            return (zivot > 0);
        }
        /// <summary>
        /// grafické znázornění zdraví/ many/ whatever
        /// </summary>
        /// <returns>řetězec pro vypsání </returns>
        protected string GrafickyUkazatel(int aktualni, int maximalni)
        {
            string s = "[";
            int celkem = 20;
            double pocet = Math.Round(((double)aktualni / maximalni) * celkem);
            if ((pocet == 0) && (Nazivu()))
                pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkem + 1);
            s += "]";
            return s;
        }
        /// <summary>
        /// převádí grafický ukazatel na ukazatel konkrétně zdraví
        /// </summary>
        /// <returns></returns>
        public string GrafickyZivot()
        {
            return GrafickyUkazatel(zivot, maxZivot);
        }
        /// <summary>
        /// počítá zranění při obraně a odečítá je od života
        /// </summary>
        /// <param name="uder"></param>
        public virtual void BranSe (int uder)
        {
            int zraneni = uder - (obrana + kostka.hod());
            if (zraneni > 0) 
            { 
                zivot -= zraneni;
                NastavZpravu(String.Format($"{jmeno} se brání a utrpěl zranění za {zraneni} HP"));

                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }
            }
            else 
            {
                NastavZpravu(String.Format($"{jmeno} odrazil útok"));
            }
        }

        /// <summary>
        /// počítá úder
        /// </summary>
        /// <param name="souper"></param>
        public virtual void Utoc(Bojovnik souper)
        {
            int uder = utok + kostka.hod();
            NastavZpravu(String.Format($"{jmeno} útočí s úderem za {uder} HP"));
            souper.BranSe(uder);
        }

        protected void NastavZpravu(string zprava)
        {
            this.zprava = zprava;
        }
        public string VratPosledniZpravu()
        {
            return zprava;
        }

    }
}
