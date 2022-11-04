using System;

namespace Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int penPakets = int.Parse(Console.ReadLine());
            int markerPakets = int.Parse(Console.ReadLine());
            int litresCleaner = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            // calculate
            double PenPakets = penPakets * 5.80;
            double MarkerPakets = markerPakets * 7.20;
            double LitresCleaner = litresCleaner * 1.20;
            double pricePecentDiscount = PenPakets + MarkerPakets + LitresCleaner;
            double Discount = pricePecentDiscount - (pricePecentDiscount * percentDiscount / 100);
            // output

            Console.WriteLine(Discount);




        }
    }
}
