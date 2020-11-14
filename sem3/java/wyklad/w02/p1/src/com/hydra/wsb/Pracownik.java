package sem3.java.wyklad.w02.p1.src.com.hydra.wsb;

public class Pracownik
{
    // to są pola klasy
    // każdego pola możemy zdefinować jego dośtepność
    // jeżeli pole jest prywatne to jest dostępne tylko w tej klasie
    private String imie;
    private String nazwisko;
    private int id;
    // Konstruktor
    public Pracownik(String _imie, String _nazwisko, int _id)
    {
        imie=_imie;
        nazwisko=_nazwisko;
        id=_id;
    }
    public Pracownik(String imie, String nazwisko)
    {
        this.imie=imie;
        this.nazwisko=nazwisko;
        this.id=1;
    }
    // Konstruktor domniemany/domyslny
    public Pracownik()
    {
        this.imie="";
        this.nazwisko="";
        this.id=1;
    }
    // jeżeli coś jest publiczne to moze być używane wszędzie
    public void Wyswietl()
    {
        System.out.println("Id="+this.id);
        System.out.println("Imie="+this.imie);
        System.out.println("Nazwisko="+this.nazwisko);
    }

    public static void main(String[] args) 
    {
        System.out.println("Pracownik - program");
        Pracownik p1 = new Pracownik("Adam", "Kot", 1);
        p1.Wyswietl();
    }
}
