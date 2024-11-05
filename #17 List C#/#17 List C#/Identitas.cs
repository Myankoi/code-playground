using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_List_C_
{
    public class Identitas
    {
        string name = "Muhammad Ramadian Ramadhan";
        string kelas = "X RPL 1";
        string absen = "22";

        public void MyIdt()
        {
            Console.WriteLine($"{name} {kelas} No. Absen {absen}");
        }
    }
}
