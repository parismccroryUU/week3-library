using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private int _isbn;
        // Public properties
        public string Title
        {
            get { return _title; }
            set { _title = value; } // Private setter makes read-only
        }
        public string Author
        {
            get { return _author; }  // get method
            set
            { // Check if the author name contains any numbers
                if (!value.Any(char.IsDigit))
                {
                    _author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return _isbn.ToString(); }  // get method
            set
            {
                if (value != "")
                {
                    _isbn = int.Parse(value);
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be empty.");
                }
            }
        }
        // Constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN.ToString();
        }
        // Methods

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
