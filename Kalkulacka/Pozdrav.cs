using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    /// <summary>
    /// třída slouží k pozdravu uživatelů
    /// </summary>
    internal class Pozdrav
    {
        /// <summary>
        /// text pozdravu
        /// </summary>
        public string text;
        /// <summary>
        /// pozdraví uživatele textem a jménem
        /// </summary>
        /// <param name="jmeno"></param>
        /// <returns></returns>
        public string Zdrav(string jmeno)
        {
            return String.Format($"{text} {jmeno}");
        }
    }
}
