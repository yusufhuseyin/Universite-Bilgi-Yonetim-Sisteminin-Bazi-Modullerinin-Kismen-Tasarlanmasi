public class Ogrenci {

    private final String ad;
    private final String soyad;
    private final String bolum;
    private final String fakulte;
    private final int numara;
    private final int girisYili;
    private final int sinif;

    public Ogrenci(String ad, String soyad, int no, String bolum, String fakulte, int girisYili, int sinif) {
        this.ad = ad;
        this.soyad = soyad;
        this.numara = no;
        this.bolum = bolum;
        this.fakulte = fakulte;
        this.girisYili = girisYili;
        this.sinif = sinif;
    }

    public String getad() {
        return ad;
    }

    public String getSoyad() {
        return soyad;
    }

    public String getAdSoyad() {
        return ad + soyad;
    }

    public int getNumara() {
        return numara;
    }

    public String getbolum() {
        return bolum;
    }

    public String getfakultebilgi() {
        return fakulte;
    }

    public int getgirisYili() {
        return girisYili;
    }

    public int getsinif() {
        return sinif;
    }
}
