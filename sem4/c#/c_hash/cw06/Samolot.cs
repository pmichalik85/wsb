using System;
using System.Runtime.Remoting;

namespace cw06
{
    public class Samolot: Pojazd
    {
        private double gpsL { get; set; }
        private double gpsW { get; set; }
        private double pojemnoscLukuCargo { get; set; }
        
        public Samolot(string id, string producent, Typ typ, Naped naped, double zasieg, double predkoscMaksymalna, int iloscPasazerow, double gpsL,double gpsW, double pojemnoscLukuCargo)
            : base(id, producent, typ, naped, zasieg, predkoscMaksymalna, iloscPasazerow)
        {
            this.gpsL = gpsL;
            this.gpsW = gpsW;
            this.pojemnoscLukuCargo = pojemnoscLukuCargo;
        }

        public string SOS(string id)
        {   
            //Console.WriteLine("Awaria samaolotu, obeecne polożenie: [{0}, {1}]", this.gpsL, this.gpsW);
            return String.Format("Awaria samaolotu, Lot {0}, obeecne polożenie: [{1}, {2}]", id, this.gpsL, this.gpsW);
        }

    } 
}