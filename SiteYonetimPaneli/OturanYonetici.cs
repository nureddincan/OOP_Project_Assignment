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
    internal class OturanYonetici
    {
        private readonly string dosyaYolu = "data.txt";

        public bool DaireVarMi(string daireNo, string mekanDosyaYolu = "Mekan.txt")
        {
            string aranan = $"Daire {daireNo}";
            var satirlar = File.ReadAllLines(mekanDosyaYolu);

            foreach (var satir in satirlar)
            {
                if (satir.Trim() == aranan)
                    return true;
            }
            return false;
        }
        public bool OturanVarMi(Oturan oturan)
        {
            string aranan = $"Daire {oturan.OturanDaireNo} {oturan.OturanTuru} {oturan.OturanAdi}";
            var satirlar = File.ReadAllLines(dosyaYolu);

            foreach (var satir in satirlar)
            {
                if (satir.Trim() == aranan)
                    return true;
            }
            return false;
        }
        public void OturanEkle(Oturan oturan)
        {
            string satir = $"Daire {oturan.OturanDaireNo} {oturan.OturanTuru} {oturan.OturanAdi}";
            using (StreamWriter sw = new StreamWriter(dosyaYolu, true))
            {
                sw.WriteLine(satir);
            }
        }
        
        public bool OturanSil(Oturan oturan)
        {
            string aranan = $"Daire {oturan.OturanDaireNo} {oturan.OturanTuru} {oturan.OturanAdi}";
            var satirlar = File.ReadAllLines(dosyaYolu).ToList();

            bool silindi = satirlar.Remove(aranan);

            if (silindi)
                File.WriteAllLines(dosyaYolu, satirlar);

            return silindi;
        }
        public int OturanGuncelle(string daireNo, string oturanTuru, string eskiAd, string yeniAd)
        {
            string eskiSatir = $"Daire {daireNo} {oturanTuru} {eskiAd}";
            string yeniSatir = $"Daire {daireNo} {oturanTuru} {yeniAd}";
            var satirlar = File.ReadAllLines(dosyaYolu).ToList();

            int eskiIndex = satirlar.IndexOf(eskiSatir);
            int yeniIndex = satirlar.IndexOf(yeniSatir);

            if (eskiIndex == -1)
                return 1; // Eski oturan yok

            if (yeniIndex != -1)
                return 2; // Aynı isimde biri zaten var

            satirlar[eskiIndex] = yeniSatir;
            File.WriteAllLines(dosyaYolu, satirlar);
            return 3; // Başarılı
        }
        public List<string> OturanlariGoruntule()
        {
            return File.ReadAllLines(dosyaYolu).ToList();
        }
    }
}