using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
using System.Collections.Generic;

public class BilgiPaketi
{
    private List<Ders> tumDersler;

    public BilgiPaketi()
    {
        tumDersler = new List<Ders>();
    }

    public void DersEkle(Ders ders)
    {
        tumDersler.Add(ders);
    }

    public void TranskriptSorgula(Ogrenci ogrenci)
    {
        foreach (Ders ders in tumDersler)
        {
            if (ders.OgrenciKayitliMi(ogrenci.getNumara()))
            {
                Console.WriteLine($"{ders.dersAdi} adlı dersin kredisi {ders.kredi}, harf notu {ders.HarfNotu(0)}");
            }
        }
    }
}

}