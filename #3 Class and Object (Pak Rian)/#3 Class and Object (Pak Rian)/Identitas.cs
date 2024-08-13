using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class Identitas
    {
        // ini kumpulan objek sama variabel ❤
        HitungLuas hitungLuas = new HitungLuas();
        HitungVolume hitungVolume = new HitungVolume();

        string nama = "Muhammad Ramadian Ramadhan",
            kelas = "X RPL 1",
            noAbsen = "22",
            input;

        bool isBenar = false,
            isBenar2 = false;
        double jari, hasil;

        // ini method nampilin identitas ❤
        public void displayIdentitas()
        {
            Console.WriteLine("\n=== PROGRAM MENGHITUNG BOLA ===\n");
            Console.WriteLine($"Hai, perkenalkan Saya {nama}, \nDari kelas {kelas}, \nNomor absen {noAbsen}\n");
            pilihProgram();
        }

        // ini method pemilihan program ❤
        public void pilihProgram()
        {
            while (!isBenar2)
            {
                Console.WriteLine("Mau hitung luas bola atau volume bola? (1/2)");
                input = Console.ReadLine();
                try
                {
                    int pilihan = Convert.ToInt32(input);
                    if (pilihan == 1)
                    {
                        Console.Clear();
                        tanyaJari();
                        hasil = hitungLuas.Bola(jari);
                        Console.WriteLine($"Bola dengan jari-jari {jari} m, maka luasnya adalah {hasil} m^2");
                    }
                    else if (pilihan == 2)
                    {
                        Console.Clear();
                        tanyaJari();
                        hitungVolume.Bola(jari);
                    }
                    isBenar2 = true;
                }
                catch (Exception)
                {
                    inputLagi();
                    displayIdentitas();
                }
            }
        }

        // ini method nanya jari-jari ❤
        public void tanyaJari()
        {
            while (!isBenar)
            {
                Console.WriteLine("\nMasukan jari-jari bola :");

                input = Console.ReadLine();

                try
                {
                    jari = Convert.ToDouble(input);
                    isBenar = true;
                }
                catch (FormatException)
                {
                    inputLagi();
                    tanyaJari();
                }
            }
            Console.WriteLine();
        }

        //ini method semisal input yang diminta ga valid ❤
        public void inputLagi()
        {
            Console.Clear();
            Console.WriteLine("\n== Input tidak valid, silakan masukkan angka ==\n");
            Console.Write("Tekan Enter untuk mengulang...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
