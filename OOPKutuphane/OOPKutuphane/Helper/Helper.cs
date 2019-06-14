using OOPKutuphane.Classes;
using System;
using System.Collections;
using System.Windows.Forms;

namespace OOPKutuphane.Helper
{
    class Helper
    {

        //temizle
        //combobox ı doldur
        /// <summary>
        /// generic bir method oluşturma
        /// butun benzer islemlerde kullanmak icin
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="list"></param>
        /// <param name="DisplayMember"></param>
        /// <param name="ValueMember"></param>
        public static void ComboBoxDoldur(ComboBox cmb, ICollection list,
            string DisplayMember, string ValueMember)
        {  //generic method
            cmb.DataSource = list;
            cmb.DisplayMember = DisplayMember;
            cmb.ValueMember = ValueMember;
        }


        //kod uret(kitap kodu)
        //kitabın ve yazarin bas harflerinden olusan bir kod turetmeye calisalim
        public static string KitapKoduUret(Yazar yazar, KitapTuru kitapTuru, TextBox txt)
        {
            //yazar adsoyadının ilk harflerinden ve kitap türünün ilk harflerinden bir kod üretelim

            string[] kitapKelimeleri = txt.Text.Split(' '); //her harfi ayırmak icin split ettik
            string kitapkodu = yazar.Adi.Substring(0, 3) + kitapTuru.TurAdi.Substring(0, 3) + "-";
            for (int i = 0; i < kitapKelimeleri.Length; i++)
            {
                if (!string.IsNullOrEmpty(kitapKelimeleri[i]))
                {
                    kitapkodu = kitapkodu + kitapKelimeleri[i][0];
                }
            }

            return kitapkodu;
        }

            //temizleme methodu
            //tek textboksları temizlemek icin
        public static void Temizle(params TextBox[] txt) //dizi seklinde verdik params cunku birden fazla sey silmek isteyebilirz
        {
            foreach (TextBox item in txt)
            {
                item.Clear();
            }
        }

        //2. Yontem
        public static void FormKontrolleriniTemizle(Form form) //form uzerindeki elemanlari temizlemeli
        {
            foreach (var item in form.Controls)
            {
                //item ne tipinde sorusunu sormam gerekiyor
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
            }
        }
    }
}
