using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
using System.Collections.Generic;
    using ConsoleApp1.obj;

    public abstract class Ders
{
    public string dersAdi;
    protected string dersKodu;
    protected string donem;
    protected bool secmeli;
    public int kredi;
    protected Akademisyen dersSorumlusu;
    private List<Ogrenci> ogrenciListesi;

    public Ders(string dersAdi, string dersKodu, string donem, Akademisyen dersSorumlusu, int kredi)
    {
        this.dersAdi = dersAdi;
        this.dersKodu = dersKodu;
        this.donem = donem;
        this.dersSorumlusu = dersSorumlusu;
        this.kredi = kredi;
        ogrenciListesi = new List<Ogrenci>();
    }

    public abstract string NotHesapla(params double[] notlar);

    public void DerseYazilim(Ogrenci ogrenci)
    {
        ogrenciListesi.Add(ogrenci);
    }

    public bool OgrenciKayitliMi(int numara)
    {
        foreach (Ogrenci ogrenci in ogrenciListesi)
        {
            if (ogrenci.getNumara() == numara)
            {
                return true;
            }
        }
        return false;
    }

    public void ListeyiYazdir()
    {
        Console.WriteLine(dersAdi + " Öğrenci Listesi:");
        foreach (Ogrenci ogrenci in ogrenciListesi)
        {
            Console.WriteLine(ogrenci.getAdSoyad());
        }
    }

    public string HarfNotu(double ortalama)
    {
        if (ortalama >= 90)
        {
            return "AA";
        }
        else if (ortalama >= 80)
        {
            return "BA";
        }
        else if (ortalama >= 70)
        {
            return "BB";
        }
        else if (ortalama >= 60)
        {
            return "CB";
        }
        else if (ortalama >= 50)
        {
            return "CC";
        }
        else if (ortalama >= 40)
        {
            return "DC";
        }
        else if (ortalama >= 30)
        {
            return "DD";
        }
        else
        {
            return "FF";
        }
    }
}

}