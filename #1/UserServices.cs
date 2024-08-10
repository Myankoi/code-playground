using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whoa
{
    public class UserServices
    {
        public string username;
        public int NISN, n1, n2, n3;
        

        public void UserInput()
        {
            Console.WriteLine("Masukan NISN Anda: ");
            NISN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Masukan Nama Anda: ");
            username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Masukan Nilai Subjek-1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Masukan Nilai Subjek-2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Masukan Nilai Subjek-3");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public void OutputDisplay()
        { 
            GradeCalculate gradeCalculate = new GradeCalculate();
            gradeCalculate.Calculate(username, n1, n2, n3);
        }
    }
}
