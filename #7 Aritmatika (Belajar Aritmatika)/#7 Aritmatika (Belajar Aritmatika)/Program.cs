using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _7_Aritmatika__Belajar_Aritmatika_
{
    internal class Program
    {
        // Tugas Ramadian
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            NumOperation numOperation = new NumOperation();

            int num1 = userService.numberInput(1);
            int num2 = userService.numberInput(2);

            Console.WriteLine(".: Perhitungan Aritmatika Sederhana --:.");

            Console.WriteLine(">> Bilangan Pertama          :  " + num1);
            Console.WriteLine(">> Bilangan Kedua            :  " + num2);
            Console.WriteLine("1. Penjumlahan dua bilangan  :  " + numOperation.summation(num1, num2));
            Console.WriteLine("2. Pengurangan dua bilangan  :  " + numOperation.subtraction(num1, num2));
            Console.WriteLine("3. Perkalian dua bilangan    :  " + numOperation.multiplication(num1, num2));
            Console.WriteLine("4. Pembagian dua bilangan    :  " + numOperation.division(num1, num2));
            Console.WriteLine("5. Sisa Pembagian            :  " + numOperation.modulo(num1, num2));
        }
    }

    public class UserService
    {
        public int numberInput(int choice)
        {
            if (choice == 1)
            {
                Console.Write("Masukan Input Bilangan Pertama   : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                return num1;
            }
            else
            {
                Console.Write("Masukan Input Bilangan Kedua     : ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                return num2;
            }
        }
    }

    public class NumOperation 
    {
        public int summation(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int subtraction(int num1, int num2)
        { 
            return (num1 - num2);
        }
        public int multiplication(int num1, int num2)
        {
            return (num1 * num2);
        }
        public double division(double num1, double num2) 
        {
            return (num1/num2);
        }
        public int modulo(int num1, int num2)
        {
            return (num1 % num2);
        }
    }
}
