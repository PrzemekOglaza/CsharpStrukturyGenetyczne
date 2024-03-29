﻿using System;


namespace _4_MetodyDelegatyGeneryczne
{
    class Program

    {

        static void Main(string[] args)
        {
            //Predicate();
            //Func();
            //Action();

            
            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);

            kolejka.elementUsuniety += Kolejka_elementUsuniety;

            WprowadzanieDanych(kolejka);

            kolejka.Drukuj(d => Console.WriteLine(d));

            PrzetwarzanieDanych(kolejka);
        }

        private static void Kolejka_elementUsuniety(object sender, ElementUsunientyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka jest pełna, element usuniety to : {0} Nowy element to : {1}", e.ElementUsuniety, e.ElementNowy);
        }

        private static void Action()
        {
            Action<double> drukuj = x => Console.WriteLine(x);
            drukuj(7.6);
            Action<int, int, int, int> test = (a, b, c, d) => Console.WriteLine(a + b + c + d);
            test(1, 2, 3, 4);
        }

        private static void Func()
        {
            Action<double> drukuj = x => Console.WriteLine(x);
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;

            drukuj(potegowanie(5));
            drukuj(dodaj(10, 20));
        }

        private static void Predicate()
        {
            Action<bool> drukuj = x => Console.WriteLine(x);
            Func<double, double> potegowanie = d => d * d;
            Func<double, double, double> dodaj = (x, y) => x + y;
            Predicate<double> jestWiekszeOdSto = d => d < 100;

            drukuj(jestWiekszeOdSto(potegowanie(dodaj(6, 8))));
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty)
            {
                {
                    suma += kolejka.Czytaj();
                }
            }

            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;

                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
