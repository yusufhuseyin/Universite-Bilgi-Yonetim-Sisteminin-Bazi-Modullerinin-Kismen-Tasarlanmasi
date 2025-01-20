class TemelDers(Ders):
    def not_hesapla(self, *notlar):
        if len(notlar) != 3:
            raise ValueError("Temel dersler için 3 not girilmelidir (Vize, Final, Proje).")
        ortalama = (notlar[0] * 0.3) + (notlar[1] * 0.5) + (notlar[2] * 0.2)
        return self.harf_notu(ortalama)
