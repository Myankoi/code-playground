using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook;

namespace oop_perpustakaan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Udah Gede Belom Mandi", "ciop", "ISBN H4H4H44S", true);
            Ebook ebook = new Ebook("petualangan mouse gaming", "cipicipi", "ISBN !@#!@#!@#", true, "https://bit.ly/asdfadsfa");
            
            book.bookInfo();
            Console.WriteLine();
            book.borrowBook();
            Console.WriteLine();

            ebook.bookInfo();
            Console.WriteLine();
            ebook.borrowBook();

            Console.WriteLine();
        }
    }
}
