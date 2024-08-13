using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_and_Object__Pak_Rian_
{
    public class HitungVolume
    {
        double hasilSementara;
        double hasilAkhir;

        // ini juga sama, tapi pake void ❤
        public void Bola(double jari) {
            hasilSementara = ( (4/3) * Math.PI * Math.Pow(jari, 3) );
            hasilAkhir = Math.Round(hasilSementara, 2);

            Console.WriteLine($"Bola dengan jari-jari {jari} m, maka volumenya adalah {hasilAkhir} m^3");
        }
    }
}
