using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    internal class info
    {
        static void Run()
        {
            // { - alt + 123
            // } - alt + 125
            
            // toto je radkovy komentar


            // tady je napoveda, ktera ti pro zacatek bude stacit https://www.w3schools.com/cs/index.php


            /*
                toto je blok komentaru
            */


            /*
            Základní pokec  
             
            C# - programovací jazyk
            C# konzolovka, console Application - to co ted píšeš ;-p abys věděla jak se ptát na google
            C# .NET, .NET5, .NET6, .NET Core, Core 3.1 - je to framework napsaný v C# ==> nádstavba pro psaní webových stánek 

            !!! 
            vždy když založíš novou proměnou je třeba určit její typ a výchozí hodnotu - Tohle si pamatuj i když to není vždy povinné ušetří ti to nervy
            pak už do ní můžeš přiřadit vždy a jen stejný typ, pokud je jednou něco číslo nikdy ti to nedovolí tam dát písmeno
            !!!

            promenne se píšou velbloudem bez diakritiy (velbloudi notace - camelCase), a ideálně anglicky 
            
            totoJePromennaNapsanaVelbloudemHezkySeCteZe 
            
            promenne, pro začátek ti bude stačit 

                        int - celé číslo od -2 147 483 648 až 2 147 483 647

                        string - řetězec

                        bool - logická proměnná nabývá hodnot true (pravda) / false (nepravda)
                                používá se >, <, >=, <=, ==, !=, &&, ||

            kazdy prikaz je ukoncen strednikem

            ctrl + c
            ctrl + v
            ctrl + d - duplikace
            ctrl + z - zpět
            ctrl + y - vpřed
            ctrl + s - uložení
            tab - formatovani
            shift + tab

            */


            /*
            ladění kódu na řádku dáš F9 objeví se červený puntík a zde se kód zastaví 
            procházení F10 - po řádku
            F11 - leze i do funkcí

            */

            int totoJeInt = 10;
            int i = 0;
            //potom se do ní jen přiřazuje hodnota pomocí =
            i = 8;

            string totoJeString = "Ahoj jsem string";
            string message = "";

            //ukazka skladani stringu
            string spz = "BKB 13-14";
            int carId = 15;
            message = String.Format("Vozidlo id: {0} SPZ: {1} neexistuje", carId, spz);

            // nebo lze přes + - platí pouze pro řetězce a ne Int
            string s1 = "baf";
            string s2 = "a";
            string s3 = "kuk";

            message = s1 + " " + s2 + " " + s3;
            //bude stejna jako
            message = String.Format("{0} {1} {2}", s1, s2, s3);

            // logicka promenna
            bool totoJeBool = false; // na zacatku si musis vybrat zda bude pravda nebo nepravda

            //ukázka
            bool test = false;

            //ted jsem pravda
            test = 5 < 8;
            test = 8 >= 8;
            test = (5 + 3) == 8;

            //ted jsem nepravda 
            test = (5 + 3) != 8;

            //ukázka logická funkce AND psáno && - logický součin - slovne to znamá pokud je alespon jeden výraz nepravda je celý výraz nepravda  

            //příklad otestujte zda je číslo v rozsahu 3 až 5 včetně
            int cislo = 3;
            test = cislo >= 3 && cislo <= 5;

            cislo = 8;
            test = cislo >= 3 && cislo <= 5; //tyto dva jsou rozdíl vrátí sice stejnou hodnotu ale vyhodnocují se jinak 
            test = cislo <= 5 && cislo >= 5; //skončí hned u prvního nepravdivého výrazu

            //ukázna logická funkce OR psáno ||- logický součet - slovne to znamena je-li alespon jeden výraz pravda je celý výraz pravda
            //slozitejší výraz se závorkuje
            //cislo je v rozsahu 3 až 5 včetně nebo rozsahu 13 až 15 včetně
            test = ((cislo >= 3 && cislo <= 5) || (cislo >= 13 && cislo <= 15));

            //opet platí že skončí u prvního pravdivého výrazu



            //první progámek bude "kalkulacka v konzolovce" budes potrebovat znát:
            //vypsání textu
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine(message);

            //nactení textu z klávesnice
            //bacha vždy se načítá jako text
            //když něco nevíš napíšeš do googlu: c# console read input  -- to c# console je povinne pak cokoliv co te zajima
            //tady mas pak napovedu https://www.w3schools.com/cs/cs_user_input.php


            Console.WriteLine("zadej libovolný text a stiskni enter:");
            Console.WriteLine();
            string prvniText = Console.ReadLine();
            Console.WriteLine(String.Format("Zadal jsi: {0}", prvniText));


            //tohle je otravne ale pro zacatek se neda nic delat
            //pokud chces vedet zda je to cislo použiješ try - catche

            Console.WriteLine("zadej číslo a stiskni enter:");
            Console.WriteLine();
            string nactenyText = Console.ReadLine();

            try
            {
                int prvniCislo = Int32.Parse(nactenyText);
            }
            catch
            {
                Console.WriteLine("říkal jsem číslo osle ;-p");
            }

            //dovnitř { } se pise blok kodu


            //lze sloučit
            Console.WriteLine("zadej číslo a stiskni enter:");
            Console.WriteLine();
            try
            {
                int prvniCislo1 = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("říkal jsem číslo osle ;-p");
            }


            //podminky
            int a = 20;
            int b = 18;

            //pokud je pravda, provede se blok {} po if
            //pokud neni pravda, cely blok {} se přeskočí
            if (a > b)
            {
                Console.WriteLine(String.Format("{0} je větší než {1}", a, b));
            }

            b = 33;
            //rozsirena varianta
            //pokud je pravda, provede se blok {} po if a pote se pokracuje dál else se neprovádí
            //pokud neni pravda, provede se jen blok po else
            if (a > b)
            {
                Console.WriteLine(String.Format("{0} je větší než {1}", a, b));
            }
            else
            {
                Console.WriteLine(String.Format("{0} je menší nebo rovno {1}", a, b));
            }


            //více moznosti, blok "else if() {}" lze libovolne opakovat, provede se jen první platný blok
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }




            a = 52;
            b = 52;

            if (a > b)
            {
                Console.WriteLine(a.ToString() + " je větší než " + b.ToString());
            }

            else if (a == b)
            {
                Console.WriteLine(a.ToString() + " rovná se " + b.ToString());
            }

            else
            {
                Console.WriteLine(a.ToString() + " je menší než " + b.ToString());
            }

            /*
                a ted bojovy ukol pro Zdenicku 
                vytvor program Kalkulačka za pomoci věcí výše 
                ktery pozada o prvni cislo: int, o druhe cislo: int, o operaci: +, -, * 
                vypočítá a vypíše výsledek 
                pokud nebude zadáno číslo vypíše chybu a ukončí se 
                pokud bude zadána jiná operace vypíše chybu a ukončí se 
            */
        }

    }
}
