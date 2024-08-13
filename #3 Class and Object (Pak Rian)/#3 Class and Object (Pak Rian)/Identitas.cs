using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class Identitas
    {
        string nama = "Muhammad Ramadian Ramadhan";
        string kelas = "X RPL 1";
        string noAbsen = "22";
        public void displayIdentitas()
        {
            Console.WriteLine("\n=== PROGRAM MENGHITUNG BOLA ===\n");
            Console.WriteLine($"Hai, perkenalkan Saya {nama}, \nDari kelas {kelas}, \nNomor absen {noAbsen}\n");
        }
    }
}
