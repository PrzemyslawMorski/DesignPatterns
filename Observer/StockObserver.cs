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
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.GoogPrice = googPrice;
            this.AaplPrice = aaplPrice;
            this.IbmPrice = ibmPrice;
        }
    }
}