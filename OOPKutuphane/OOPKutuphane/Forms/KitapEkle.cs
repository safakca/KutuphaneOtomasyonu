using OOPKutuphane.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPKutuphane
{
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
 
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            //yazar listesi
            //kitap turu
            //bu iki combobox in icin veri almam gerekiyor

            List<KitapTuru> KitapListesi = new List<KitapTuru>()
            {
                new KitapTuru{ TurAdi="Felsefe"},
                new KitapTuru{ TurAdi="Sosyoloji"},
                new KitapTuru{ TurAdi="Fantastik"}

            };

            List<Yazar> YazarListesi = new List<Yazar>()
            {
                new Yazar{ Adi="Yaşar", Soyadi="Kemal", DogumTarihi=Convert.ToDateTime("10.10.1923")},
                new Yazar{ Adi="Friderich", Soyadi="Nietzche",DogumTarihi=Convert.ToDateTime("09.10.1950")},
                new Yazar{Adi="Halide Edip",Soyadi="Adıvar",DogumTarihi=Convert.ToDateTime("05.01.1960")}

            };

            //cmbxKitapTur.DataSource = YazarListesi;   nereden getiriyorum veriyi
            //cmbxKitapTur.DisplayMember = "Adi";   kimi getiriyorum ilk gorselde

            //cmbxKitapTur.ValueMember = "Adi"; tuttugu deger value arka planda ıd gibi 
            //Generic methodumla combobox ı doldurmak istiyorum

            Helper.Helper.ComboBoxDoldur(cmbxKitapTur, KitapListesi,"TurAdi", "TurAdi");
            Helper.Helper.ComboBoxDoldur(cmbxYazar,YazarListesi,"YazarAdiSoyadi","YazarAdiSoyadi");




        }

        private void txtbxKitapAdi_TextChanged(object sender, EventArgs e)
        {
            //metodumu cagirmam gerekiyor

            txtbxKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbxYazar.SelectedItem,
                                                    (KitapTuru)cmbxKitapTur.SelectedItem,txtbxKitapAdi);
        }

        private void cmbxKitapTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxKitapTur.SelectedItem!=null && cmbxYazar.SelectedItem!=null)
            {
                txtbxKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbxYazar.SelectedItem,
                                                     (KitapTuru)cmbxKitapTur.SelectedItem, txtbxKitapAdi);
            }
        }

        private void cmbxYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxYazar.SelectedItem != null && cmbxKitapTur.SelectedItem!=null)
            {
                txtbxKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbxYazar.SelectedItem,
                                                     (KitapTuru)cmbxKitapTur.SelectedItem, txtbxKitapAdi);
            }
        }

        static List<Kitap> kitapListem = new List<Kitap>();
        private void btnButton_Click(object sender, EventArgs e)
        {
            //ekleme islemi icin;

            //list e ihtiyac olacak,kitap sınıfından
            //tureyip, akdıgım verileri kitap nesnesine atacak

            Kitap k = new Kitap(); // intance ini  aldik yani bir ornegini
            k.KitapAdi = txtbxKitapAdi.Text;
            k.KitapKodu = txtbxKitapKodu.Text;
            k.KitapTuru = (KitapTuru)cmbxKitapTur.SelectedItem; //cast islemi gerceklestirdik
            k.Yazar = (Yazar)cmbxYazar.SelectedItem;
            kitapListem.Add(k);


            Helper.Helper.FormKontrolleriniTemizle(this);

           
        }
    }
}
