using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena3
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
        public Mag(string jmeno) : base(jmeno)
        {
            var random = new Random();
            this.jmeno = jmeno;
            zivot = random.Next(65, 96);
            maxZivot = zivot;
            utok = random.Next(12, 21);
            obrana = random.Next(6, 12);
            kostka = new Kostka(10);
            mana = random.Next(75, 95);
            maxMana = mana;
            magickyUtok = random.Next(45, 65);
        }
        public override void Utoc(Bojovnik souper)
        {
            int uder = 0;
            // Mana není naplněna
            if (mana >= magickyUtok && kostka.hod() < 6)
            {                
                uder = magickyUtok + kostka.hod();
                NastavZpravu(String.Format($"{jmeno} použil magii za {uder} hp"));
                mana = mana - uder;
                if (mana < 0)
                    mana = 0;
                souper.BranSe(uder);

            }
            else // Magický útok
            {                
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utoc(souper);
            }
        }

        /// <summary>
        /// převádí grafický ukazatel na ukazatel many
        /// </summary>
        /// <returns></returns>
        public string GrafickaMana()
        {
            return GrafickyUkazatel(mana, maxMana);
        }
        public override string VypisBorce()
        {
            string zprava = $"Tvůj mág {jmeno} má následující vlastnosti: \n{maxZivot} životů \nútok {utok}\nobranu {obrana} \nmanu {maxMana} \nmagický útok {magickyUtok}\n\n";
            return zprava;
        }

    }
}
