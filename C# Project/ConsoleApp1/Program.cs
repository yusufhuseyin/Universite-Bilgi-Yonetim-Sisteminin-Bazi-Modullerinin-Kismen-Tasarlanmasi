using System;
using ConsoleApp1;
using ConsoleApp1.obj;

public class Program
{
    public static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci("Yusuf", "DENİZ", 427634, "Yazilim", "Of", 2022, 3);
        Ogrenci ogrenci2 = new Ogrenci("Ugur", "BALTA", 427646, "Yazilim", "Of", 2022, 3);

        Akademisyen akademisyen1 = new Akademisyen("Ege", "Ugur");
        Akademisyen akademisyen2 = new Akademisyen("Kenan", "Barug");

        TemelDers ders1 = new TemelDers("İngilizce", "123", "2", akademisyen1, 4);
        UygulamaliDers lab1 = new UygulamaliDers("YTM", "110", "Güz", akademisyen2, 3);

        BilgiPaketi bilgiPaketi1 = new BilgiPaketi();

        ders1.DerseYazilim(ogrenci1);

        bilgiPaketi1.DersEkle(ders1);

        bilgiPaketi1.TranskriptSorgula(ogrenci1);
    }
}
