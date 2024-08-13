using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class HitungLuas
    {
        double pi = 3.14;
        double hasil;
        public double Bola (double jari)
        {
            hasil = 4 * pi * Math.Pow(jari, 2);
            return (hasil);
        }
    }
}
