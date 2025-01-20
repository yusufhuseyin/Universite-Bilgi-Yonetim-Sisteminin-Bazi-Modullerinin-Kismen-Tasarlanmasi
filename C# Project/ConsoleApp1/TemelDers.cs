using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.obj;

namespace ConsoleApp1
{
    class TemelDers : Ders
{
    public TemelDers(string dersAdi, string dersKodu, string donem, Akademisyen dersSorumlusu, int kredi)
        : base(dersAdi, dersKodu, donem, dersSorumlusu, kredi)
    {
    }

    public override string NotHesapla(params double[] notlar)
    {
        if (notlar.Length != 3)
        {
            throw new ArgumentException("Temel dersler için 3 not girilmelidir (Vize, Final, Proje).");
        }

        double ortalama = (notlar[0] * 0.3) + (notlar[1] * 0.2) + (notlar[2] * 0.5);
        return base.HarfNotu(ortalama);
    }
}

}