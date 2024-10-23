using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _13_If_Else_Statement
{
    internal class Program
    {
        static string username;
        static void Main(string[] args)
        {
            // Tugas Ramadian X RPL I ❤
            Console.WriteLine("Masukan username :");
            username = Console.ReadLine();
            sayHello(username);

            Console.ReadLine();
        }

        static void sayHello(string username)
        {
            if (username == "orangganteng")
            {
                Console.WriteLine("Selamat datang");
            }

            Console.WriteLine("lu gadiajak wlee");

            string result = if (username == "aku") ? "" : ""
        }


        /*static int numberChecker(int number) 
        {
            if (number % 2 == 0 || number % 4 == 0 && number % 3 > 0 )
            {
                Console.WriteLine($"Angka {number} merupakan angka genap");
                return number;
            }  else if (number % 2 > 0 || number % 4 > 0 && number % 3 == 0)
            {
                Console.WriteLine($"Angka {number} merupakan angka ganjil");
                return number;
            }
             else
            {
                return number;
            }
        }*/
    }
}
