using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Birthday
{
    internal class Program
    {
        private static int nowDay = DateTime.UtcNow.Day;
        private static int nowMonth = DateTime.UtcNow.Month;
        private static int nowYear = DateTime.UtcNow.Year;
        static void Main(string[] args)
        {
            askBirthDay();
            Console.ReadLine();
        }

        static void askBirthDay()
        {
            Console.WriteLine("Apakah hari ulang tahun kamu terlewat?\n");
            Console.WriteLine($"Tanggal hari ini            : {nowDay}/{nowMonth}/{nowYear}\n");
            Console.Write("Masukan tanggal lahir kamu  : ");
            bool isTanggalInt = int.TryParse(Console.ReadLine(), out int tanggalLahir);
            Console.Write("Masukan bulan lahir kamu    : \n");
            bool isBulanInt = int.TryParse(Console.ReadLine(), out int bulanLahir);
            validateBirthDay(isTanggalInt, isBulanInt, tanggalLahir, bulanLahir);
        }

        static void validateBirthDay(bool isTanggalInt, bool isBulanInt, int tanggalLahir, int bulanLahir)
        {
            if (isTanggalInt && isBulanInt)
            {
                if (tanggalLahir >= 1 && tanggalLahir <= 31)
                {
                    if (bulanLahir >= 1 && bulanLahir <= 12)
                    {
                        if (nowDay == tanggalLahir && nowMonth == bulanLahir)
                        {
                            Console.WriteLine("🎉🎉🎉 Kamu ulang tahun hari ini. Selamat Ulang Tahun! 🎉🎉🎉");
                            repeatAskBirthDay();
                            return;
                        }
                        else if (bulanLahir <= nowMonth || bulanLahir <= nowMonth && tanggalLahir <= nowDay)
                        {
                            Console.WriteLine("Ulang tahun kamu sudah terlewat.");
                            repeatAskBirthDay();
                            return;
                        }
                        else if (bulanLahir >= nowMonth || bulanLahir >= nowMonth && tanggalLahir >= nowDay)
                        {
                            Console.WriteLine("Ulang tahun kamu belum terlewat.");
                            repeatAskBirthDay();
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bulan tidak valid!, harus diantara 1-12.");
                        repeatAskBirthDay();
                        return;
                    }

                }
                else
                {
                    Console.WriteLine("Tanggal tidak valid! harus diantara 1-31.");
                    repeatAskBirthDay();
                    return;
                }

            }
            else
            {
                Console.WriteLine("Input tidak valid! Input harus bertipe Int.");
                repeatAskBirthDay();
                return;
            }
        }

        static void repeatAskBirthDay()
        {
            Console.WriteLine("\nKlik Enter untuk mengulang.");
            Console.ReadLine();
            Console.Clear();
            askBirthDay();
        }
    }
}
