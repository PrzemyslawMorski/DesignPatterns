using System.Threading;

namespace Observer
{
    public class GetTheStock
    {
        private string stock;
        private double price;
        private ISubject stockGrabber;
        public GetTheStock(ISubject stockGrabber, int newStartTime, string newStock, double newPrice)
        {
            this.stockGrabber = stockGrabber;
            stock = newStock;
            price = newPrice;
        }
        public void Run()
        {
            for (int i = 1; i <= 20; i++)
            {
                try
                {
                    Thread.Sleep(2000);
                }
                catch (ThreadInterruptedException)
                { }
                price = (new System.Random().NextDouble() * 0.06) - .03;
                var stockGrabberAsStockGrabber = stockGrabber as StockGrabber;
                if (stockGrabberAsStockGrabber != null)
                {
                    if (stock == "IBM") stockGrabberAsStockGrabber.IbmPrice = price;
                    if (stock == "AAPL") stockGrabberAsStockGrabber.AaplPrice = price;
                    if (stock == "GOOG") stockGrabberAsStockGrabber.GoogPrice = price;
                    System.Console.WriteLine("{0}: {1}", stock, price);
                    stockGrabberAsStockGrabber.NotifyObservers();
                }

            }
        }
    }
}