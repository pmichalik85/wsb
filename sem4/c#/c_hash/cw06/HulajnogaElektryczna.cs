using System;

namespace cw06
{
    public class HulajnogaElektryczna : Pojazd
    {
        public enum Rozmiar
        {
            S,
            M,
            XL
        }
        private string trackingId;
        private Rozmiar rozmiar;

        public HulajnogaElektryczna(string id, string producent, Typ typ, Naped naped, double zasieg, double predkoscMaksymalna, int iloscPasazerow,
             string trackingId, Rozmiar rozmiar) : base(id, producent, typ, naped, zasieg, predkoscMaksymalna, iloscPasazerow)
        {
            this.trackingId = trackingId;
            this.rozmiar = rozmiar;
        }
        
        public string NiskiStanBaterii()
        {   
            //Console.WriteLine("Awaria samaolotu, obeecne polożenie: [{0}, {1}]", this.gpsL, this.gpsW);
            return String.Format("Niski stan baterii w hulajnodze: {0}", this.trackingId);
        }
        
    }
}