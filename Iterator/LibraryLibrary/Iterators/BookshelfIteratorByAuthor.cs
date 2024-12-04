using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LibraryLibrary.Iterators
{
    public class BookshelfIteratorByAuthor : IEnumerator<Book>
    {
        private Bookshelf _bookshelf = new Bookshelf();
        private int _currentIndex = -1;

        public BookshelfIteratorByAuthor(Bookshelf bookshelf)
        {
            IEnumerable<Book> books = bookshelf.OrderBy(book => book.Author);

            foreach (Book book in books)
            {
                _bookshelf.Add(book);
            }
        }

        public Book Current
        {
            get
            {
                try
                {
                    return _bookshelf[_currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return _bookshelf[_currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        { }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _bookshelf.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}

