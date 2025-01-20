class MeslekiEğitimDersi(Ders):
    def __init__(self, ders_adi, ders_kodu, donem, ders_sorumlusu, kredi):
        super().__init__(ders_adi, ders_kodu, donem, ders_sorumlusu, kredi)

    def not_hesapla(self, *notlar):
        if len(notlar) != 1:
            raise ValueError("Mesleki eğitim dersleri için 1 not girilmelidir.")
        return self.harf_notu(notlar[0])
