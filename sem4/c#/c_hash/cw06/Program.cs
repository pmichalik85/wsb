using System;
using System.Runtime.CompilerServices;

namespace cw06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] dane = {10.1, 12.1, 17, 1};
            Wektor w = new Wektor(dane);
            Console.WriteLine("Suma: {0}", w.Suma());
            Console.WriteLine("Średnia: {0}", w.Srednia());
            Console.WriteLine("Max {0}", w.Max());
        }
    }
};