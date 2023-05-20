using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    public static class Seznamy
    {
        public static void Seznam()
        {
            if (false)
            {

                //1) vytvoř fuknci(fce) které předáš list<int> a ona vypíše hodnoty do řádku oddělené čárkou
                var NovyList = OwnFce.GetRandomListInt(20);
                foreach (int pol in NovyList)
                {
                    Console.Write($"{pol}, ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                //Petrovo řešení
                var PetruvList = new List<int> { 1, 2, 3, 4, 7, 5, 6, 7, 8, 9, 7 };
                OwnFce.WriteList(PetruvList);


                Console.WriteLine("");
                Console.WriteLine("");

                //1a) uprav si ji tak aby končila číslem a ne čárkou
                int poc = 0;
                foreach (int pol in NovyList)
                {
                    poc = poc + 1;
                    if (poc == NovyList.Count())
                    {
                        Console.Write($"{pol}");
                    }
                    else
                        Console.Write($"{pol}, ");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                //Petrovo řešení - tady to nevypíše seznam a já nedokážu najít chybu....
                OwnFce.WriteList1a(PetruvList);
                Console.WriteLine("");
                Console.WriteLine("");

                //ternární podmínka
                OwnFce.WriteList1ac(OwnFce.GetRandomListInt(21));
                OwnFce.WriteList1ac(PetruvList);

                Console.WriteLine("");
                Console.WriteLine("");

                //2) vytvoř fce které předáš List<int> a ona vypíše hodnoty do tabulky, vstupní parametr určí počet sloupců

                OwnFce.ListDoTabulky(OwnFce.GetRandomListInt(50), 5);
                Console.WriteLine("");
                Console.WriteLine("");
                OwnFce.ListDoTabulky2(OwnFce.GetRandomListInt(50), 5);

                Console.WriteLine("");
                Console.WriteLine("");



                //3) vytvoř fce která sloučí obě předešlé 

                OwnFce.Prepinac(OwnFce.NahodnySeznam(30), 8);

                Console.WriteLine("");
                Console.WriteLine("");

                OwnFce.Prepinac(OwnFce.NahodnySeznam(30));

                Console.WriteLine("");
                Console.WriteLine("");

                //4) vytvoř fce která ti vrátí List<int>, vstupní parametr určuje počet honot

                OwnFce.ListDoTabulky(OwnFce.NahodnySeznam(20), 10);

                //5) vytvoř fce která ti vrátí seznam list<int> načítaných z klávesnice, ukončení načítaní po stisknutí nuly, vstupní parametr includeZero učí zda nula bude součástí seznamu nebo nikoliv

                OwnFce.ListDoTabulky(OwnFce.NactenySeznam(), 5);

                Console.WriteLine("");
                Console.WriteLine("");

                OwnFce.ListDoTabulky(OwnFce.NactenySeznam2(8, true), 5);


                /*
                6) vytvoř univerzální fce z variant 4 a 5

                        tohle je takovy kočkopes na procviceni, rekneme ze zadani zni
                       funkce bude mít nasedující parametry 
                       countItem pokud bude vetsi nez nula bude se generovat seznam nahodne, pak jsou stopNumber a include zero nepovinne
                       pokud je countItem mensi nebo roven nule bude se seznam nacitat z klavesnice 
                       pokud se stopNumber nezada bude automaticky nula
                       pokud se nezada includeZero bude automaticky false
                */
                Console.WriteLine("");
                Console.WriteLine("");

                OwnFce.ListDoTabulky(OwnFce.Prepinac2(20), 5);
                Console.WriteLine("");
                Console.WriteLine("");
                OwnFce.ListDoTabulky(OwnFce.Prepinac2(-20), 5);
                Console.WriteLine("");
                Console.WriteLine("");
                OwnFce.ListDoTabulky(OwnFce.Prepinac2(-20, 7, true), 5);
                Console.WriteLine("");
                Console.WriteLine("");


                //7) vytvor funkci ktera vrátí nejvetsi nebo nejmensi cislo z celeho seznamu, podle vstupního parametru

                Console.WriteLine($"Maximum seznamu Petrův List je {OwnFce.MinMax(PetruvList, 5)}");
                Console.WriteLine($"Minimum seznamu Petrův List je {OwnFce.MinMax(PetruvList, -5)}");

                Console.WriteLine("");
                Console.WriteLine("");

            


            //8) vytvor funkci ktera ti vrati hodotu prvku seznamu ze zadane pozice, nebo napise chybu pokud je pozice mimo rozsah
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(OwnFce.Pozice(PetruvList, 7));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(OwnFce.Pozice(PetruvList, 11));


            //9) vytvor funkci ktere predas seznam cisel a libovolne cislo, a funkce ti rekne kolikrat seznam obsahuje dané číslo


            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(OwnFce.Cetnost(PetruvList, 7));
            
            Console.WriteLine("");
            Console.WriteLine("");



            //10) vytvor funkci ktera setridi seznam cisel pomoci noveho seznamu, podle vstupního parametru určíš zda vzestupně nebo sestupně

            OwnFce.WriteList1ac(OwnFce.Razeni(OwnFce.NahodnySeznam(20), 7));
            OwnFce.WriteList1ac(OwnFce.Sort(OwnFce.NahodnySeznam(20), 7));
            OwnFce.WriteList1ac(OwnFce.Sort(OwnFce.NahodnySeznam(20), -7));

            /*
            11) podobně jako 10 ale s použitím buble Sort - algoritmus jde dohledat na webu,
                sestupné třídění - princip spočívá v tom že procházíš seznam a porovnáváš dva sousední prvky, pokud je první menší než druhý, tak je přehodíš
                a tohle děláš furt dokola dokud v průchodu seznamem dojde k nějaké změně.Po každém průchodu si vypiš obsah seznamu, uvidíš jak ty čísla probublávají
            */
            Console.WriteLine("");
            Console.WriteLine("");


            var pokusny = OwnFce.NahodnySeznam(20);
            var pokusny2 = OwnFce.NahodnySeznam(20);

            OwnFce.WriteList1ac(pokusny);
            OwnFce.WriteList1ac(OwnFce.Bublani2(pokusny));
            OwnFce.WriteList1ac(pokusny2);
            var trideny = OwnFce.Bublani3(pokusny2);
            OwnFce.WriteList1ac(trideny);



            /*
            12) vytvor funkci ktera na setridenem seznamu nalezne první výskyt zadaneho cisla pomoci puleni intervalu
                princip je následující zjistíš počet prvků v seznamu a podíváš se na prvek v prostředku, pokud je prvek v prostredku vetší nez ten co hledas jdes hledat do prrvní poloviny pokud ne jdes do druhé
                a z té poloviny se podíváš opět na prvek v prostředku a zase podle toho zda je vetsi nebo menší hledáš v příslušné polovině
                kdyžtak si to nakresli nebo vygoogli pokud ten princip není jasný; -p
            */
            var PetruvList4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};

            var vysledekPuleni = OwnFce.Puleni(PetruvList4, -3);
            if (vysledekPuleni >= 0)
                Console.WriteLine(vysledekPuleni);
            if (vysledekPuleni == -5)
                Console.WriteLine("Hledané číslo není v seznamu");

}


            /*
            pak až budou objekty
            ) vytvor funkci ktera ti vrati hodotu prvku seznamu ze zadane pozice, nebo napise chybu pokud je pozice mimo rozsah

                */
            //kód z PDFka
            if (1 ==2)
                {
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(OwnFce.vrat(i));



                Console.WriteLine("Ahoj Zdeničko používej anglickou klávesnici nebo se z toho zblázníš");

                //deklarují se takto
                var prazdnyListInt = new List<int>();
                var prazdnyListString = new List<string>();

                //pocet prvku ktere obsahuji zjisti pomoci fce count
                Console.WriteLine("velikost seznamu int:" + prazdnyListInt.Count());
                Console.WriteLine(String.Format("velikost seznamu string: {0}", prazdnyListString.Count()));

                //pridani prvku nakonec seznamu
                prazdnyListInt.Add(5);
                prazdnyListString.Add("kuk");

                //pocet prvku ktere obsahuji zjisti pomoci fce count
                Console.WriteLine("uz nejsem prazdny - velikost seznamu int:" + prazdnyListInt.Count());
                Console.WriteLine(String.Format("uz nejsem prazdny - velikost seznamu string: {0}", prazdnyListString.Count()));

                //pokud bys chtela muzes si nadefinovat dopredu jiz vylpneny seznam
                var firstList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //a pridavat nakonec muzes kdykoliv
                firstList.Add(10);

                //pristupovat k jednotlivym polozkam se da pomoci indexu prvni polozka ma index nula
                Console.WriteLine(String.Format("Velikost seznamu firstList je: {0}", firstList.Count()));

                //muzes pristupovat i k libovolnemu prvku pomoci indexu, prvni prvek ma index nula
                var prvniPrvek = firstList[0];
                Console.WriteLine(String.Format("prvni prvek je: {0}", prvniPrvek));
                // nebo zjednodušený zápis
                Console.WriteLine(String.Format("treti prvek je: {0}, paty prvek je: {1}", firstList[2], firstList[4]));

                //pokud bys chtela projit cely seznam pouziva se foreach
                Console.WriteLine("vypisu pod sebe cely seznam:");
                foreach (var item in firstList)
                {
                    Console.WriteLine(item);
                }
                /* 
                 funguje to nasledovne promena item postupne nabyva hodnot jednotlivých prvku
                 takze pokud je to seznam int, tak item je typ int
                 pokud je to seznam string, tak item je typ string
                 */

                //protoze list je "slozitejsi promena" spis struktura, muze se snadno stat ze dojde pri praci s ni k chybe
                //zkusis pristupovat k polozce ktera neexistuje, nebo zkusis vlozit spatny typ promene
                //tak je lepsi se seznam pracovat uvnitr try - catch
                //pokud se v sekci TRY stane chyba, program nespadne ale skočí do sekce CATCH
                //provede kod v sekci catch a pak pokracuje dal

                try
                {
                    var test = new List<int> { 1, 2 };
                    //udelame chybu zkusime precist prvek s indexem 3 
                    var baf = test[3];
                    Console.WriteLine("tento kod se neprovede dokud chybu neopravis ;-p");
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("pozor došlo k systémové chybe: {0}", e.InnerException == null ? e.Message : e.InnerException.Message));
                }

                //posledni ukazkovy priklad a pak ukoly pro zdenicku
                //reknem ze mas za ukol: Napiste funkci ktera vrátí seznam deseti náhodných int, a 
                //funkci ktera vytiske libovolny seznam celych cisel int
                //reseni:

                try
                {
                    var nahodnySeznam = new List<int>();
                    //vygeneruji
                    nahodnySeznam = OwnFce.GetRandomListInt(10);
                    //vytisknu
                    Console.WriteLine("tisknu nahodny seznam");
                    OwnFce.WriteListInt(nahodnySeznam);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("tisknu nahodny seznam zkracena verze");
                    //zkracena varianta proklikej si ji pomocí F11
                    OwnFce.WriteListInt(OwnFce.GetRandomListInt(10));
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("pozor došlo k systémové chybe: {0}", e.InnerException == null ? e.Message : e.InnerException.Message));
                }

                /*
                a ted ukoly pro zdenicku:
                1) vytvor seznam ktery se bude jmenovat pesani a bude obsahovat jmena nasich pejsku
                */
                var pesani = new List<string> { "Charles", "Bohoušek", "Dorotka" };

                //2) vytvor funkci ktere predas seznam pesani a ona ho vypise - kazdy radek jeden pesan
                foreach (var item in pesani)
                {
                    Console.WriteLine(item);
                }


                //3) vytvor funkci ktere predas seznam pesani a ona vypise cely seznam na jeden radek, jednotliva jmena budou oddelena carkama
                Console.WriteLine(String.Format("{0}, {1}, {2}", pesani[0], pesani[1], pesani[2]));


                //4) vytvoř funkci ktera vrati seznam celych cisel, jednotlive polozky budou nacitane z klavesnice, jakmile zadas nulu ukonci se nacitani

                var seznam = OwnFce.Testujeme2();
                foreach (var item in seznam)
                {
                    Console.WriteLine(item);
                }


                //5) vytvoř funkci ktera vypise cisla z predchoziho seznamu na radek oddelana carkou
                foreach (var item in seznam)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();

                //6) vytvoř funkci která vypise seznam císel do matice o 5 sloupcich
                //fungovalo by, kdyb v seznamu nebyla stejná čísla
                /*
                var matice = new List<int>();
                matice = OwnFce.GetRandomListInt(40);
                foreach (var item in matice)
                {
                    float z = matice.IndexOf(item)+1;
                    if (z%5 == 0)
                    {
                        Console.Write(item);
                        Console.WriteLine();
                    }
                    else
                    Console.Write(item + ", ");
                }
                */

                var matice = new List<int>();
                matice = OwnFce.GetRandomListInt(40);
                var pocitadlo = 0;
                foreach (var item in matice)
                {
                    pocitadlo = pocitadlo + 1;
                    if (pocitadlo == 5)
                    {
                        Console.Write(item);
                        Console.WriteLine();
                        pocitadlo = 0;
                    }
                    else
                        Console.Write(item + ", ");
                }





                //7) vytvor funkci ktera vypise nejvetsi a nejmensi cislo z celeho seznamu - napiš si řadící fci
                //matice.Sort();
                var Trideni = new List<int> { 1, 60, 55, 23, 85, 4, 9, 85, 2 };
                var Trideni2 = new List<int>();
                int male = int.MaxValue;
                do
                {
                    foreach (var i in Trideni)
                    {
                        if (i < male)
                        {
                            male = i;
                        }
                        Trideni2.Add(male);
                        Trideni.Remove(male);
                    }
                }
                while (Trideni.Count() > 0);

                Console.WriteLine($"nejnižší číslo seznamu je {Trideni2[0]} a nejvyšší číslo je {Trideni2[Trideni2.Count() - 1]}");

                //8) vytvor funkci ktera vypise nejdelsi a nejkratsi retezec z celeho seznamu


                //9) vytvor funkci ktera ti vrati hodotu prvku seznamu ze zadane pozice, nebo napise chybu pokud je pozice mimo rozsah 
                //10) tohle vyrobime spolu, uprav fce7 tak aby vratila nejmensi a nejvetsi cislo
                //11) vytvor funkci ktere predas seznam cisel a libovolne cislo, a funkce ti rekne kolikrat seznam obsahuje dané číslo
                //12) vytvor funkci ktera setridi seznam cisel pomoci noveho seznamu
                //13) vytvor funkci ktera setridi seznam cisel pomoci bublani
                //14) vytvor funkci ktera na setridenem seznamu nalezne první výskyt zadaneho cisla pomoci puleni intervalu
                //15) vyzkousej si predefinovane funkce v C#, ktere umi vse co jsi programovala v bodech 1 - 15 ;-p

            }
            
        }
    }
}
