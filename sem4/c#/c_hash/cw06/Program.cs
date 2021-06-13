using System;
using System.Runtime.CompilerServices;

namespace cw06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*double[] dane = {10.1, 12.1, 17, 1};
            Wektor w = new Wektor(dane);
            Console.WriteLi sne("Suma: {0}", w.Suma());
            Console.WriteLine("Średnia: {0}", w.Srednia());
            Console.WriteLine("Max {0}", w.Max());*/
            Samolot s = new Samolot("KRK12345","UBER", Pojazd.Typ.Powietrzny, Pojazd.Naped.Mechaniczny, 2000, 1000, 1000, 80.100, 15.12, 80);
            HulajnogaElektryczna h = new HulajnogaElektryczna("12312AKL098","UBER", Pojazd.Typ.Naziemy, Pojazd.Naped.Elektryczny, 50, 30, 1, "12345ABCD", HulajnogaElektryczna.Rozmiar.XL);
            Pojazd.wiadomosc += new Samolot.Komunikat(s.Wyslij);
            h.ObsłuzZdarzenie(h.NiskiStanBaterii());
            s.ObsłuzZdarzenie(s.SOS("IXP12345"));
            h.Napraw();
            s.Napraw();
            h.Przemieszczaj();
            s.Przemieszczaj();
        }
    }
};