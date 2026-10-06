using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;
        private string iSBN;

        public string Title
        {
            get { return title; }
            set { title = value; } // Private setter makes read-only
        }
        public string Author
        {
            get { return author; }  // get method
            set
            { // Check if the author name contains any numbers
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            } 
        }
        public string ISBN
        {
            get { return iSBN; }  // get method
            set {
                if (value != "")
                {
                    iSBN = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be empty.");
                }
            }
        }

        // Constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
