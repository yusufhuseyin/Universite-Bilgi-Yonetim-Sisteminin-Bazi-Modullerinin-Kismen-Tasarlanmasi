using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.obj
{
    public class Akademisyen
{
    private string akademisyenAd;
    private string akademisyenSoyad;

    public Akademisyen(string akademisyenAd, string akademisyenSoyad)
    {
        this.akademisyenAd = akademisyenAd;
        this.akademisyenSoyad = akademisyenSoyad;
    }

    public string GetAd()
    {
        return akademisyenAd;
    }

    public string GetSoyad()
    {
        return akademisyenSoyad;
    }
}

}