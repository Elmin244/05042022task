using System;

namespace _05042022task
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.AuthorName = "Nizami Gencevi";
            book1.Name = "Yeddigozel!";
            book1.Price =39.9;
            book1.Genre = Genre.Genre1;
            Console.WriteLine("\n================================\n");
            Book book2 = new Book();
            book2.AuthorName = "Uilyam Qoldinq";
            book2.Name = "Milçəklər tanrısı";
            book2.Price = 42.2;
            book2.Genre = Genre.Genre2;
            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);
            Book findBook = library.FindBookByNo(1);
            Console.WriteLine($"Name : {findBook.Name}-No: {findBook.No}");
        }
    }
}
