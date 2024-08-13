using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class HitungLuas
    {
        double hasilSementara;
        double hasilAkhir;

        // ini method yang nangkep parameter jari ❤
        public double Bola (double jari)
        {
            hasilSementara = 4 * Math.PI * Math.Pow(jari, 2);
            hasilAkhir = Math.Round(hasilSementara, 2);
            return (hasilAkhir);
        }
    }
}
