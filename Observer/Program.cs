using System;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver();

            stockGrabber.Register(observer1);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.AaplPrice = 197.00;
            stockGrabber.GoogPrice = 197.00;

            stockGrabber.NotifyObservers();

            StockObserver observer2 = new StockObserver();
            stockGrabber.Register(observer2);

            stockGrabber.IbmPrice = 297.00;
            stockGrabber.AaplPrice = 297.00;
            stockGrabber.GoogPrice = 297.00;

            stockGrabber.Unregister(observer1);

            stockGrabber.NotifyObservers();

            var getIBM = new GetTheStock(stockGrabber, 2, "IBM", 197.00);
            var getAAPL = new GetTheStock(stockGrabber, 2, "AAPL", 677.60);
            var getGOOG = new GetTheStock(stockGrabber, 2, "GOOG", 676.40);
            new Thread(new ThreadStart(getIBM.Run)).Start();
            new Thread(new ThreadStart(getAAPL.Run)).Start();
            new Thread(new ThreadStart(getGOOG.Run)).Start();
        }
    }
}
