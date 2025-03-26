using System.Collections;
using System.Collections.Generic;
namespace _26_03_2025;
public class Library : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();
    Dictionary<string, Book> dictionary = new Dictionary<string, Book>();    
    HashSet<string> autori = ["autore1", "peppino", "autore3"];

    
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Implementazione dell'iteratore di base per scorrere tutti i libri
    public IEnumerator<Book> GetEnumerator()
    {
        foreach (var book in books)
        {
            yield return book;
        }
    }

    // Implementazione esplicita per IEnumerable (non generico)
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // ... (Altri metodi e iterator da inventare da mettere qui)
    public IEnumerable<Book> GetBooksByAuthor(string author)
    {
        foreach (var book in books)
        {
            if (book.Author.ToLower() == author.ToLower())
            {
                yield return book;
            }
        }
    }
    public IEnumerable<Book> GetBooksByISBN(string isbn)
    {
        foreach (var book in books)
        {
            if (book.ISBN.ToLower() == isbn.ToLower())
            {
                yield return book;
            }
        }
    }
    public IEnumerable<Book> GetBooksPublishedAfterYear(int year)
    {
        foreach (var book in books)
        {
            if (book.PublicationYear > year)
            {
                yield return book;
            }
        }
    }
    public IEnumerable<string> GetBookTitles()
    {
        foreach (var book in books)
        {
            yield return book.Title;
        }
    }
    public IEnumerable<Book> GetBooksByYear(Library libreria, int year)
    {
        foreach (var book in libreria)
        {
            if (book.PublicationYear == year)
            {
                yield return book;
            }
        }
    }
}