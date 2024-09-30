using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Array_in_C_
{
    internal class Program
    {
        static string[] buah = new string[] {};
        static int[] angka = new int[] { };
        static void Main(string[] args)
        {
            /*string[] buah = { "apel", "pisang", "jeruk", "anggur", "kiwi" };

            for (int i = 0; i < buah.Length; i++)
            {
                Console.WriteLine($" data ke-{i + 1} = " + buah[i]);
            }

            for (int i = 0; i < buah.Length; i++)
            {
                Console.Write($"Masukan data angka ke {i + 1} = ");
                buah[i] = Console.ReadLine();
            }

            Console.WriteLine("\nData buah yang baru: ");
            for (int i = 0; i < buah.Length; i++)
            {
                Console.WriteLine($"Data ke-{i + 1} = " + buah[i]);
            }*/

            /*string[] kota = { "jakarta", "ayam", "k", "i", "u" };

            foreach (var k in kota)
                Console.WriteLine(k);

            Console.ReadLine();*/

            inputData();
            outputData();

            Console.ReadLine();
        }

        static void inputData()
        {
            Console.Write("Jumlah data angka yang ingin dimasukkan : ");
            int indexData = Convert.ToInt32(Console.ReadLine());

            angka = new int[indexData];

            for (int i = 0; i < angka.Length; i++)
            {
                Console.Write($"Masukan angka ke-{i + 1} : ");
                angka[i] = int.Parse(Console.ReadLine());
            }
        }

        static void outputData()
        {
            Console.WriteLine("\nBerikut data angka Anda : ");
            for (int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine($"Data angka ke {i + 1} = {angka[i]}");
            }

            Console.WriteLine($"\nNilai Max dalam array Angka : {angka.Max()}");
            Console.WriteLine($"Nilai Min dalam array Angka : {angka.Min()}");
            Console.WriteLine($"Total nilai dalam array Angka : {angka.Sum()}");
            Console.WriteLine($"Rata-rata nilai dalam array Angka : {angka.Average()}");
        }
    }
}
