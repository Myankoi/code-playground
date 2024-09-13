using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_KPK___FPB
{
    public class Program
    { 
        static void Main(string[] args)
        {
            WOKWOK wokwok = new WOKWOK();
            Console.WriteLine("-* KPK & FPB *-\n");
            Console.WriteLine("Muhammad Ramadian Ramadhan (22)");
            Console.WriteLine("X RPL 1");

            Console.Write("Masukan Nilai Pertama    : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan Nilai Kedua      : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("KPK atau FPB? (1/2)  : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine($"KPK dari nilai {a} dan {b} adalah: " + Math.Abs(wokwok.HitungKPK(a, b)));
            }
            else if (c == 2)
            {
                Console.WriteLine($"FPB dari nilai {a} dan {b} adalah: " + Math.Abs(wokwok.HitungFPB(a, b)));
            } else
            {
                Console.WriteLine("Input tidak valid!");
            }
            Console.ReadLine();
        }
    }

    public class WOKWOK
    {
        public int HitungFPB(int a, int b)
        {   
            while (b != 0)
            {
                int sementara = b; // 8
                b = a % b; // 24 % 8 = 0
                a = sementara; // 8
            }
            return a; // 8
        }
        public int HitungKPK(int a, int b)
        {
            int hasil = a * b / HitungFPB(a, b); // 8
            return hasil;
        }
    }

}
