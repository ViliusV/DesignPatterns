namespace Iterator
{
	internal interface IIterator
    {
        bool MoveNext();
        int? GetCurrent();
    }
}
