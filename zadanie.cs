
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using zadanie_08;
 
namespace zadanie_08

{

    public interface IProdukt

    {

        void WyswietlInfo();

        decimal AktualnaCena();

        int DostepnaIlosc();

    }

    public class Produkt : IProdukt

    {

        public decimal Cena { get; set; }

        public int Ilosc { get; set; }

        public string Opis { get; set; }

        public Produkt(decimal cena, int ilosc, string opis)

        {

            Cena = cena;

            Ilosc = ilosc;

            Opis = opis;

        }

        public void WyswietlInfo()

        {

            Console.WriteLine($"Opis: {Opis}, Cena: {Cena}, Ilość: {Ilosc}");

        }

        public decimal AktualnaCena()

        {

            return Cena;

        }

        public int DostepnaIlosc()

        {

            return Ilosc;

        }

    }


    public class Ksiazka : Produkt

    {

        public string Autor { get; set; }

        public string ISBN { get; set; }

        public Ksiazka(string autor, string isbn, decimal cena, int ilosc, string opis)

            : base(cena, ilosc, opis)

        {

            Autor = autor;

            ISBN = isbn;

        }

    }

    public class Elektronika : Produkt

    {

        public string Nazwa { get; set; }

        public string Rodzaj { get; set; }


        public Elektronika(string nazwa, string rodzaj, decimal cena, int ilosc, string opis)

            : base(cena, ilosc, opis)

        {

            Nazwa = nazwa;

            Rodzaj = rodzaj;

        }

    }

    public class Odziez : Produkt

    {

        public string Nazwa { get; set; }

        public string Rozmiar { get; set; }

        public Odziez(string nazwa, string rozmiar, decimal cena, int ilosc, string opis)

            : base(cena, ilosc, opis)

        {

            Nazwa = nazwa;

            Rozmiar = rozmiar;

        }

    }

    public abstract class Osoba

    {

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

    }

    public class Klient : Osoba

    {

        public List<IProdukt> Koszyk { get; set; }

        public Klient()

        {

            Koszyk = new List<IProdukt>();

        }

        public void DodajDoKoszyka(IProdukt produkt, int ilosc)
        {
            if (produkt.DostepnaIlosc() >= ilosc)
            {
                for (int i = 0; i < ilosc; i++)
                {
                    Koszyk.Add(produkt);
                }
            }
            else
            {
                Console.WriteLine("Nie ma wystarczającej ilości produktu.");
            }
        }


        public void WyswietlCeneProduktu(IProdukt produkt)

        {

            Console.WriteLine($"Cena produktu: {produkt.AktualnaCena()}");

        }

        public decimal ObliczKosztCalegoKoszyka()

        {

            return Koszyk.Sum(produkt => produkt.AktualnaCena());

        }

    }

}

class Program

{

    static void Main(string[] args)

    {

        Klient klient = new Klient();

        klient.Imie = "stasiek";
        klient.Nazwisko = "Matyjaszczyk";

        Odziez odziez = new Odziez("koszula", "L", 6, 13, "opisany");

        Elektronika elektronika = new Elektronika("Sony", "telefon", 100, 7, "opisany");

        Ksiazka ksiazka = new Ksiazka("ADAM", "47827487298374", 34, 1, "opisany");

        klient.DodajDoKoszyka(ksiazka, 2);

        klient.DodajDoKoszyka(elektronika, 2);

        klient.WyswietlCeneProduktu(ksiazka);

        decimal totalcost = klient.ObliczKosztCalegoKoszyka();

        Console.WriteLine($"koszyk: {totalcost}");

    }

}


//bstrakcyjne są bardziej odpowiednie, gdy klasy dzielą wiele wspólnych cech i zachowań, natomiast interfejsy są lepsze do definiowania kontraktów,

//które mogą być realizowane przez klasy, które mogą nie mieć ze sobą nic wspólnego poza implementacją tych kontraktów

// przyklad 

// public class xyz : abc {

// int ilosc {get ; set;}

// 

//public xyz(int Ilosc) base:(opis){

// ilosc=Ilosc}

// }
