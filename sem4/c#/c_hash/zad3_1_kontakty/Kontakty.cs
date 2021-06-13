using System;
using System.Collections.Generic;

namespace zad3_1_kontakty
{
    public class Kontakty
    {
        private List<Kontakt> kontakty;

        public Kontakty()
        {
            this.kontakty = new List<Kontakt>();
        }

        public void DodajKontakt(string nazwa, string numer)
        {
            kontakty.Add(new Kontakt(nazwa, numer));   
        }
        public void DodajKontakt()
        {
            Console.WriteLine("Dodaj nowy kontakt");
            Console.Write("Nazwa: ");
            string nazwa = Console.ReadLine();
            Console.Write("Numer: ");
            string numer = Console.ReadLine();
            kontakty.Add(new Kontakt(nazwa, numer));   
        }
        public int ZnajdzIndeksKontaktuPoNazwie(string nazwa)
        {
            int indeks = kontakty.FindIndex(k => k.Nazwa.Equals(nazwa));
            if (indeks >= 0)
            {
                return indeks;
            } else return -1 ;
        }
        public int ZnajdzIndeksKontaktuPoNumerze(string numer)
        {
            int indeks = kontakty.FindIndex(k => k.Numer.Equals(numer));
            if (indeks >= 0)
            {
                return indeks;
            } else return -1 ;
        }
        public Kontakt ZnajdzKontaktPoNazwie(string nazwa)
        {
            int index = ZnajdzIndeksKontaktuPoNazwie(nazwa);
            if (index == -1)
            {
                return null;
            }
            else
            {
                return this.kontakty[index];
            }
        }
        public Kontakt ZnajdzKontaktPoNazwie()
        {
            string szukany = Console.ReadLine();
            Kontakt znaleziony = ZnajdzKontaktPoNazwie(szukany);
            return znaleziony;
        }

        public Kontakt ZnajdzKontaktPoNumerze(string numer)
        {
            int index = ZnajdzIndeksKontaktuPoNumerze(numer);
            if (index == -1)
            {
                return null;
            }
            else
            {
                return this.kontakty[index];
            }
        }
        public Kontakt ZnajdzKontaktPoNumerze()
        {
            string szukany = Console.ReadLine();
            Kontakt znaleziony = ZnajdzKontaktPoNazwie(szukany);
            return znaleziony;
        }
        
        public void WyswietlWszytkie()
        {
            Console.WriteLine("---KONTAKTY---------------------------");
            foreach (var k in kontakty)
            {
                k.Wyswietl();
                Console.WriteLine("--------------------------------------");
            }

        }

        
    }
}