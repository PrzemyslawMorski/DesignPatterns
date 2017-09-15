using System.Collections.Generic;

namespace Observer
{
    public class StockGrabber : ISubject
    {
        List<IObserver> observers;


        public StockGrabber()
        {
            observers = new List<IObserver>();
        }

        public double GoogPrice { get; set; }
        public double AaplPrice { get; set; }
        public double IbmPrice { get; set; }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(IbmPrice, AaplPrice, GoogPrice);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            int observerIndex = observers.IndexOf(observer);
            if (observerIndex != -1)
            {
                observers.Remove(observer);
                System.Console.WriteLine("Observer {0} removed.", observerIndex);
            }
        }
    }
}