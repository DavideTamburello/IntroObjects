using _26_03_2025;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("titolo1", "peppino", "isbn1", 2021);
        Book book2 = new Book("titolo2", "peppino", "isbn2", 2022);
        Book book3 = new Book("titolo3", "autore3", "isbn3", 2023);

        Library libreria = new Library();
        libreria.AddBook(book1);
        libreria.AddBook(book2);
        libreria.AddBook(book3);

        var a = libreria.GetBooksPublishedAfterYear(2021);
        Console.WriteLine("GetBooksPublishedAfterYear(2021)");
        foreach (var book in a)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();

        a = libreria.GetBooksByAuthor("peppino");
        Console.WriteLine("GetBooksByAuthor(\"peppino\")");
        foreach (var book in a)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();

        var b = libreria.GetBookTitles();
        Console.WriteLine("GetBookTitles()");
        foreach (var book in b)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();

        a = libreria.GetBooksByYear(libreria, 2022);
        Console.WriteLine("GetBooksByYear(libreria, 2022)");
        foreach (var book in a)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
    }
    
}