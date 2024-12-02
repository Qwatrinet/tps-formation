using LibraryLibrary;
using LibraryLibrary.Iterators;

namespace LibraryCustom
{
    public class Program
    {
        static void Main()
        {
            var shelf = new Bookshelf();
            shelf.Add(new Book("Sécurité des Ascenseur", "Un type mort écrasé par un ascenseur"));
            shelf.Add(new Book("Les truites pour les nuls", "Fisherman Bob"));
            shelf.Add(new Book("ASP.NET Core", "Prateek Sahoo"));
            shelf.Add(new Book("Espionnage: Mode d'emploi", "Inconnu"));
            shelf.Add(new Book("Pause !", "Moi"));

            var iterator = shelf.CreateIterator();
            while (iterator.HasNext())
            {
                var book = iterator.Next();
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("\nFiltered by author:\n");
            var iterator2 = new BookshelfIteratorByAuthor(shelf);

            while (iterator2.HasNext())
            {
                var book = iterator2.Next();
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
            }

            Console.ReadKey();
        }
    }
}
