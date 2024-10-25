using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Switch_Case
{
    internal class Program
    {
        static double number1;
        static double number2;
        static double option;
        static double result;
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator 2 Angka\n");
            AskNumber();
            ChooseOperation();
            Console.ReadLine();
        }

        static void AskNumber()
        {
            Console.Write("Masukan Angka Pertama : ");
            bool isValidNum1 = double.TryParse(Console.ReadLine(), out number1);
            if (!isValidNum1)
            {
                Console.WriteLine("Angka tidak valid!\n");
                Console.WriteLine("Klik Enter untuk mengulang.");
                Console.Read();
                Console.Clear();
                AskNumber();
            }

            Console.Write("Masukan Angka Kedua   : ");
            bool isValidNum2 = double.TryParse(Console.ReadLine(), out number2);
            if (!isValidNum2)
            {
                Console.WriteLine("Angka tidak valid!\n");
                Console.WriteLine("Klik Enter untuk mengulang.");
                Console.Read();
                Console.Clear();
                AskNumber();
            }
        }

        static void ChooseOperation()
        {
            Console.WriteLine("Pilih operasi yang ingin dilakukan | + | - | * | / | % |\n");
            Console.Write("(1/2/3/4/5) : ");
            bool isValid = double.TryParse(Console.ReadLine(), out option);

            if (!isValid || option < 1 || option > 5)
            {
                Console.WriteLine("pilihan tidak valid!\n");
                Console.WriteLine("Klik Enter untuk mengulang.");
                Console.Read();
                Console.Clear();
                Console.WriteLine($"Angka 1 = {number1}");
                Console.WriteLine($"Angka 2 = {number2}");
                ChooseOperation();
            }

            switch (option)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"Hasil dari penjumlahan {number1} dan {number2} adalah {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"Hasil dari pengurangan {number1} dan {number2} adalah {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"Hasil dari perkalian {number1} dan {number2} adalah {result}");
                    break;
                case 4:
                    result = number1 * number2;
                    Console.WriteLine($"Hasil dari pembagian {number1} dan {number2} adalah {result}");
                    break;
                case 5:
                    result = number1 % number2;
                    Console.WriteLine($"Hasil dari modulo {number1} dan {number2} adalah {result}");
                    break;
            }
        }
    }
}
