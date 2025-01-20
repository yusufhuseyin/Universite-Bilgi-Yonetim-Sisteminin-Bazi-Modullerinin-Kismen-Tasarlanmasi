class Ogrenci:
    def _init_(self, ad, soyad, numara, bolum, fakultesi, giris_yili, sinif):
        self.__ad = ad
        self.__soyad = soyad
        self.__numara = numara
        self.__bolum = bolum
        self.__fakultesi = fakultesi
        self.__giris_yili = giris_yili
        self.__sinif = sinif

    @property
    def ad(self):
        return self.__ad

    @property
    def soyad(self):
        return self.__soyad

    @property
    def numara(self):
        return self.__numara

    @property
    def bolum(self):
        return self.__bolum

    @property
    def fakultesi(self):
        return self.__fakultesi

    @property
    def giris_yili(self):
        return self.__giris_yili

    @property
    def sinif(self):
        return self.__sinif

    def get_ad_soyad(self):
        return f"{self.ad} {self.soyad}"
