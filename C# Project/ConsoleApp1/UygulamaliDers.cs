using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.obj;

namespace ConsoleApp1
{
    class UygulamaliDers : Ders
{
    public UygulamaliDers(string dersAdi, string dersKodu, string donem, Akademisyen dersSorumlusu, int kredi)
        : base(dersAdi, dersKodu, donem, dersSorumlusu, kredi)
    {
    }

    public override string NotHesapla(params double[] notlar)
    {
        if (notlar.Length != 2)
        {
            throw new ArgumentException("Uygulamalı dersler için 2 not girilmelidir (Vize, Final)");
        }

        double ortalama = (notlar[0] * 0.4) + (notlar[1] * 0.6);
        return base.HarfNotu(ortalama);
    }
}

}