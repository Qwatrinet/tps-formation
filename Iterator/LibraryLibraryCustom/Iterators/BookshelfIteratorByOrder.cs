using System.Linq;

namespace LibraryLibrary.Iterators
{
    public class BookshelfIteratorByOrder : IIterator<Book>
    {
        private Bookshelf _bookshelf;
        private int _currentIndex = 0;

        public BookshelfIteratorByOrder(Bookshelf bookshelf)
        {
            _bookshelf = bookshelf;
        }

        public bool HasNext()
        {
            return _currentIndex < _bookshelf.Count;
        }

        public Book Next()
        {
            return _bookshelf[_currentIndex++];
        }
    }
}
