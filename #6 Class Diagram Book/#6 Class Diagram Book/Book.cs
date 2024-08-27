using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Class_Diagram_Book
{
    public class Book
    {
        private string isbn, name;
        private Author author;
        private double price;
        private int qty = 0;
        public Book(string isbn, string name, Author author, double price, int qty)
        {
            this.isbn = isbn;
            this.name = name;
            this.author = author;
            this.price = price;
            this.qty = qty;
        }
        public string getIsbn()
        {
            return isbn;
        }
        public string getName()
        {
            return name;
        }
        public Author getAuthor() 
        {
            return author;
        }
        public double getPrice()
        {
            return price;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getQty()
        {
            return qty;
        }
        public void setQty(int qty)
        {
            this.qty = qty;
        }
        public string getAuthorName()
        {
            return author.getName();
        }
        public string toString()
        {
            return $"Book[isbn={getIsbn()}, name={getName()}, {author.toString()}, price={getPrice()}, qty={getQty()}]";
        }
    }
}
