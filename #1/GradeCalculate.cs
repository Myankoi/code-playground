using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace whoa
{
    public class GradeCalculate
    {
        public void Calculate(string username, int n1, int n2, int n3)
        {
            int totalNilai = n1 + n2 + n3;
            double avrg = (double)totalNilai / 3;

            Console.WriteLine($"Hasil Akhir {username} adalah: ");
            Console.WriteLine($"Jumlah Nilai: {totalNilai}");
            Console.WriteLine($"Percentage  : {avrg}");

            if (avrg < 0 || avrg > 100)
            {
                Console.WriteLine("Nilai ga valid, mesti direntang 0-100");
            }
            else
            {
                switch (avrg)
                {
                    case double n when (n >= 90 && n <= 100):
                        Console.WriteLine("Nilainya A\n");
                        break;
                    case double n when (n >= 80 && n < 90):
                        Console.WriteLine("Nilainya B\n");
                        break;
                    case double n when (n >= 70 && n < 80):
                        Console.WriteLine("Nilainya C\n");
                        break;
                    case double n when (n >= 60 && n < 70):
                        Console.WriteLine("Nilainya D\n");
                        break;
                    default:
                        Console.WriteLine("Belajar yang bener\n");
                        break;
                }
            }
        }

    }
}
