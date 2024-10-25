using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Nested_If
{
    internal class Program
    {
        static int option;
        static int money;
        static void Main(string[] args)
        {
            Console.WriteLine("Mama Aku Penasaran\n");

            AskMother();
            MotherOption(option, money);
            Console.ReadLine();
        }

        static void AskMother()
        {
            Console.WriteLine("Mama mau kemana? (Pasar/Mall)");
            Console.Write("(1/2) : ");
            bool isValidOption = int.TryParse(Console.ReadLine(), out option);

            Console.Write("Bawa duit berapa? : ");
            bool isValidMoney = int.TryParse(Console.ReadLine(), out money);

            if (!isValidOption || !isValidMoney)
            {
                Console.WriteLine("Pilihan atau angka tidak valid!");
                Console.WriteLine("Klik Enter untuk mengulang.");
                Console.Read();
                Console.Clear();
                AskMother();
            }
        }

        static void MotherOption(int option, int money)
        {
            if (option == 1)
            {
                Console.WriteLine("Ibu ke pasar");
                if (money >= 5000)
                {
                    Console.WriteLine("Ibu mau beli apel.");
                    return;
                } else
                {
                    Console.WriteLine("Ibu mau beli jeruk");
                }
            } else if (option == 2)
            {
                Console.WriteLine("Ibu ke mall");
                Console.WriteLine("Ibu mau beli baju");
            }
        }
    }
}
