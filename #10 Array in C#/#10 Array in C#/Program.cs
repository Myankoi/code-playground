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
            Console.Write("Jumlah data buah yang ingin dimasukkan : ");
            int indexData = Convert.ToInt32(Console.ReadLine());

            buah = new string[indexData];

            for (int i = 0; i < buah.Length; i++)
            {
                Console.Write($"Masukan buah ke-{i + 1} : ");
                buah[i] = Console.ReadLine();
            }
        }

        static void outputData()
        {

            Console.WriteLine("Berikut data buah Anda : ");
            for (int i = 0; i < buah.Length; i++)
            {
                Console.WriteLine($"\nData buah ke {i + 1} = {buah[i]}");
            }
        }
    }
}
