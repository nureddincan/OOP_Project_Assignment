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
    internal class MekanYonetici
    {
        public void MekanEkle(Mekan mekan, string dosyaYolu)
        {
            var satirlar = File.ReadAllLines(dosyaYolu);
            if (!satirlar.Contains(mekan.MekanAdi))
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
                {
                    sw.WriteLine(mekan.MekanAdi);
                }
            }
        }
        public bool MekanSil(string mekanAdi, string dosyaYolu)
        {
            var satirlar = File.ReadAllLines(dosyaYolu).ToList();
            bool silindi = satirlar.Remove(mekanAdi);

            if (silindi)
                File.WriteAllLines(dosyaYolu, satirlar);

            if (mekanAdi.StartsWith("Daire "))
            {
                string daireNo = mekanAdi.Substring("Daire ".Length);

                string[] silinecekDosyalar = { "Data.txt", "Odeme.txt", "HavuzKul.txt", "Fitness.txt" };

                foreach (var dosya in silinecekDosyalar)
                {
                    if (!File.Exists(dosya)) continue;
                    var digerSatirlar = File.ReadAllLines(dosya).ToList();
                    for (int i = digerSatirlar.Count - 1; i >= 0; i--)
                    {
                        if (digerSatirlar[i].StartsWith("Daire " + daireNo))
                        {
                            digerSatirlar.RemoveAt(i);
                        }
                    }
                    File.WriteAllLines(dosya, digerSatirlar);
                }
            }
            return silindi;
        }
        public int MekanGuncelle(string eskiMekanAdi, string yeniMekanAdi, string dosyaYolu)
        {
            var satirlar = File.ReadAllLines(dosyaYolu).ToList();
            int eskiIndex = satirlar.IndexOf(eskiMekanAdi);
            int yeniIndex = satirlar.IndexOf(yeniMekanAdi);

            if (eskiIndex == -1)
                return 1; // Eski daire yok

            if (yeniIndex != -1)
                return 2; // Yeni daire zaten var

            satirlar[eskiIndex] = yeniMekanAdi;
            File.WriteAllLines(dosyaYolu, satirlar);

            if (eskiMekanAdi.StartsWith("Daire ") && yeniMekanAdi.StartsWith("Daire "))
            {
                string eskiDaireNo = eskiMekanAdi.Substring("Daire ".Length);
                string yeniDaireNo = yeniMekanAdi.Substring("Daire ".Length);

                string[] dosyalar = { "Data.txt", "Odeme.txt", "HavuzKul.txt", "Fitness.txt" };

                foreach (var dosya in dosyalar)
                {
                    if (!File.Exists(dosya)) continue;
                    var digerSatirlar = File.ReadAllLines(dosya).ToList();
                    for (int i = 0; i < digerSatirlar.Count; i++)
                    {
                        if (digerSatirlar[i].StartsWith($"Daire {eskiDaireNo}"))
                        {
                            digerSatirlar[i] = $"Daire {yeniDaireNo}" + digerSatirlar[i].Substring($"Daire {eskiDaireNo}".Length);
                        }
                    }
                    File.WriteAllLines(dosya, digerSatirlar);
                }
            }
            return 3; // Başarılı
        }
        public List<string> MekanlariGoruntule(string dosyaYolu)
        {
            return File.ReadAllLines(dosyaYolu).ToList();
        }
    }
}