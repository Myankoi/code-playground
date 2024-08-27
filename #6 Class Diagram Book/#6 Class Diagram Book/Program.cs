using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Class_Diagram_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Author class
            Author a1 = new Author("Tan Ah Teck", "ahteck@nowhere.com");
            Console.WriteLine(a1.toString());

            a1.setEmail("ahteck@somewhere.com");
            Console.WriteLine(a1.toString());
            Console.WriteLine("name is: " + a1.getName());
            Console.WriteLine("email is: " + a1.getEmail());

            // Test Book class
            Book b1 = new Book("12345", "Java for dummies", a1, 8.8, 88);
            Console.WriteLine(b1.toString());

            b1.setPrice(9.9);
            b1.setQty(99);
            Console.WriteLine(b1.toString());
            Console.WriteLine("isbn is: " + b1.getIsbn());
            Console.WriteLine("name is: " + b1.getName());
            Console.WriteLine("price is: " + b1.getPrice());
            Console.WriteLine("qty is: " + b1.getQty());
            Console.WriteLine("author is: " + b1.getAuthor());  // Author's toString()
            Console.WriteLine("author's name: " + b1.getAuthorName());
            Console.WriteLine("author's name: " + b1.getAuthor().getName());
            Console.WriteLine("author's email: " + b1.getAuthor().getEmail());
        }
    }
}
