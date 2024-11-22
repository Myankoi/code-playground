using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Percabangan___Perulangan
{
    internal class Program
    {
        static int genapCount;
        static int ganjilCount;
        static void Main(string[] args)
        {
            Console.WriteLine(" === Program Percabangan & Perulangan === ");
            Console.WriteLine(" Muhammad Ramadian Ramadhan X RPL 1");
            AskUser();
        }

        static void AskUser()
        {
            while (true)
            {
                Console.Write("\nMasukan ");  
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("angka ");
                Console.ResetColor();
                Console.Write("(atau ketik ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("'exit' ");
                Console.ResetColor();
                Console.Write("untuk keluar): ");
                Console.ForegroundColor = ConsoleColor.Red;
                string input = Console.ReadLine();
                Console.ResetColor();

                if (input.ToLower() == "exit")
                {
                    Environment.Exit(0);
                    return;
                }

                bool isInt = int.TryParse(input, out int number);
                if (isInt)
                {
                    int formatNumber = Math.Abs(number);
                    string ganjilOrGenap = (formatNumber % 2 == 0) ? "GENAP." : "GANJIL.";

                    Console.Write("Angka ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{formatNumber} ");
                    Console.ResetColor();
                    Console.WriteLine($"adalah {ganjilOrGenap}");


                    Console.Write("Dari ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1 ");
                    Console.ResetColor();
                    Console.Write("hingga ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{formatNumber}");
                    Console.ResetColor();
                    Console.Write(": \n");

                    for (int i = 1; i <= formatNumber; i++)
                    {
                        if (i % 2 == 0)
                        {
                            genapCount++;
                        } else
                        {
                            ganjilCount++;
                        }
                    }
                    Console.Write("Jumlah GENAP: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{genapCount}\n");
                    Console.ResetColor();
                    Console.Write("Jumlah GANJIL: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ganjilCount}\n");
                    Console.ResetColor();
                    AskUser();
                } 
            }
        }
    }
}
