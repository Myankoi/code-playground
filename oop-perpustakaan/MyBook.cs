using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    internal class MyBook
    {
    }
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Status { get; set; }

        public Book(string name, string author = "", string isbn = "" , bool status = false)
        {
            Name = name;
            Author = author;
            Isbn = isbn;
            Status = status == true ? "Available" : "Not Available";
        }

        public void bookInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Isbn: " + Isbn);
            Console.WriteLine("status: " + Status);
        }

        public void borrowBook()
        {
            if (Status != "Available")
            {
                Console.WriteLine("Sorry this book is not available.");
            } else
            {
                Console.WriteLine("Enjoy hahahihi.");
                Status = "Not Available";
            }
        }

        public void returnBook()
        {
            if (Status != "Not Available")
            {
                Console.WriteLine("This book already in library.");
            } else
            {
                Console.WriteLine("ihiw");
                Status = "Available";
            }
        }
    }

    public class Ebook : Book
    {
        public string DownloadUrl { get; set; }

        public Ebook(string name, string author, string isbn, bool status, string downloadUrl)
            : base(name, author, isbn, status)
        {
            DownloadUrl = downloadUrl;
        }

        new public void borrowBook()
        {
            if (Status != "Available")
            {
                Console.WriteLine("Sorry the downloadURL is not available.");
            }
            else
            {
                Console.WriteLine("Enjoy hahahihi. Download: " + DownloadUrl);
                Status = "Not Available";
            }
        }

        new public void returnBook()
        {
            if (Status != "Not Available")
            {
                Console.WriteLine("This book already in return.");
            }
            else
            {
                Console.WriteLine("Tengkyu");
                Status = "Available";
            }
        }
    }
}
