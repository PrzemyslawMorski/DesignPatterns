using System;

namespace Observer
{
    public class StockObserver : IObserver
    {
        public double IbmPrice { get; set; }
        public double AaplPrice { get; set; }
        public double GoogPrice { get; set; }

        private static int ObserverIdTracker = 0;

        public int ObserverId { get; private set; }

        public StockObserver()
        {
            ObserverId = ObserverIdTracker++;
            System.Console.WriteLine("New observer with id: {0}", ObserverId);
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.GoogPrice = googPrice;
            this.AaplPrice = aaplPrice;
            this.IbmPrice = ibmPrice;

            printPrices();
        }

        private void printPrices()
        {
            System.Console.WriteLine("{0} IBM: {1} AAPL: {2} GOOG: {3}", ObserverId, IbmPrice, AaplPrice, GoogPrice);
        }
    }
}