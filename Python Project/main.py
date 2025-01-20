# Ana programı başlatma
if __name__ == "_main_":
    ogrenci1 = Ogrenci("Ali 1", "Veli", 1, "Yazılım", "Teknoloji", 2024, 1)
    ogrenci2 = Ogrenci("Ali 2", "Veli", 2, "Yazılım", "Teknoloji", 2024, 1)
    ogrenci3 = Ogrenci("Ali 3", "Veli", 3, "Yazılım", "Teknoloji", 2024, 1)

    akademisyen1 = Akademisyen("Ad 1", "Soyad 1")
    akademisyen2 = Akademisyen("Ad 2", "Soyad 2")

    bilgi_paketi = BilgiPaketi()
    ders1 = TemelDers("Matematik", "101", "güz", False, akademisyen1, 2)
    lab1 = UygulamaliDers("YTM", "301", "güz", False, akademisyen2, 3)

    bilgi_paketi.ders_ekle(ders1)
    bilgi_paketi.ders_ekle(lab1)

    ders1.derse_yazilim(ogrenci1)
    ders1.derse_yazilim(ogrenci2)
    ders1.derse_yazilim(ogrenci3)
    lab1.derse_yazilim(ogrenci1)
    lab1.derse_yazilim(ogrenci3)

    ders1.listeyi_yazdir()
    lab1.listeyi_yazdir()

    bilgi_paketi.transkript_sorgula(ogrenci1)
    bilgi_paketi.transkript_sorgula(ogrenci2)