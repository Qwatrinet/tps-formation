using System;
using System.Collections;
using System.Collections.Generic;

namespace LibraryLibrary.Iterators
{
    public class BookshelfIteratorByOrder : IEnumerator<Book>
    {
        private Bookshelf _bookshelf;
        private int _currentIndex = -1;

        public BookshelfIteratorByOrder(Bookshelf bookshelf)
        {
            _bookshelf = bookshelf;
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
