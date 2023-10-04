using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Classes
{
    internal class Book
    {
        public string title;
        public string author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine();
        }
    }

    class BookStore
    {
        private Book[] books;
        private int bookCount;

        public BookStore(int capacity)
        {
            books = new Book[capacity];
            bookCount = 0;
        }

        public int GetBookCount()
        {
            return bookCount;
        }

        public void Add(Book book)
        {
            if(bookCount< books.Length)
            {
                books[bookCount] = book;
                bookCount++;
            }
        }
        public void RemoveBook(string Title)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].title.Equals(Title, StringComparison.OrdinalIgnoreCase))
                {
                    // Shift books to fill the gap
                    for (int j = i; j < bookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    bookCount--;
                    Console.WriteLine($"{Title} removed from the bookstore.");
                    
                }
            }
            Console.WriteLine($"Book with title '{Title}' not found in the bookstore.");
        }
        public void DisplayAllBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("The bookstore is empty.");
            }
            else
            {
                Console.WriteLine("Books in the Bookstore:");
                for (int i = 0; i < bookCount; i++)
                {
                    books[i].DisplayBookDetails();
                }
            }
        }

    }

    class Program3
    {
        static void Main()
        {
            // Create a bookstore with a maximum capacity of 5 books
            BookStore bookstore = new BookStore(5);

            // Add books to the bookstore
            Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger", 12.99);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 14.95);
            Book book3 = new Book("1984", "George Orwell", 9.99);
            bookstore.Add(book1);
            bookstore.Add(book2);
            bookstore.Add(book3);

            // Display all books in the bookstore
            bookstore.DisplayAllBooks();

            // Remove a book from the bookstore
            bookstore.RemoveBook("To Kill a Mockingbird");

            // Display the updated list of books
            bookstore.DisplayAllBooks();

            Console.ReadLine(); // Keep the console window open
        }
    }
}
