using System;
using System.Reflection;

namespace zad3_1_kontakty
{
    public class Kontakt
    {
        private string nazwa; // { get; set; }
        private string numer; // { get; set; }

        public Kontakt(string nazwa, string numer)
        {
            this.nazwa = nazwa;
            this.numer = numer;
        }


        public string Nazwa
        {
            get => nazwa;
            set => nazwa = value;
        }

        public string Numer
        {
            get => numer;
            set => numer = value;
        }

        public void Wyswietl()
        {

            Console.WriteLine("Nazwa: {0}", this.Nazwa);
            Console.WriteLine("Numer: {0}", this.Numer);

        }

    }

}