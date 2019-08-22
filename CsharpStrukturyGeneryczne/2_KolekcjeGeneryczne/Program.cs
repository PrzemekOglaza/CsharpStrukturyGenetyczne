using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Kolejka();
            //  Stos();
            //  HashSet();
            //  LinkedList();
            //  LinkedList2();
            //  Słownik();
            //  SortedDictionary(); // lepsze przy pobieraniu i usuwaniu elementów
            //  SortedList(); 
            //  SortedSet();


            var pracownicy = new SortedDictionary<string, SortedSet<Pracownik>>();

            pracownicy.Add("Ksiegowosc", new SortedSet<Pracownik>(new PracownikComparer()));



            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Kowalski" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Brzechwa" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Mop" });
            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Sprzedaz", new SortedSet<Pracownik>(new PracownikComparer()));

            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Nowak" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Bob" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Tom" });
            pracownicy["Sprzedaz"].Add(new Pracownik { Nazwisko = "Nowak" });

            foreach (var dzial in pracownicy)
            {
                Console.WriteLine(dzial.Key);
                foreach (var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t"  + pracownik.Nazwisko);
                }
            }
           











        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();

            set.Add(8);
            set.Add(6);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var set2 = new SortedSet<string>();

            set2.Add("tomek");
            set2.Add("iza");
            set2.Add("ola");
            set2.Add("tara");
            set2.Add("ala");
            set2.Add("tom");

            foreach (var item in set2)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortedList()
        {
            var listaPosortowana = new SortedList<int, string>();

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(2, "dwa");
            listaPosortowana.Add(5, "piec");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(4, "cztery");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedList<string, List<Pracownik>>();

            pracownicy.Add("Sprzedaż", new List<Pracownik> { new Pracownik { Imie = "Jan", Nazwisko = "Kowal" },
                                                             new Pracownik { Imie = "Tomasz", Nazwisko = "Wolga" },
                                                             new Pracownik { Imie = "Ola", Nazwisko = "Kac" } });

            pracownicy.Add("Informatyka", new List<Pracownik> { new Pracownik { Imie = "Tatiana", Nazwisko = " Nos"},
                                                                new Pracownik { Imie = "Ola", Nazwisko = " Mop"}});

            pracownicy.Add("Ksiegowość", new List<Pracownik> { new Pracownik { Imie = "Tom", Nazwisko = "Cok"},
                                                                new Pracownik { Imie = "Iwona", Nazwisko = "Tok"},
                                                                new Pracownik { Imie = "Teresa", Nazwisko = "Kok"},
                                                                new Pracownik { Imie = "Olaf", Nazwisko = "Lok"}});

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1} ", item.Key, item.Value.Count);
            }
        }

        private static void Słownik()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();

            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" },
                                                                 new Pracownik { Nazwisko = "Motka" },
                                                                 new Pracownik { Nazwisko = "Torba" } });

            //...

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski"},
                                                                    new Pracownik { Nazwisko = "Watroba"}});

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział :" + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }

                Console.WriteLine();

            }

            Console.WriteLine("Pracownicy z Ksiegowosci");

            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void LinkedList2()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var elementPierwszy = lista.First;
            var elementOstatni = lista.Last;

            lista.AddAfter(elementPierwszy, 10);
            lista.AddBefore(elementPierwszy, 20);

            var wezel = lista.First;

            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashSet()
        {
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            var pracownik = new Pracownik { Imie = "Marcin" };

            set.Add(pracownik);
            set.Add(pracownik);

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Kowak" });
            stos.Push(new Pracownik { Imie = "Jacek", Nazwisko = "Zajac" });
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine();
            Console.WriteLine("Stos");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Zajac" });
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Kaczor" });

            Console.WriteLine("Kolejka");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
