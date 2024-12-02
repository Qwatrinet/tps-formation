using LibraryLibrary.Iterators;
using System.Collections;
using System.Collections.Generic;

namespace LibraryLibrary
{
    public class Bookshelf : IEnumerable<Book>
    {
        private List<Book> _books = new List<Book>();

        public int Count { get { return _books.Count; } }

        public List<Book> Books { get => _books; set => _books = value; }

        public Book this[int key]
        {
            get => _books[key];
            set => _books[key] = value;
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new BookshelfIteratorByOrder(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BookshelfIteratorByOrder(this);
        }
    }
}
