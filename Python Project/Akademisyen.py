class Akademisyen:
    def _init_(self, ad, soyad):
        self.__ad = ad
        self.__soyad = soyad

    @property
    def ad(self):
        return self.__ad

    @property
    def soyad(self):
        return self.__soyad
