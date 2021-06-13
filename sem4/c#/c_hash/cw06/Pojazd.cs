using System;
using System.Collections.Generic;

namespace cw06
{
    
    public class Pojazd
    {
        public enum Naped
        {
            Elektryczny,
            Mechaniczny, // silniki spalinowe
            Manualny, //siła nóg ;)
            Hybrydowy,
            Ogniwa,
            Atomowy,
            PaliwoRakietowe
            
        }

        public enum Typ
        {
            Naziemy,
            Podziemny,
            Powietrzny,
            Kosmiczny,
            Nawodny,
            Podwodny
            
        }

        private string id;
        private string producent;
        private Typ typ;
        private Naped naped { get; set; }
        private double zasieg { get; set; }
        private double predkoscMaksymalna { get; set; }
        private int iloscPasazerow { get; set; }

        private static List<string> logKomunikatów;


        public static List<string> LogKomunikatów
        {
            get => logKomunikatów;
            set => logKomunikatów = value;
        }

        public Pojazd()
        {}
        public Pojazd(string id, string producent, Typ typ, Naped naped, double zasieg, double predkoscMaksymalna, int iloscPasazerow)
        {
            this.id = id;
            this.producent = producent;
            this.typ = typ;
            this.naped = naped;
            this.zasieg = zasieg;
            this.predkoscMaksymalna = predkoscMaksymalna;
            this.iloscPasazerow = iloscPasazerow;
            logKomunikatów = new List<string>();
        }
        
        // to jest typ zagnieżdżony w klasie bo tylko ona go używa, ale może byc też poza klasą
        public delegate void Komunikat(string s);

        // poniższa linia deklaruje zdarzenie w klasie
        public static event Komunikat wiadomosc;

        // a poniższa metoda służy do wygenerowania (wywołania) zdarzenia
        public void ObsłuzZdarzenie(string e)
        {
            if (wiadomosc != null) wiadomosc(e); 
        }
        
        public void Wyslij(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }
        public void Loguj(string wiadomosc)
        {
            logKomunikatów.Add(wiadomosc);
        } 
    }
}