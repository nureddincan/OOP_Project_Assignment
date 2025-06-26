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
    internal class Oturan
    {
        protected string _turu = string.Empty;
        protected string _adi = string.Empty;
        protected string _daireNo = string.Empty;
        protected bool _borcOdedi = false;
        public string OturanTuru
        {
            get { return _turu; }
            set { _turu = value; }
        }
        public string OturanAdi
        {
            get { return _adi; }
            set { _adi = value; }
        }
        public string OturanDaireNo
        {
            get { return _daireNo; }
            set { _daireNo = value; }
        }
        public bool BorcOdedi
        {
            get { return _borcOdedi; }
            set { _borcOdedi = value; }
        }
    }
}