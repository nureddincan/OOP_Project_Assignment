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
    public partial class HavuzFitnessYonetimForm : Form
    {
        private HavuzFitnessYonetici yonetici = new HavuzFitnessYonetici();
        public HavuzFitnessYonetimForm()
        {
            InitializeComponent();
        }
        private void HavuzKullanButton_Click(object sender, EventArgs e)
        {
            int daireNo = (int)daireNumarasiNumericUpDown.Value;
            string sonuc = yonetici.HavuzKullan(daireNo);
            if (sonuc.Contains("Kullandırıldı"))
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void HavuzKullanimiButton_Click(object sender, EventArgs e)
        {
            havuzKullanimListBox.Items.Clear();
            var liste = yonetici.HavuzKullanimiGoruntule();
            foreach (var item in liste)
                havuzKullanimListBox.Items.Add(item);
        }
        private void FitnessKullanButton_Click(object sender, EventArgs e)
        {
            int daireNo = (int)daireNumarasiNumericUpDown.Value;
            string sonuc = yonetici.FitnessKullan(daireNo);
            if (sonuc.Contains("Kullandırıldı"))
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void FitnessKullanimiButton_Click(object sender, EventArgs e)
        {
            fitnessKullanimListBox.Items.Clear();
            var liste = yonetici.FitnessKullanimiGoruntule();
            foreach (var item in liste)
                fitnessKullanimListBox.Items.Add(item);
        }
    }
}