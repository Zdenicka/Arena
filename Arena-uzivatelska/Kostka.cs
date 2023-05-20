using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Arena2
{
    internal class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;
        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetSten;
        /// <summary>
        /// vrátí počet stěn kostky
        /// </summary>
        /// <returns>počet stěn kostky</returns>
        public int VratPocetSten()
        {
            return pocetSten;
        }
        /// <summary>
        /// konstruktor (proto stejný název jako třída)
        /// </summary>
        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        /// <summary>
        /// vykonná hod kostkou
        /// </summary>
        /// <returns>vrátí náhodné hozené číslo</returns>
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }
        /// <summary>
        /// vrací textovou deklaraci kostky
        /// </summary>
        /// <returns>identifikace kostky podle počtu stěn</returns>
        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami", pocetSten);
        }
    }
}
