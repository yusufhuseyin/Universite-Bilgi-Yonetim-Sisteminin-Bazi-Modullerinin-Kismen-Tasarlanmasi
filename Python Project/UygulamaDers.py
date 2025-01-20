class MeslekiEgitimDersi(Ders):
    def not_hesapla(self, *notlar):
        if len(notlar) != 1:
            raise ValueError("Mesleki eğitim dersleri için 1 not girilmelidir.")
        return self.harf_notu(notlar[0])
