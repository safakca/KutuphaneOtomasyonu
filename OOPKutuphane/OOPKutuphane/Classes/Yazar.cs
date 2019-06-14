using System;

namespace OOPKutuphane
{
    class Yazar
    {
        public string Adi { get; set; }    //property ingiliz anahtari
        public string Soyadi { get; set; }
        
        public DateTime DogumTarihi { get; set; }

        private string _yazarAdiSoyadi; //field 
        public string YazarAdiSoyadi
        {
            get
            {
                _yazarAdiSoyadi = Adi + " " + Soyadi;
                return _yazarAdiSoyadi;
            }
            
        }

    }
}
