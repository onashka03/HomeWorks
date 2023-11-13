using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вазифа_3
{
    class library
    {
        public string fullName;
        public int readerNumber;
        public string faculty;
        public DateTime dateOfBirth;
        public string phoneNumber;

        public library(string fullName, int readerNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.fullName = fullName;
            this.readerNumber = readerNumber;
            this.faculty = faculty;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }

        public void takeBook(int numberOfBooks)
        {
            Console.WriteLine(this.fullName + " взял " + numberOfBooks + " книги");
        }

        public void takeBook(params string[] bookNames)
        {
            Console.Write(this.fullName + " взял книги: ");
            for (int i = 0; i < bookNames.Length; i++)
            {
                Console.Write(bookNames[i]);
                if (i < bookNames.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public void takeBook(params Book[] books)
        {
            Console.Write(this.fullName + " взял книги: ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write(books[i].Title);
                if (i < books.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public void returnBook(int numberOfBooks)
        {
            Console.WriteLine(this.fullName + " вернул " + numberOfBooks + " книги");
        }

        public void returnBook(params string[] bookNames)
        {
            Console.Write(this.fullName + " вернул книги: ");
            for (int i = 0; i < bookNames.Length; i++)
            {
                Console.Write(bookNames[i]);
                if (i < bookNames.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public void returnBook(params Book[] books)
        {
            Console.Write(this.fullName + " вернул книги: ");
            for (int i = 0; i < books.Length; i++)
            {
                Console.Write(books[i].Title);
                if (i < books.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }

  public  class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
