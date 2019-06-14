using OOPKutuphane.Classes;

namespace OOPKutuphane
{
    class Kitap
    {
        public KitapTuru KitapTuru { get; set; }
        public string KitapAdi { get; set; }
        public Yazar Yazar { get; set; }
        public string KitapKodu { get; set; }


    }
}
