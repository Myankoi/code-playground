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
        static void Main(string[] args)
        {
            // Tugas Ramadian X RPL I ❤
            Tugas1();
            Tugas2();
            Tugas3();

            Console.ReadLine();
        }

        static void Tugas1()
        {
            Console.Write("Masukan username : ");
            string username = Console.ReadLine();

            if (username == "saya")
            {
                Console.WriteLine("Halo saya");
                return;
            }

            Console.WriteLine("Wleee gadiajak");
            Console.WriteLine("Klik enter untuk mengulang");
            Console.ReadLine();
            Console.Clear();
            Tugas1();
        }

        static void Tugas2()
        {
            Console.Write("Coba Rating dari 1-100: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int rate);

            if (isValid)
            {
                if (rate >= 80 && rate <= 100)
                {
                    Console.WriteLine("Sangat Keren");
                    return;
                }
                else if (rate >= 60 && rate <= 79)
                {
                    Console.WriteLine("Keren");
                    return;
                } else if (rate < 60){
                    Console.WriteLine("U gabelajar");
                }
                
                else
                {
                    Console.WriteLine("Kamu Anomali");
                    Console.WriteLine("Klik enter untuk mengulang");
                    Console.ReadLine();
                    Console.Clear();
                    Tugas2();
                }               
            }
            else if ( rate < 0 )
            {
                Console.WriteLine("Angka tidak valid");
                Console.WriteLine("Klik enter untuk mengulang");
                Console.ReadLine();
                Console.Clear();
                Tugas2();
            } else
            {
                Console.WriteLine("Angka tidak valid");
                Console.WriteLine("Klik enter untuk mengulang");
                Console.ReadLine();
                Console.Clear();
                Tugas2();
            }
        }

        static void Tugas3()
        {
            Console.Write("Masukan total belanja: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int total);

            if (isValid)
            {
                if (total >= 500000)
                {
                    Console.WriteLine("Anda mendapatkan diskon 25%");
                    return;
                } else if (total >= 250000 && total < 500000)
                {
                    Console.WriteLine("Anda mendapatkan diskon 15%");
                    return;
                } else if (total >= 100000 && total < 250000)
                {
                    Console.WriteLine("Anda mendapatkan diskon 10%");
                }
                else
                {
                    Console.WriteLine("Anda mendapatkan diskon 5%");
                }

            } else if (total < 0)
            {
                Console.WriteLine("Angka tidak valid");
                Console.WriteLine("Klik enter untuk mengulang");
                Console.ReadLine();
                Console.Clear();
                Tugas3();
            } else
            {
                Console.WriteLine("Angka tidak boleh negatif");
                Console.WriteLine("Klik enter untuk mengulang");
                Console.ReadLine();
                Console.Clear();
                Tugas3();
            }
        }
    }
}
