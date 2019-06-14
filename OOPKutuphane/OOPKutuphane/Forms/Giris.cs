using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPKutuphane
{
    public partial class Giris : Form
    {
       
        public Giris()
        {
            InitializeComponent();
        }

       KitapEkle girisFrm = new KitapEkle();

        List<Kisi>kisilistem=new List<Kisi>();
        private void Giris_Load(object sender, EventArgs e)
        {
            //kullanıcı kayit ol dediyse
            //yani kayit ol butonuna basmışsa
            //boyle bir kullanıcı var mı yok mu kontrolu yapıyorum


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //kisi kayit olmak istiyorsa
            //once butonumu kontrol ediyorum, giris yap mı yazıyor
            //eger giris yap yazıyorsa textini kayıt ol olarak degistiriyorum
            if (btnGiris.Text == "Giriş Yap")
            {
                this.Text = "Kayıt Ol";
                linkLabel1.Text = "Giriş Yap";
                btnGiris.Text = "Kayıt Ol";
            }
            else if (btnGiris.Text=="Kayıt Ol")
            {
                this.Text = "Giriş Yap";
                linkLabel1.Text = "Kayıt Ol";
                btnGiris.Text = "Giriş Yap";
            }

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (btnGiris.Text == "Kayıt Ol")
            {
                //bu kisi yeni kayıt olusturmaya calisiyordur
                //eskiden bu kullanıcı adiyla birisi var mı kontrol et
                //varsa mesaj verip devam et
                bool kisivarmi = false;

                foreach (Kisi item in kisilistem)
                {
                    //eger benim listemdeki isimlerde 
                    //kullanıcı textboxa girdigi isim varmı
                    if (item.KullaniciAdi == txtbxKullaniciAdi.Text)
                    {
                        kisivarmi = true;
                        MessageBox.Show("Boyle bir kullanici adi mevcut, lutfen " +
                            "farkli bir isim giriniz");
                    }
                }
                if (!kisivarmi)
                {
                    //listeme ekleme yapmam lazım

                    kisilistem.Add(new Kisi
                    { KullaniciAdi = txtbxKullaniciAdi.Text, Sifre = txtbxSifre.Text });
                }
                Helper.Helper.Temizle(txtbxKullaniciAdi, txtbxSifre);
            }
            else if (btnGiris.Text == "Giriş Yap")
            {
                //istemin icerisinde textbox taki kullanıcı adı ve sifre eslesiyormu 
                foreach (Kisi item in kisilistem)
                {
                    if (item.KullaniciAdi == txtbxKullaniciAdi.Text && item.Sifre == txtbxSifre.Text)
                    {
                        //kullanici girisi basarılı
                        MessageBox.Show("Başarılı");
                        girisFrm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanici adi yada sifreniz yalnis");
                        Helper.Helper.Temizle(txtbxKullaniciAdi, txtbxSifre);
                    }
                }
            }

        }
    }
}
