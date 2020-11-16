using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5
{
    class Book
    {
        public string title { get; }
        public string author { get; }
        public double price { get; }
        static int counter;
        public string isbn { get; }
        DateTime date;
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            isbn = (counter++).ToString();
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return "\nTitle: " + title + "\nAuthor: " + author + "\nPrice: " + price+ "\nIsbn: " + isbn+ "\nDate: " + date;
        }
    }
    class BookLibrary
    {
        private List<Book> bookList = new List<Book>();
        private BookLibrary(){}
        private static BookLibrary _instance;
        public static BookLibrary GetInstance()
        {
            if (_instance == null)
                _instance = new BookLibrary();
            return _instance;
        }

        public bool Add(Book book)
        {
            if (!ContainsByIsbn(book))
            {
                bookList.Add(book);
                return true;
            }
            return false;
        }
        public void Remove(Book book)
        {
            bookList.Remove(book);
        }
        public bool Contains(Book book)
        {
            return bookList.Contains(book);
        }
        public bool ContainsByIsbn(Book book)
        {
            return bookList.Exists(elem => elem.isbn == book.isbn);
        }
        public Book FindByIsbn(string isbn)
        {
            return bookList.FirstOrDefault(elem => elem.isbn == isbn);
        }
        public Book FindByAuthor(string author)
        {
            return bookList.FirstOrDefault(elem => elem.author == author);
        }
        public Book FindByTitle(string title)
        {
            return bookList.FirstOrDefault(elem => elem.title == title);
        }
        public Book FindByPrice(double price)
        {
            return bookList.FirstOrDefault(elem => elem.price == price);
        }
        public void Print()
        {
            foreach (var elem in bookList) Console.WriteLine(elem.ToString());
        }

    }
}
