namespace LibraryLibrary
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
