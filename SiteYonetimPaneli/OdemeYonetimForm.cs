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

namespace SiteYonetimPaneli
{
    public partial class OdemeYonetimForm : Form
    {
        private OdemeYonetici yonetici = new OdemeYonetici();
        public OdemeYonetimForm()
        {
            InitializeComponent();
        }
        private void SonucuGoster(string sonuc)
        {
            if (sonuc.Contains("başarıyla") || sonuc.Contains("güncellendi") || sonuc.Contains("silindi"))
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void OdemeEkleButton_Click(object sender, EventArgs e)
        {
            int daireNo = (int)daireNumarasiNumericUpDown1.Value;
            string durum = odediRadioButton1.Checked ? "Ödedi" : odemediRadioButton1.Checked ? "Ödemedi" : null;

            if (durum == null)
            {
                MessageBox.Show("Lütfen ödeme durumunu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SonucuGoster(yonetici.OdemeEkle(daireNo, durum));
        }
        private void OdemeSilButton_Click(object sender, EventArgs e)
        {
            int daireNo = (int)daireNumarasiNumericUpDown1.Value;
            SonucuGoster(yonetici.OdemeSil(daireNo));
        }
        private void OdemeGuncelleButton_Click(object sender, EventArgs e)
        {
            int daireNo = (int)daireNumarasiNumericUpDown2.Value;
            string durum = odediRadioButton2.Checked ? "Ödedi" : odemediRadioButton2.Checked ? "Ödemedi" : null;

            if (durum == null)
            {
                MessageBox.Show("Lütfen ödeme durumunu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SonucuGoster(yonetici.OdemeGuncelle(daireNo, durum));
        }
        private void OdemeGoruntuleButton_Click(object sender, EventArgs e)
        {
            odemelerListBox.Items.Clear();
            var odemeler = yonetici.OdemeleriGoruntule();
            foreach (var odeme in odemeler)
                odemelerListBox.Items.Add(odeme);
        }
    }
}