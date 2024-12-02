using LibraryLibrary;
using LibraryLibrary.Iterators;

namespace Library
{

    //Client Code
    public class Program
    {
        static void Main()
        {
            Bookshelf shelf = new Bookshelf();
            shelf.Add(new Book("Sécurité des Ascenseur", "Un type mort écrasé par un ascenseur"));
            shelf.Add(new Book("Les truites pour les nuls", "Fisherman Bob"));
            shelf.Add(new Book("ASP.NET Core", "Prateek Sahoo"));
            shelf.Add(new Book("Espionnage: Mode d'emploi", "Inconnu"));
            shelf.Add(new Book("Pause !", "Moi"));

            Console.WriteLine("\nFiltered by order:\n");

            foreach (Book b in shelf)
            {
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}");
            }


            Console.WriteLine("\nFiltered by author:\n");

            IEnumerator<Book> iteratorByAuthor = new BookshelfIteratorByAuthor(shelf);

            Book book;
            while (iteratorByAuthor.MoveNext())
            {
                book = iteratorByAuthor.Current;
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.ReadKey();
        }
    }
}
