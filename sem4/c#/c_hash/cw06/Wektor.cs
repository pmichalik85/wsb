using System;
using System.Linq;

namespace cw06
{
    public class Wektor : IStatystyka
    {
        private int n;
        private double[] dane;

        public Wektor(int n)
        {
            this.n = n;
            this.dane = new double[this.n];
            Console.WriteLine("Utworzono pusty wektor {0}-elementowy", this.n);
        }

        public Wektor(double[] dane)
        {
            this.n = dane.Length;
            this.dane = new double[this.n];
            for (int i = 0; i < this.n; i++)
            {
                this.dane[i] = dane[i];
            }
        }

        public Wektor(int n, double a, double b)
        {
            this.n = n;
            Random rand = new Random();
            this.dane = new double[this.n];
            for (int i = 0; i < n; i++)
            {
                this.dane[i] = rand.Next(Convert.ToInt32(a), Convert.ToInt32(b));
            }
        }
        
        public double[] GetDane()
        {
            return dane;
        }


        public void DodajWspolrzedne()
        {
            Console.WriteLine("Podaj wspolrzedne wektora {0}-elementowy", this.n);
            for (int i = 0; i < this.dane.Length; i++)
            {
                this.dane[i] = double.Parse(Console.ReadLine());
            }
        }

        public Wektor Utworz()
        {
            {
                Console.WriteLine("Podaj wspolrzedne wektora: ");
                string wymiar = Console.ReadLine();
                double[] wspolrzedne = new double[wymiar.Split().Length];
                for(int i = 0; i < wymiar.Length; i++)
                {
                    wspolrzedne[i] = double.Parse(wymiar.Split()[i]);
                }
                Wektor nowyWektor = new Wektor(wspolrzedne);
                return nowyWektor;
            }
        }

        public Wektor Dodaj(Wektor w)
        {
            Wektor suma = new Wektor(this.n);
            for (int i = 0; i < this.dane.Length; i++)
            {
                this.dane[i] += w.GetDane()[i];
            }
            return suma;
        }
        
        public void Show()
        {
            string wsp = "";
            string delimiter = ", ";
            for (int i = 0; i < this.n; i++)
            {
                if (i == n - 1)
                {
                    delimiter = "";
                }
                wsp += dane[i] + delimiter;
            }
            Console.Write("[{0}]", wsp);
        }

        public double SumaWspolrzednych()
        {
            double suma = 0;
            for (int i = 0; i < this.n; i++)
            {
                suma += dane[i];
            }
            return suma;
        }

        public double Suma()
        {
            double suma = 0;
            foreach (var e in this.dane)
            {
                suma += e;
            }

            return suma;
        }

        public double Srednia()
        {
            return this.Suma()/this.dane.Length;
        }

        public double Max()
        {
            return dane.Max();
        }
    }
}