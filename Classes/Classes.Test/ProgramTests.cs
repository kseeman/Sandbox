namespace Classes.Test;

public class ProgramTests
    {
        [Fact]
        public void TestBookClass()
        {
            Book book = new Book("C# Programming", "John Smith", 400, 2020);
            Assert.Equal("C# Programming", book.Title);
            Assert.Equal("John Smith", book.Author);
            Assert.Equal(400, book.Pages);
            Assert.Equal(2020, book.PublishedYear);
            Assert.Equal("Title: C# Programming, Author: John Smith, Published Year: 2020", book.GetBookInfo());
            Assert.True(book.IsThickBook());
        }

        [Fact]
        public void TestLibraryClass()
        {
            Library library = new Library("City Library");
            Assert.Equal("City Library", library.Name);
            Assert.Equal(0, library.Books.Count);

            Book book1 = new Book("C# Programming", "John Smith", 400, 2020);
            Book book2 = new Book("Learn Python", "Jane Doe", 250, 2018);

            library.AddBook(book1);
            library.AddBook(book2);
            Assert.Equal(2, library.Books.Count);

            var foundBook = library.FindBookByTitle("C# Programming");
            Assert.NotNull(foundBook);
            Assert.Equal("C# Programming", foundBook.Title);

            library.RemoveBook("Learn Python");
            Assert.Equal(1, library.Books.Count);
            Assert.Null(library.FindBookByTitle("Learn Python"));
        }
    }