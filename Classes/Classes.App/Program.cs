using System;
using System.Collections.Generic;

namespace Classes.App;

class Program
{
    static void Main(string[] args)
    {
        var app = new App();

        do
        {
            app.Run();
            Console.WriteLine("Press 'Y' to run the program again or any other key to exit.");
        } while (Console.ReadLine().Equals("Y", StringComparison.CurrentCultureIgnoreCase));
    }
}

public class App
{
    public void Run()
    {
        // Test the Book class
        Book book1 = new Book("C# Programming", "John Smith", 400, 2020);
        Book book2 = new Book("Learn Python", "Jane Doe", 250, 2018);

        Console.WriteLine(book1.GetBookInfo());
        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine($"Is '{book1.Title}' a thick book? {book1.IsThickBook()}");

        // Test the Library class
        Library library = new Library("City Library");
        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("All books in the library:");
        foreach (var book in library.GetAllBooks())
        {
            Console.WriteLine(book.GetBookInfo());
        }

        library.RemoveBook("Learn Python");

        Console.WriteLine("Books after removal:");
        foreach (var book in library.GetAllBooks())
        {
            Console.WriteLine(book.GetBookInfo());
        }

        var foundBook = library.FindBookByTitle("C# Programming");
        if (foundBook != null)
        {
            Console.WriteLine($"Found book: {foundBook.GetBookInfo()}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int PublishedYear { get; set; }

    // TODO: Implement the constructor
    // TODO: Implement the GetBookInfo method
    // TODO: Implement the IsThickBook method
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    // TODO: Implement the constructor
    // TODO: Implement the AddBook method
    // TODO: Implement the RemoveBook method
    // TODO: Implement the FindBookByTitle method
    // TODO: Implement the GetAllBooks method
}

