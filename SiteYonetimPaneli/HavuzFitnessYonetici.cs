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
    internal class HavuzFitnessYonetici
    {
        private readonly string odemeDosyaYolu = "Odeme.txt";
        private readonly string havuzDosyaYolu = "HavuzKul.txt";
        private readonly string fitnessDosyaYolu = "Fitness.txt";

        // 0 = ödeme kaydı yok, 1 = borcu yok, 2 = borcu var
        private int BorcDurumu(int daireNo)
        {
            var odemeler = File.ReadAllLines(odemeDosyaYolu);
            string kayit = null;
            foreach (var satir in odemeler)
            {
                if (satir.StartsWith($"Daire {daireNo}:"))
                {
                    kayit = satir;
                    break;
                }
            }
            if (kayit == null)
                return 0;
            if (kayit.EndsWith("Ödedi"))
                return 1;
            return 2;
        }
        public string HavuzKullan(int daireNo)
        {
            int borcDurumu = BorcDurumu(daireNo);
            string sonuc;
            if (borcDurumu == 0)
                return "Bu dairenin ödeme kaydı yok! Havuz kullanımı yapılamaz.";
            else if (borcDurumu == 1)
                sonuc = $"Daire {daireNo}: Kullandırıldı";
            else
                sonuc = $"Daire {daireNo}: Kullandırılmadı";

            File.AppendAllText(havuzDosyaYolu, sonuc + Environment.NewLine);
            return sonuc;
        }
        public List<string> HavuzKullanimiGoruntule()
        {
            return File.ReadAllLines(havuzDosyaYolu).ToList();
        }
        public string FitnessKullan(int daireNo)
        {
            int borcDurumu = BorcDurumu(daireNo);
            string sonuc;
            if (borcDurumu == 0)
                return "Bu dairenin ödeme kaydı yok! Fitness kullanımı yapılamaz.";
            else if (borcDurumu == 1)
                sonuc = $"Daire {daireNo}: Kullandırıldı";
            else
                sonuc = $"Daire {daireNo}: Kullandırılmadı";

            File.AppendAllText(fitnessDosyaYolu, sonuc + Environment.NewLine);
            return sonuc;
        }
        public List<string> FitnessKullanimiGoruntule()
        {
            return File.ReadAllLines(fitnessDosyaYolu).ToList();
        }
    }
}