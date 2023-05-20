using Kalkulacka;
using System;
using System.Security.Cryptography;

namespace kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        
                
       {
            //bacha napred se vzdy provede kod ze seznamy pak ze zbytky a pak ten co je tady na radku 15 a dal
            Seznamy.Seznam();
            Zbytky.Zbytky1();
            if (1 == 2)
            {
                float a = OwnFce.DejMiCislo("");

                Console.WriteLine();
                Console.WriteLine(" pokud chceš čísla mezi sebou násobit, napiš '*',");
                Console.WriteLine(" pokud sčítat napiš '+', ");
                Console.WriteLine(" pro odčítání použij '-'");
                Console.WriteLine(" umíme i dělit - zkus použít '/'");
                Console.WriteLine(" a kdybys náááááhodou chtěl dělit na celá čísla (a vědět i zbytek), zkus napsat 'mod'");
                Console.WriteLine(" napiš 'nasobky'  a já ti vypíšu násobky tvého zvoleného celého čísla do maxima, které si zvolíš");
                Console.WriteLine(" napiš 'fib'  a já ti vypíšu fibonacciho posloupnost, která bude končit prvním číslem po tvém zvoleném čísle");
                Console.WriteLine(" napiš 'fib2'  a já ti napíšu první číslo následující po tvém zvoleném čísle ve fibonacciho posloupnosti");
                Console.WriteLine(" napiš 'fakt'  a já ti napíšu faktoriál pro tvé zvolené číslo");
                Console.WriteLine(" napiš 'fakt2'  a já ti vypíšu řadu faktoriálu pro všechna čísla od tvého zvoleného čísla do jedničky");
                Console.WriteLine();
                Console.WriteLine(" a pak vždycky stiskni enter");
                Console.WriteLine();

                string znamenko = Console.ReadLine() ?? "";
                znamenko = znamenko.ToLower().Trim();


                switch (znamenko)
                {
                    case "*":
                        OwnFce.nasobeni(a);
                        break;

                    case "-":
                        OwnFce.odecitani(a);
                        break;

                    case "+":
                        OwnFce.scitani(a);
                        break;

                    case "mod":
                        OwnFce.mod(a);
                        break;

                    case "/":
                        OwnFce.deleni(a);
                        break;

                    case "nasobky":
                        OwnFce.nasobky(a);
                        break;

                    case "fib":
                        OwnFce.fibonacci(a);
                        break;

                    case "fib2":
                        OwnFce.Fibonacci2(a, 0, 1);
                        break;

                    case "fib3":
                        OwnFce.Fibonacci3(a, 0, 1);
                        break;

                    case "fakt":
                        OwnFce.faktorial(a);
                        break;

                    case "fakt2":
                        OwnFce.Faktorial2(a, 1, 1);
                        break;

                    case "fakt3":
                        OwnFce.Faktorial3(a, 1, 1);
                        break;


                    default:
                        OwnFce.VypadniBlbe("To znaménko se ti moc nepovedlo, zkus si celý program zopakovat");
                        break;
                }

                /*
                            Console.WriteLine("napiš slovo nebo větu");
                            string veta = Console.ReadLine() ?? "";

                            string opak = "";

                            for (int PocetZnaku = veta.Length - 1; PocetZnaku > 0; PocetZnaku--)
                            {
                                opak = opak + veta[PocetZnaku];
                            }
                            Console.WriteLine(opak);
                */




            }

            Pozdrav pozdrav = new Pozdrav();
            pozdrav.text = "Vítám tě";
            Console.WriteLine(pozdrav.Zdrav("Petr"));
            Console.WriteLine(pozdrav.Zdrav("Anonym"));
            pozdrav.text = "Kdy ses naučila číst?";
            Console.WriteLine(pozdrav.Zdrav("Dydynka"));

        }

    }
}