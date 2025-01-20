using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.obj
{
    class MeslekiEgitimDers : Ders
    {
        
    public MeslekiEgitimDers(string dersAdi, string dersKodu, string donem, Akademisyen dersSorumlusu, int kredi)
        : base(dersAdi, dersKodu, donem, dersSorumlusu, kredi)
    {
    }

    public override string NotHesapla(params double[] notlar){
        if (notlar.Length != 1){
            throw new ArgumentException("Mesleki eğitim dersleri için 1 not girilmelidir");
        }
        return base.HarfNotu(notlar[0]);
    }
    }

}