using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    class Book
    {
        private string title;
        private string author;
        private string publisher;
        private string release_date;
        private int ISBN_number;
        /* Connection to other books */
        private Book next_book;
        private Book prev_book;

        
        /* Declare Properties */
        public string Title
        {
            get { return this.title; }
        }

        public string Author
        {
            get { return this.author; }
        }

        public string Publisher
        {
            get { return this.publisher; }
        }

        public string ReleaseDate
        {
            get { return this.release_date; }
        }

        public int ISBNNumber
        {
            get { return this.ISBN_number; }
        }

        public Book NextBook
        {
            get { return this.next_book; }
            set { this.next_book = value; }
        }

        public Book PrevBook
        {
            get { return this.prev_book; }
            set { this.prev_book = value; }
        }

        /* Declare Constructors */
        public Book()
            : this(null) 
        {

        }

        public Book(string title)
            : this (title, null)
        {

        }
        public Book(string title, string author)
            : this (title, author, null)
        {

        }

        public Book(string title, string author, string publisher)
            : this (title, author, publisher, null)
        {

        }

        public Book(string title, string author, string publisher, string release_date)
            : this (title, author, publisher, release_date, 0)
        {

        }

        public Book(string title, string author, string publisher, string release_date, int isbn_number)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.release_date = release_date;
            this.ISBN_number = isbn_number;
        }
        /* Declare Methods */
    }

    class BookManage
    {
        private Book BookHead;
        private Book BookEnd;
        /* Constructor */
        public BookManage()
        {
            this.BookHead = null;
            this.BookEnd = null;
        }

        /* Methods */
        public void AddBook(Book NewBook)
        {
            if (this.BookHead == null)
            {
                this.BookHead = NewBook;
                this.BookEnd = NewBook;
                NewBook.PrevBook = null;
            }
            else
            {
                this.BookEnd.NextBook = NewBook;
                NewBook.PrevBook = this.BookEnd;
                this.BookEnd = NewBook;
            }
        }

        public void RemoveBook(string Name)
        {
            Book tempBook = null;
            tempBook = this.BookHead;
            while (tempBook != null)
            {
                if (Name.Equals(this.BookHead.Title) == true)
                {
                    tempBook.PrevBook.NextBook = tempBook.NextBook;
                    tempBook.NextBook.PrevBook = tempBook.PrevBook;
                    tempBook.NextBook = null;
                    tempBook.PrevBook = null;
                    break;
                }
                tempBook = tempBook.NextBook;
            }
        }

        public Book SearchBook(string name)
        {
            Book tempBook = null;
            if (name != null)
            {
                tempBook = this.BookHead;
                while (tempBook != null)
                {
                    if (name.Equals(this.BookHead.Title) == true)
                    {
                        tempBook.PrevBook.NextBook = tempBook.NextBook;
                        tempBook.NextBook.PrevBook = tempBook.PrevBook;
                        tempBook.NextBook = null;
                        tempBook.PrevBook = null;
                        break;
                    }
                    tempBook = tempBook.NextBook;
                }
            }

            return tempBook;
        }
    }

    class Library
    {
        private string name;
        private string address;
        private BookManage ListBook;
        
        /* Properties */
        public string Name
        {
            get { return this.name; }
        }

        public string Address
        {
            get { return this.address; }
        }

        /* Constructor */
        public Library(string name, string address)
        {
            this.name = name;
            this.address = address;
            ListBook = new BookManage();
        }
        /* Methods */
        public void AddBook(Book NewBook)
        {
            this.ListBook.AddBook(NewBook);
        }

        public Book BorrowBook(string name)
        {
            return this.ListBook.SearchBook(name);
        }

        public void DeleteBook(string name)
        {
            this.ListBook.RemoveBook(name);
        }

        public void BookInfo(string name)
        {
            Book FindBook = null;
            FindBook = this.ListBook.SearchBook(name);
            if (FindBook != null)
            {
                Console.WriteLine("Book Info");
                Console.WriteLine("Title : {0}", FindBook.Title);
                Console.WriteLine("Author : {0}", FindBook.Author);
                Console.WriteLine("Publisher : {0}", FindBook.Publisher);
                Console.WriteLine("Release date : {0}", FindBook.ReleaseDate);
                Console.WriteLine("IDBN number : {0}", FindBook.ISBNNumber);
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}
