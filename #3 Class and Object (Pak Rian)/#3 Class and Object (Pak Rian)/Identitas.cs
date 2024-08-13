using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class Identitas
    {
        HitungLuas hitungLuas = new HitungLuas();
        HitungVolume hitungVolume = new HitungVolume();

        string nama = "Muhammad Ramadian Ramadhan";
        string kelas = "X RPL 1";
        string noAbsen = "22";
        double jari;
        double hasil;

        public void displayIdentitas()
        {
            Console.WriteLine("\n=== PROGRAM MENGHITUNG BOLA ===\n");
            Console.WriteLine($"Hai, perkenalkan Saya {nama}, \nDari kelas {kelas}, \nNomor absen {noAbsen}\n");

            Console.WriteLine("Mau hitung luas bola atau volume bola? (1/2)");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                Console.Clear();
                tanyaJari();
                hasil = hitungLuas.Bola(jari);
                Console.WriteLine($"Bola dengan jari-jari {jari} m, maka luasnya adalah {hasil} m^2");
            }
            else if (pilihan == "2") {
                Console.Clear();
                tanyaJari();
                hitungVolume.Bola(jari);
            } 
            else
            {
                Console.Clear();
                Console.WriteLine("\nAngka tidak valid!");
                Console.WriteLine("Pilih angka 1 atau 2!");
                displayIdentitas();
            }
        }
        public void tanyaJari()
        {
            Console.WriteLine("Masukan jari-jari bola :");
            jari = Convert.ToDouble(Console.ReadLine());
        }

    }
}
