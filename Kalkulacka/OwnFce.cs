using Kalkulacka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Kalkulacka
{
    public static class OwnFce
    {

        public static void Echo(string text)
        {
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
        }


        public static void GreetingWhom(string name)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Ahoj jsem Zdeničky kalkulačka a přeji {0} hezký den", name));
            Console.WriteLine();
        }


        //ukončení po chybě uživatele s chybovou hláškou
        public static void VypadniBlbe(string rozlouceni)
        {
            Console.WriteLine("");
            Console.WriteLine(rozlouceni);
            System.Environment.Exit(0);
        }

        //dožaduje se floatu dokud ho nedostane (a string si na float převede)
        public static float DejMiCislo(string ChciCislo)
        {
            Console.WriteLine(ChciCislo + " Zadej číslo a zmáčkni enter.");
            string retezecZKlavesnice = Console.ReadLine() ?? "";
            float cislo = OwnFce.StringToFloat(retezecZKlavesnice, float.MinValue);
            if (cislo == float.MinValue)
            {
                do
                {
                    Console.WriteLine("Tohle ale není číslo, zkus ho zadat znovu");
                    retezecZKlavesnice = Console.ReadLine() ?? "";
                    cislo = OwnFce.StringToFloat(retezecZKlavesnice, float.MinValue);
                }
                while (cislo == float.MinValue);
            }
            return cislo;
        }

        //dožaduje se NENULOVÉHO floatu dokud ho nedostane (a string si na float převede)
        public static float DejMiDelitel(string ChciCislo)
        {
            Console.WriteLine("Zadej číslo a zmáčkni enter. " + ChciCislo);
            string retezecZKlavesnice = Console.ReadLine() ?? "";
            float cislo = OwnFce.StringToFloat(retezecZKlavesnice, 0);
            if (cislo == 0)
            {
                do
                {
                    Console.WriteLine("Tohle ale není číslo nebo se snažíš dělit nulou, zkus to znovu a lépe");
                    retezecZKlavesnice = Console.ReadLine() ?? "";
                    cislo = OwnFce.StringToFloat(retezecZKlavesnice, 0);
                }
                while (cislo == 0);
            }
            return cislo;
        }


        //převede string do floatu
        public static float StringToFloat(string data, float chyba)
        {
            float result = 0;
            try
            {
                result = float.Parse(data);
            }
            catch
            {
                result = chyba;
            }
            return result;

        }



        //dožaduje se intu dokud ho nedostane (a string si na int převede)
        public static int DejMiInt(string ChciCislo)
        {
            Console.WriteLine("Zadej celé číslo a zmáčkni enter. " + ChciCislo);
            string retezecZKlavesnice = Console.ReadLine() ?? "";
            int cislo = OwnFce.StringToInt(retezecZKlavesnice, int.MinValue);
            if (cislo == int.MinValue)
            {
                do
                {
                    Console.WriteLine("Tohle ale není celé číslo, zkus ho zadat znovu");
                    retezecZKlavesnice = Console.ReadLine() ?? "";
                    cislo = OwnFce.StringToInt(retezecZKlavesnice, int.MinValue);
                }
                while (cislo == int.MinValue);
            }
            return cislo;
        }
        
        public static int DejMiInt2()
        {
            string retezecZKlavesnice = Console.ReadLine() ?? "";
            int cislo = OwnFce.StringToInt(retezecZKlavesnice, int.MinValue);
            if (cislo == int.MinValue)
            {
                do
                {
                    Console.WriteLine("Tohle ale není celé číslo, zkus ho zadat znovu");
                    retezecZKlavesnice = Console.ReadLine() ?? "";
                    cislo = OwnFce.StringToInt(retezecZKlavesnice, int.MinValue);
                }
                while (cislo == int.MinValue);
            }
            return cislo;
        }


        //dožaduje se NENULOVÉHO intu dokud ho nedostane (a string si na int převede)
        public static int DejMiDelitelInt(string ChciCislo)
        {
            Console.WriteLine("Zadej celé nenulové číslo a zmáčkni enter. " + ChciCislo);
            string retezecZKlavesnice = Console.ReadLine() ?? "";
            int cislo = OwnFce.StringToInt(retezecZKlavesnice, 0);
            if (cislo == 0)
            {
                do
                {
                    Console.WriteLine("Tohle ale není celé číslo, nebo se pokoušíš dělit nulou, zkus to znovu a lépe");
                    retezecZKlavesnice = Console.ReadLine() ?? "";
                    cislo = OwnFce.StringToInt(retezecZKlavesnice, 0);
                }
                while (cislo == 0);
            }
            return cislo;
        }


        //převede string do intu
        public static int StringToInt(string data, int chyba)
        {
            int result = 0;
            try
            {
                result = Int32.Parse(data);
            }
            catch
            {
                result = chyba;
            }
            return result;

        }




        // jednotlivé početní úkony

        //sčítání
        public static void scitani(float vstupA)
        {
            float vstupB = OwnFce.DejMiCislo("");
            float vysledek = (vstupA + vstupB);
            OwnFce.Result(vysledek.ToString());
        }
        //násobení
        public static void nasobeni(float vstupA)
        {
            float vstupB = OwnFce.DejMiCislo("");
            float vysledek = (vstupA * vstupB);
            OwnFce.Result(vysledek.ToString());
        }
        //odečítání
        public static void odecitani(float vstupA)
        {
            float vstupB = OwnFce.DejMiCislo("");
            float vysledek = (vstupA - vstupB);
            OwnFce.Result(vysledek.ToString());
        }

        //dělení s desetinnými místy
        public static void deleni(float vstupA)
        {
            float vstupB = OwnFce.DejMiDelitel("");
            float vysledek = (vstupA / vstupB);
            OwnFce.Result(vysledek.ToString());
        }

        //dělení se zbytkem
        public static void mod(float vstupA)
        {
            float vstupC = (int)Math.Round(vstupA);
            if (vstupC != vstupA)
            {
                Console.WriteLine("protože to první číslo bylo s desetinnými místy, zaokrouhlili jsme ho, dělit se zbytkem má smysl jen u celých čísel");
            }
            int vstupB = OwnFce.DejMiDelitelInt("");
            string vysledek = (Math.Floor(vstupC / vstupB)).ToString();
            string vysledek1 = (vstupC - Math.Floor(vstupC / vstupB) * vstupB).ToString();
            OwnFce.Result("Výsledek dělení je " + vysledek + " a zbytek je " + vysledek1);
        }


        // vypíše násobky prvního čísla až do výše druhého čísla

        public static void nasobky(float vstupA)
        {

            float jedna = (int)Math.Round(vstupA);
            if (jedna != vstupA)
            {
                Console.WriteLine("protože to první číslo bylo s desetinnými místy, zaokrouhlili jsme ho, vypisovat násobky má smysl jen u celých čísel");
            }
            float dva = OwnFce.DejMiCislo("A jaké je tvé maximum, do kterého chceš násobky vypsat?");

            if (dva < jedna)
            {
                do
                {
                    dva = OwnFce.DejMiCislo("Když je tvé maximum menší než číslo, od kterého chceš vypsat násobky, neumím ti pomoct. ");
                }
                while (dva < jedna);
            }

            else
            {
                for (int k = 1; k * jedna <= dva; k++)
                {
                    Console.WriteLine(k * jedna);
                }
            }
        }

        //vypíše fibonacciho posloupnost končící prvním číslem posloupnosti po zadaném čísle uživatele

        public static void fibonacci(float vstupA)
        {
            int start = 0;
            int posloupnost = 1;
            int fib = 0;
            do
            {
                fib = posloupnost + start;
                start = posloupnost;
                posloupnost = fib;
                Console.WriteLine(fib);
            }
            while (fib <= vstupA);
        }


        public static void Fibonacci2(float vstupA, int fib, int b)
        {
            if (fib >= vstupA)
            {
                Console.WriteLine(fib);
            }
            else
            {
                OwnFce.Fibonacci2(vstupA, b + fib, fib);
            }
        }
        public static void Fibonacci3(float vstupA, int fib, int b)
        {
            if (fib <= vstupA)
            {
                OwnFce.Fibonacci3(vstupA, b + fib, fib);
                Console.WriteLine(fib);
            }
        }
        // ošetři si vstupy 0 a míň - nevnořuj ale dovnitř rekurze
        public static void faktorial(float vstupA)
        {
            float jedna = (int)Math.Round(vstupA);
            if (jedna != vstupA)
            {
                Console.WriteLine("protože to číslo bylo s desetinnými místy, zaokrouhlili jsme ho, vypisovat faktoriál má smysl jen u celých čísel");
            }
            float a = jedna;
            float nasobeni = 1;
            do
            {
                nasobeni = nasobeni * a;
                a = a - 1;
            }
            while (a >= 1);
            Console.WriteLine(nasobeni);
        }

        //vypíše řadu faktoriálu od největšího po nejmenší
        public static void Faktorial2(float vstupA, int fak, int b)
        {
            if (b <= vstupA)
            {
                OwnFce.Faktorial2(vstupA, b * fak, b + 1);
            }
            Console.WriteLine(fak);
            float jedna = (int)Math.Round(vstupA);
            if (jedna != vstupA)
            {
                Console.WriteLine("protože to číslo bylo s desetinnými místy, zaokrouhlili jsme ho, vypisovat faktoriál má smysl jen u celých čísel");
            }
        }
        public static void Faktorial3(float vstupA, int fak, int b)
        {
            if (b > vstupA)
            {
                Console.WriteLine(fak);
            }
            else
            {
                OwnFce.Faktorial3(vstupA, b * fak, b + 1);
            }
            float jedna = (int)Math.Round(vstupA);
            if (jedna != vstupA)
            {
                Console.WriteLine("protože to číslo bylo s desetinnými místy, zaokrouhlili jsme ho, vypisovat faktoriál má smysl jen u celých čísel");
            }
        }

        //výsledky pro výpočty, druhý výsledek je nepovinný a je tam kvůli dělení se zbytkem
        public static void Result(string vysledek, string vysledek1 = "")
        {
            Console.WriteLine();
            Console.WriteLine(vysledek);
            if (vysledek1 != "")
            {
                Console.WriteLine(vysledek1);
            }
        }

        public static List<int> GetRandomListInt(int countItem)
        {
            var result = new List<int>();
            for (var i = 1; i <= countItem; i++)
            {
                //tyhle dva radky nemusis moc zkoumat, je to jen funkce ktera umi vygenerovat nahodne cislo
                //napises do googlu: c# random int
                //a mrknes na prvni odkaz https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c
                //konec kouzla ;-p
                var tempRandom = new Random();
                var nahodneCislo = tempRandom.Next(1, 200);

                result.Add(nahodneCislo);
            }

            return result;
        }



        //vytvoří seznam, vytiskne ho (hodnoty pod sebou) a vrátí ho tomu,  kdo jí volal
        /* abych měla ten původní kód a k čemu se vrátit až udělám chybu

        public static List<int> Testujeme()
        {
            var HokusPokus = new List<int>();
            int hokus = 0;

            do
            {
                hokus = OwnFce.DejMiInt("Nulou zadávání ukončíš.");
                if (hokus != 0)
                {
                    HokusPokus.Add(hokus);
                }
            }
            while (hokus != 0);
            Console.WriteLine("Zadávání ukončeno");
            foreach (var item in HokusPokus)
            {
                Console.WriteLine(item);
            }
            return HokusPokus;
        }

        */
        public static List<int> Testujeme2()
        {
            var HokusPokus = new List<int>();
            int hokus = 0;

            do
            {
                hokus = OwnFce.DejMiInt("Nulou zadávání ukončíš.");
                if (hokus != 0)
                {
                    HokusPokus.Add(hokus);
                }
            }
            while (hokus != 0);
            Console.WriteLine("Zadávání ukončeno");
            return HokusPokus;
        }
        /*
        public static List<int> Tridime()
        {
            var Trideni = new List<int>();
            var Trideni2 = new List<int>();
            int male = 0;
            do
            {
                male = i.Min();
                Trideni2.Add(male);
                Trideni.Remove(i.Min());
            }
            while (male != i.Max());
            return Trideni2;
        }
      
     */
        public static void WriteListInt(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static string vrat(int i)
        {
            string[] mesta = { "Praha", "Brno", "Pardubice", "HK" };
            return mesta[i];
        }

        public static void WriteList(List<int> data)
        {
            var temp = "";
            foreach (var item in data)
            {
                temp += item.ToString() + ", ";
            }
            Console.WriteLine(temp);

        }


        public static void WriteList1a(List<int> data)
        {
            var temp1 = "";
            foreach (var item in data)
            {
                if (String.IsNullOrWhiteSpace(temp1))
                {
                    temp1 += item.ToString();
                }
                else
                {
                    temp1 += ", " + item.ToString();
                }
            }
            Console.WriteLine(temp1);
        }

        public static void ListDoTabulky(List<int> Seznam, int sloupce)
        {
            int poc = 0;
            foreach (int pol in Seznam)
            {
                poc = poc + 1;
                if (poc == sloupce)
                {
                    Console.Write($"{pol}");
                    Console.WriteLine("");
                    poc = 0;
                }
                else
                    Console.Write($"{pol}   ");
            }
        }
        public static void ListDoTabulky2(List<int> Seznam, int sloupce)
        {
            int poc = 0;
            var temp = "";
            foreach (int pol in Seznam)
            {
                poc++;
                temp = String.IsNullOrWhiteSpace(temp) ? temp += pol.ToString() : temp += ", " + pol.ToString();
                if (poc == sloupce)
                {
                    Console.WriteLine(temp);
                    temp = "";
                    poc = 0;
                }
            }
        }


        public static List<int> NahodnySeznam(int velikost)
        {
            var Nahodny = new List<int>();
            do
            {
                Random nh = new Random();
                int cislo = nh.Next(0, 1000);
                Nahodny.Add(cislo);
            }
            while (Nahodny.Count < velikost);
            return Nahodny;
        }

        public static void WriteList1ac(List<int> data)
        {
            var temp1 = "";
            foreach (var pol in data)
            {
                var vysledek = String.IsNullOrWhiteSpace(temp1) ? pol.ToString() : ", " + pol.ToString();
                temp1 += vysledek;
            }
            Console.WriteLine(temp1);
        }

        public static void Prepinac(List<int> Seznam, int sloupce = 0)
        {
            if (Seznam.Count == 0)
            {
                Console.WriteLine("Seznam je prázdný");
                return;
            }
            if (sloupce > 0)
            {
                OwnFce.ListDoTabulky(Seznam, sloupce);
            }
            else
            {
                OwnFce.WriteList1ac(Seznam);
            }
        }



        public static List<int> NactenySeznam()
        {
            var nacteny = new List<int>();
            Console.WriteLine("Zadávej čísla do seznamu, po každém čísle zmáčkni enter. Nulou zadávání ukončíš.");
            do
            {
                int a = OwnFce.DejMiInt2();
                if (a == 0)
                {
                    return nacteny;
                }
                else
                    nacteny.Add(a);
            }
            while (1 == 1);
        }
        public static List<int> NactenySeznam2(int ukonceni, bool manulu)
        {
            var nacteny = new List<int>();
            Console.WriteLine($"Zadávej čísla do seznamu, po každém čísle zmáčkni enter. {ukonceni} zadávání ukončíš.");
            do
            {
                int a = OwnFce.DejMiInt2();
                if (a == ukonceni)
                {
                    if (manulu)
                    {
                        nacteny.Add(ukonceni);
                    }
                    return nacteny;
                }
                else
                    nacteny.Add(a);
            }
            while (true);
        }

        public static List<int> Prepinac2(int countItem, int ukonceni = 0, bool manulu = false)
        {
            var vysledek = new List<int>();
            if (countItem > 0)
            {
                vysledek = OwnFce.NahodnySeznam(countItem);
            }
            if (countItem <= 0)
            {
                vysledek = OwnFce.NactenySeznam2(ukonceni, manulu);
            }
            return vysledek;
        }

        public static int MinMax(List<int> Seznam, int prepinac = 0)
        {
            int cisloA = Seznam[0];
                foreach (int cisloB in Seznam)
                {
                    if (prepinac >= 0)
                    {
                    //vrátí maximum
                    cisloA = cisloA > cisloB ? cisloA : cisloB;
                }
                    else
                    {
                    //vrátí minimum
                    cisloA = cisloA < cisloB ? cisloA : cisloB;
                    }
                }
            return cisloA;
        }

        public static string Pozice(List<int> Seznam, int pozice)
        {
            var vysledek = "";
            if (pozice <= Seznam.Count())
            {
                vysledek = $"Na pozici {pozice} je v seznamu číslo {Seznam[pozice-1].ToString()}";
            }
            else
            {
                vysledek = $"Chyba. Pozice {pozice} v seznamu neexistuje";
            }
            return vysledek;
        }

        public static int Cetnost(List<int> Seznam, int cislo)
        {
            int pocet = 0;
            foreach (int item in Seznam)
                if (cislo == item)
                    pocet++;
            return pocet;
        }

        //nefunguje
        public static List<int> Sort(List<int> Seznam, int prepinac)
        {
            var vysledek = new List<int>();
            while (Seznam.Count() != 0)
                {
                    int cisloA = Seznam[0];
                    foreach (int cisloB in Seznam)
                    {            
                        if (prepinac >= 0)
                        cisloA = cisloA < cisloB ? cisloB : cisloA;
                        else
                        cisloA = cisloA > cisloB ? cisloB : cisloA;
                    }
                    vysledek.Add(cisloA);
                    Seznam.Remove(cisloA);
                }
            return vysledek;
        }

        public static List<int> Razeni(List<int> Seznam, int prepinac=0)
        {
            var vysledek = new List<int>();

            while (Seznam.Count() != 0)
            {
                int minimum = OwnFce.MinMax(Seznam, -1);
                vysledek.Add(minimum);
                Seznam.Remove(minimum);
            }
            return vysledek;
        }



        public static List<int> Bublani(List<int> Seznam)
        {
            while (true)
                {
                int i = 0;
                int konec = 5;
                int pruchod = Seznam.Count();
                while (i + 1 < pruchod)
                {
                    int a = Seznam[i];
                    int b = Seznam[i + 1];
                    if (a > b)
                    {
                        Seznam[i] = b;
                        Seznam[i + 1] = a;
                        konec = 0;
                    }
                    i++;
                }
                pruchod--;
                if (konec == 5)
                return Seznam;
            }
        }

        public static List<int> Bublani2(List<int> Seznam)
        {
            int konec = -5;
            int pruchod = Seznam.Count();
            while (konec != 5)
                {
                konec = 5;
                for (int i = 0; i + 1 < pruchod; i++)
                {
                    int a = Seznam[i];
                    int b = Seznam[i + 1];
                    if (a > b)
                    {
                        Seznam[i] = b;
                        Seznam[i + 1] = a;
                        konec = 0;
                    }
                }
                pruchod--;
            }
            return Seznam;

        }
        public static List<int> Bublani3(List<int> Seznam)
        {
            int pruchod = Seznam.Count();
            while (pruchod > 0)
                {
                for (int i = 0; i + 1 < pruchod; i++)
                {
                    int a = Seznam[i];
                    int b = Seznam[i + 1];
                    if (a > b)
                    {
                        Seznam[i] = b;
                        Seznam[i + 1] = a;
                    }
                }
                pruchod--;
            }
            return Seznam;
        }

        
        public static int Puleni(List<int> Seznam, int a)
        {
            double xx = (double)Seznam.Count();
            double x = Math.Round(xx / 2, 0, MidpointRounding.AwayFromZero);
            double z = x/2;
            double zz = Math.Round(z, 0, MidpointRounding.AwayFromZero);
            int y = (int)zz;
            if (a == Seznam[Seznam.Count()-1])
                return Seznam.Count()- 1;
            if (a == Seznam[0])
                return 0;

            while (true)
                {
                if (a == Seznam[(int)x])
                    return (int)x;
                if (a > Seznam[(int)x])
                {
                    x = x + y;
                }
                else
                {
                    x = x - y;
                }
                if (x >= Seznam.Count() || a < Seznam[0])
                {
                    return -5;
                }
                y = y / 2;
            }
        }
    }
}
