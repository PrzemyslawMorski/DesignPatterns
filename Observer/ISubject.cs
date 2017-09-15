namespace Observer
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);

        void NotifyObservers();
    }
}