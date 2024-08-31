using System.Collections.Generic;

namespace Iterator
{

	internal class ListAggregate : IAggregate
    {
        private List<int> collection;
        public ListAggregate()
        {
            collection = new List<int>();
        }
        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }
        public int Count
        {
            get { return collection.Count; }
        }
        public int this[int index]
        {
            get { return collection[index]; }
            set { collection.Insert(index, value); }
        }
        public void Insert(int value)
        {
            collection.Add(value);
        }
    }
}
