using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_If_Else_Statement
{
    internal class Program
    {
        static int number;
        static void Main(string[] args)
        {
            // Tugas Ramadian X RPL I ❤
            Console.WriteLine("Program Menentukan Nilai Ganjil/Genap!");
            number = int.Parse(Console.ReadLine());
            numberChecker(number);

            Console.ReadLine();
        }

        static int numberChecker(int number) 
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
        }
    }
}
