/****************************************************************************
**                                                                          
**                           SAKARYA ÜNİVERSİTESİ                           
**                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                 
**                      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                      
**                     NESNEYE DAYALI PROGRAMLAMA DERSİ                     
**                          2024-2025 BAHAR DÖNEMİ                          
**                                                                          
**                  ÖDEV NUMARASI..........: 3                              
**                  ÖĞRENCİ ADI............: Nureddin Can ERDEĞER           
**                  ÖĞRENCİ NUMARASI.......: B231210041                     
**                  DERSİN ALINDIĞI GRUP...: C                              
**                                                                          
****************************************************************************/
using System.Text.RegularExpressions;

namespace SiteYonetimPaneli
{
    public partial class OturanYonetimForm : Form
    {
        public OturanYonetimForm()
        {
            InitializeComponent();
        }

        private OturanYonetici yonetici = new OturanYonetici();
        private void OturanEkleButton_Click(object sender, EventArgs e)
        {
            string oturanAdi = oturanAdiTextBox.Text.Trim();
            string daireNo = daireNumarasiNumericUpDown1.Value.ToString();
            string oturanTuru = aileReisiRadioButton1.Checked ? "Aile Reisi" : (misafirRadioButton1.Checked ? "Misafir" : "");

            if (string.IsNullOrEmpty(oturanAdi) || string.IsNullOrEmpty(daireNo) || string.IsNullOrEmpty(oturanTuru))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(oturanAdi, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Kullanıcı adı sadece harflerden oluşmalıdır! (Her dilde harf ve boşluk kabul edilir)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!yonetici.DaireVarMi(daireNo))
            {
                MessageBox.Show("Eklemek istediğiniz daire mevcut değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Oturan oturan;
            if (aileReisiRadioButton1.Checked)
                oturan = new AileReisi();
            else
                oturan = new Misafir();

            oturan.OturanAdi = oturanAdi;
            oturan.OturanDaireNo = daireNo;
            oturan.OturanTuru = oturanTuru;

            if (yonetici.OturanVarMi(oturan))
            {
                MessageBox.Show("Bu oturan zaten eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            yonetici.OturanEkle(oturan);
            MessageBox.Show("Oturan başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void OturanSilButton_Click(object sender, EventArgs e)
        {
            string oturanAdi = oturanAdiTextBox.Text.Trim();
            string daireNo = daireNumarasiNumericUpDown1.Value.ToString();
            string oturanTuru = aileReisiRadioButton1.Checked ? "Aile Reisi" : (misafirRadioButton1.Checked ? "Misafir" : "");

            if (string.IsNullOrEmpty(oturanAdi) || string.IsNullOrEmpty(daireNo) || string.IsNullOrEmpty(oturanTuru))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Oturan oturan;
            if (aileReisiRadioButton1.Checked)
                oturan = new AileReisi();
            else
                oturan = new Misafir();

            oturan.OturanAdi = oturanAdi;
            oturan.OturanDaireNo = daireNo;
            oturan.OturanTuru = oturanTuru;

            bool sonuc = yonetici.OturanSil(oturan);

            if (sonuc)
                MessageBox.Show("Oturan başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Belirtilen oturan bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void OturanGuncelleButton_Click(object sender, EventArgs e)
        {
            string eskiAd = eskiOturanAdiTextBox.Text.Trim();
            string yeniAd = yeniOturanAdiTextBox.Text.Trim();
            string daireNo = daireNumarasiNumericUpDown2.Value.ToString();
            string oturanTuru = aileReisiRadioButton2.Checked ? "Aile Reisi" : (misafirRadioButton2.Checked ? "Misafir" : "");

            if (string.IsNullOrEmpty(eskiAd) || string.IsNullOrEmpty(yeniAd) || string.IsNullOrEmpty(daireNo) || string.IsNullOrEmpty(oturanTuru))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(eskiAd, @"^[\p{L}\s]+$") || !Regex.IsMatch(yeniAd, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Kullanıcı adı sadece harflerden oluşmalıdır! (Her dilde harf ve boşluk kabul edilir)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sonuc = yonetici.OturanGuncelle(daireNo, oturanTuru, eskiAd, yeniAd);

            if (sonuc == 1)
                MessageBox.Show("Güncellemek istediğiniz oturan bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (sonuc == 2)
                MessageBox.Show("Aynı dairede ve türde bu isimde bir oturan zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (sonuc == 3)
                MessageBox.Show("Oturan başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void OturanlariGoruntuleButton_Click(object sender, EventArgs e)
        {
            oturanlarListBox.Items.Clear();

            List<string> oturanlar = yonetici.OturanlariGoruntule();

            foreach (var oturan in oturanlar)
            {
                oturanlarListBox.Items.Add(oturan);
            }
        }
    }
}