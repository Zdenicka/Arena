using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena2
{
    internal class Mag : Bojovnik
    {
        private int mana;
        private int maxMana;
        private int magickyUtok;
        /// <summary>
        /// dědí vlastnosti z bojovníka
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="zivot"></param>
        /// <param name="utok"></param>
        /// <param name="obrana"></param>
        /// <param name="kostka"></param>
        /// <param name="mana"></param>
        /// <param name="magickyUtok"></param>
        public Mag(string jmeno, int zivot, int utok, int obrana, Kostka kostka, int mana, int magickyUtok) : base(jmeno, zivot, utok, obrana, kostka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magickyUtok = magickyUtok;
        }
        public override void Utoc(Bojovnik souper)
        {
            int uder = 0;
            // Mana není naplněna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utoc(souper);
            }
            else // Magický útok
            {
                uder = magickyUtok + kostka.hod();
                NastavZpravu(String.Format($"{jmeno} použil magii za {uder} hp"));
                mana = 0;
            }
            souper.BranSe(uder);
        }

        /// <summary>
        /// převádí grafický ukazatel na ukazatel many
        /// </summary>
        /// <returns></returns>
        public string GrafickaMana()
        {
            return GrafickyUkazatel(mana, maxMana);
        }
    }
}
