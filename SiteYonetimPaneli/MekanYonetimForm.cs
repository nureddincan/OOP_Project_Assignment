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
    public partial class MekanYonetimForm : Form
    {
        private MekanYonetici yonetici = new MekanYonetici();
        private readonly string dosyaYolu = "Mekan.txt";
        public MekanYonetimForm()
        {
            InitializeComponent();
        }
        private void MekanYonetimForm_Load(object sender, EventArgs e)
        {
            List<string> satirlar = File.ReadAllLines(dosyaYolu).ToList();

            if (!satirlar.Contains("Yüzme Havuzu"))
            {
                Havuz havuz = new Havuz();
                yonetici.MekanEkle(havuz, dosyaYolu);
            }

            if (!satirlar.Contains("Fitness Salonu"))
            {
                Fitness fitness = new Fitness();
                yonetici.MekanEkle(fitness, dosyaYolu);
            }
        }
        private void DaireEkleButton_Click(object sender, EventArgs e)
        {
            string daireNo = daireNumarasiNumericUpDown.Value.ToString();
            string mekanAdi = "Daire " + daireNo;

            bool daireVarMi = false;

            var satirlar = File.ReadAllLines(dosyaYolu);
            foreach (var satir in satirlar)
            {
                if (satir.Trim() == mekanAdi)
                {
                    daireVarMi = true;
                    break;
                }
            }

            if (daireVarMi)
            {
                MessageBox.Show($"{daireNo} numaralı daire zaten eklenmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Daire yeniDaire = new Daire();
                yeniDaire.DaireNo = daireNo;
                yonetici.MekanEkle(yeniDaire, dosyaYolu);
                MessageBox.Show($"{daireNo} numaralı daire eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DaireSilButton_Click(object sender, EventArgs e)
        {
            string daireNo = daireNumarasiNumericUpDown.Value.ToString();
            string mekanAdi = "Daire " + daireNo;

            bool sonuc = yonetici.MekanSil(mekanAdi, dosyaYolu);

            if (sonuc)
                MessageBox.Show($"{daireNo} numaralı daire silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"{daireNo} numaralı daire bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void DaireGuncelleButton_Click(object sender, EventArgs e)
        {
            string eskiDaireNo = eskiDaireNumarasiNumericUpDown.Value.ToString();
            string yeniDaireNo = yeniDaireNumarasiNumericUpDown.Value.ToString();

            string eskiMekanAdi = "Daire " + eskiDaireNo;
            string yeniMekanAdi = "Daire " + yeniDaireNo;

            int sonuc = yonetici.MekanGuncelle(eskiMekanAdi, yeniMekanAdi, dosyaYolu);

            if (sonuc == 1)
                MessageBox.Show($"{eskiDaireNo} numaralı daire bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (sonuc == 2)
                MessageBox.Show($"Girmek istediğiniz {yeniDaireNo} numaralı daire zaten var!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (sonuc == 3)
                MessageBox.Show($"{eskiDaireNo} numaralı daire {yeniDaireNo} olarak güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Bir hata oluştu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void MekanlariGoruntuleButton_Click(object sender, EventArgs e)
        {
            dairelerListBox.Items.Clear();

            List<string> mekanlar = yonetici.MekanlariGoruntule(dosyaYolu);

            foreach (var mekan in mekanlar)
            {
                dairelerListBox.Items.Add(mekan);
            }
        }
    }
}