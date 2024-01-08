using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_08_01
{
    internal interface IProdukt
    {
        void Wyswietlinfo();
        void AktualnaCena();
        void Dostepnailosc();

    }

    public class Ksiazka : IProdukt 
    {
        public string Autor { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }


        public Ksiazka(string autor , string nazwa, decimal cena, int ilosc) 
        {
            Autor = autor;  
            Nazwa = nazwa; 
            Cena = cena;
            Ilosc = ilosc;
        }

        public void Wyswietlinfo()
        {
            Console.WriteLine($"AUTOR: {Autor}, NAZWA: {Nazwa}");
        }

        public void AktualnaCena() 
        {
            Console.WriteLine($"AKTUALNA CENA: {Cena}");
        }

        public void Dostepnailosc()
        {
            Console.WriteLine($"DOSTEPNA ILOŚĆ: {Ilosc}");
        }
    }

    public class Elektronika : IProdukt 
    {
        public string Nazwa { get; set;}
        public string Rodzaj {  get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set;}

        public Elektronika (string nazwa, string rodzaj, decimal cena, int ilosc)
        {
            Nazwa = nazwa;
            Rodzaj = rodzaj;
            Cena = cena;
            Ilosc = ilosc;
        }

        public void Wyswietlinfo() 
        {
            Console.WriteLine($"NAZWA: {Nazwa} RODZAJ: {Rodzaj}");
        }

        public void AktualnaCena() 
        {
            Console.WriteLine($"AKTUALNA CENA: {Cena}");
        }

        public void Dostepnailosc() 
        {
            Console.WriteLine($"DOSTEPNA ILOSC: {Ilosc}");
        }
    }

    public class Odziez : IProdukt
    {  public string Nazwa { get; set;}
       public string Rozmiar {  get; set; } 
       public decimal Cena { get; set; }
       public int Ilosc { get; set;}

       public Odziez (string nazwa, string rozmiar, decimal cena, int ilosc)
        { 
        Nazwa = nazwa;
        Rozmiar = rozmiar;
        Cena = cena;
        Ilosc = ilosc;
        }

        public void Wyswietlinfo() 
        {
        Console.WriteLine($"NAZWA: {Nazwa}, ROZMIAR: {Rozmiar}");
        }

        public void AktualnaCena() 
        {
            Console.WriteLine($"AKTUALNA CENA: ");
        }
    
    }
}
