namespace Observer
{
    internal interface IObserver
    {
        void Update(ISubject subject, string message);
    }
}