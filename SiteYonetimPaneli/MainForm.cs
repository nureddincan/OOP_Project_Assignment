/****************************************************************************
**                                                                          
**                           SAKARYA �N�VERS�TES�                           
**                B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�                 
**                      B�LG�SAYAR M�HEND�SL��� B�L�M�                      
**                     NESNEYE DAYALI PROGRAMLAMA DERS�                     
**                          2024-2025 BAHAR D�NEM�                          
**                                                                          
**                  �DEV NUMARASI..........: 3                              
**                  ��RENC� ADI............: Nureddin Can ERDE�ER           
**                  ��RENC� NUMARASI.......: B231210041                     
**                  DERS�N ALINDI�I GRUP...: C                              
**                                                                          
****************************************************************************/

namespace SiteYonetimPaneli
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MekanIslemleriButton_Click(object sender, EventArgs e)
        {
            MekanYonetimForm mekanYonetimForm = new MekanYonetimForm();
            mekanYonetimForm.ShowDialog();
        }
        private void OturanIslemleriButton_Click(object sender, EventArgs e)
        {
            OturanYonetimForm oturanYonetimForm = new OturanYonetimForm();
            oturanYonetimForm.ShowDialog();
        }
        private void OdemeIslemleriButton_Click(object sender, EventArgs e)
        {
            OdemeYonetimForm odemeYonetimForm = new OdemeYonetimForm();
            odemeYonetimForm.ShowDialog();
        }
        private void HavuzFitnessIslemleriButton_Click(object sender, EventArgs e)
        {
            HavuzFitnessYonetimForm havuzFitnessYonetimForm = new HavuzFitnessYonetimForm();
            havuzFitnessYonetimForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string mekanDosyaYolu = Path.Combine(Application.StartupPath, "Mekan.txt");
            string dataDosyaYolu = Path.Combine(Application.StartupPath, "Data.txt");
            string odemeDosyaYolu = Path.Combine(Application.StartupPath, "Odeme.txt");
            string havuzKulDosyaYolu = Path.Combine(Application.StartupPath, "HavuzKul.txt");
            string fitnessDosyaYolu = Path.Combine(Application.StartupPath, "Fitness.txt");

            if (!File.Exists(mekanDosyaYolu)) File.Create(mekanDosyaYolu).Close();
            if (!File.Exists(dataDosyaYolu)) File.Create(dataDosyaYolu).Close();
            if (!File.Exists(odemeDosyaYolu)) File.Create(odemeDosyaYolu).Close();
            if (!File.Exists(havuzKulDosyaYolu)) File.Create(havuzKulDosyaYolu).Close();
            if (!File.Exists(fitnessDosyaYolu)) File.Create(fitnessDosyaYolu).Close();
        }
    }
}