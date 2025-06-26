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
    internal class OdemeYonetici
    {
        private readonly string odemeDosyaYolu = "Odeme.txt";
        private readonly string dataDosyaYolu = "Data.txt";
        public bool DairedeOturuyorMu(int daireNo)
        {
            var satirlar = File.ReadAllLines(dataDosyaYolu);
            foreach (var satir in satirlar)
            {
                if (satir.StartsWith($"Daire {daireNo} "))
                    return true;
            }
            return false;
        }
        public string OdemeEkle(int daireNo, string durum)
        {
            if (!DairedeOturuyorMu(daireNo))
                return "Bu dairede oturan yok!";

            var odemeler = File.ReadAllLines(odemeDosyaYolu).ToList();
            foreach (var satir in odemeler)
            {
                if (satir.StartsWith($"Daire {daireNo}:"))
                    return "Bu dairenin zaten bir ödeme kaydı var!";
            }

            odemeler.Add($"Daire {daireNo}: {durum}");
            File.WriteAllLines(odemeDosyaYolu, odemeler);
            return "Ödeme başarıyla eklendi.";
        }
        public string OdemeSil(int daireNo)
        {
            var odemeler = File.ReadAllLines(odemeDosyaYolu).ToList();
            string silinecek = null;
            foreach (var satir in odemeler)
            {
                if (satir.StartsWith($"Daire {daireNo}:"))
                {
                    silinecek = satir;
                    break;
                }
            }
            if (silinecek == null)
                return "Bu dairenin ödeme kaydı yok!";

            odemeler.Remove(silinecek);
            File.WriteAllLines(odemeDosyaYolu, odemeler);
            return "Ödeme kaydı silindi.";
        }
        public string OdemeGuncelle(int daireNo, string yeniDurum)
        {
            var odemeler = File.ReadAllLines(odemeDosyaYolu).ToList();
            int index = -1;
            for (int i = 0; i < odemeler.Count; i++)
            {
                if (odemeler[i].StartsWith($"Daire {daireNo}:"))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
                return "Bu dairenin ödeme kaydı yok!";

            if (odemeler[index] == $"Daire {daireNo}: {yeniDurum}")
                return "Aynı ödeme durumu tekrar girilemez!";

            odemeler[index] = $"Daire {daireNo}: {yeniDurum}";
            File.WriteAllLines(odemeDosyaYolu, odemeler);
            return "Ödeme durumu güncellendi.";
        }
        public List<string> OdemeleriGoruntule()
        {
            return File.ReadAllLines(odemeDosyaYolu).ToList();
        }
    }
}