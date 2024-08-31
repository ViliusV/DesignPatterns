namespace Iterator
{
	internal interface IAggregate
    {
        IIterator CreateIterator();
        void Insert(int value);
    }
}