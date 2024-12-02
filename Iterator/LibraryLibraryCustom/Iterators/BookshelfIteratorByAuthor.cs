using System.Collections.Generic;
using System.Linq;

namespace LibraryLibrary.Iterators
{
    public class BookshelfIteratorByAuthor : IIterator<Book>
    {
        private Bookshelf _bookshelf = new Bookshelf();
        private int _currentIndex = 0;

        public BookshelfIteratorByAuthor(Bookshelf bookshelf)
        {
            IEnumerable<Book> books = bookshelf.Books.OrderBy(book => book.Author);

            foreach (Book book in books)
            {
                _bookshelf.Add(book);
            }

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

