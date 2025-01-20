class BilgiPaketi:
    def _init_(self):
        self.tum_dersler = []

    def ders_ekle(self, ders):
        self.tum_dersler.append(ders)

    def transkript_sorgula(self, ogrenci):
        print(f"{ogrenci.get_ad_soyad()} Ders Listesi:")
        for ders in self.tum_dersler:
            if ders.ogrenci_kayitli_mi(ogrenci.numara):
                print(f"{ders.ders_adi} dersi")
                print(f"Dersin kredisi: {ders.kredi}")
                print(f"Harf notunuz: {ders.harf_notu(0)}")
