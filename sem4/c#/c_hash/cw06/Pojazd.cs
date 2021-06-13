using System;
using System.Collections.Generic;

namespace cw06
{
    public abstract class Pojazd

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

    public string Id
    {
        get => id;
        set => id = value;
    }

    private string producent { get; set; }
    private Typ typ;
    private Naped naped { get; set; }
    private double zasieg { get; set; }
    private double predkoscMaksymalna { get; set; }
    private int iloscPasazerow { get; set; }

    public Pojazd()
    {
    }

    public Pojazd(string id, string producent, Typ typ, Naped naped, double zasieg, double predkoscMaksymalna,
        int iloscPasazerow)
    {
        this.id = id;
        this.producent = producent;
        this.typ = typ;
        this.naped = naped;
        this.zasieg = zasieg;
        this.predkoscMaksymalna = predkoscMaksymalna;
        this.iloscPasazerow = iloscPasazerow;
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

    public abstract void Przemieszczaj();
    
    public void Wyslij(string wiadomosc)
    {
        Console.WriteLine(wiadomosc);
    }
    
    }
}