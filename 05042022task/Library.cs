using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022task
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FilterByPrice(double MinPrice,double MaxPrice)
        {
            List<Book>newBook=Books.FindAll(book=> book.Price > minPrice && book.Price < maxPrice);
            return newBook;
           
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            List<Book> newBook = Books.FindAll(book => book.Genre == genre);
            return newBook;
        }
        public Book FindBookByNo(int No)
        {
            Book result = Books.Find(book => book.No == No);
            if (result == null)
                return null;
            else
                return result;
        }
        
    }
}
