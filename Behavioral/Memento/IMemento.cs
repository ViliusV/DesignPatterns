namespace Memento
{
	internal interface IMemento
    {
        string GetState();
        DateTimeOffset GetCreatedDate();
    }
}
