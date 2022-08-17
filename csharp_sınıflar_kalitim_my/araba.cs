using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_sınıflar_kalitim_my
{
    internal class araba: araba_detay // : sınıf adı metodu ile diğer sınıflara ait özellikleri de bu sınıfa getirebiliriz. diğer sınıftaki özellikleri aşağıda tekrardan yazmamıza gerek kalmaz
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

    }
}
