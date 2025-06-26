namespace SiteYonetimPaneli
{
    partial class MekanYonetimForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MekanYonetimForm));
            daireGuncellemeGroupBox = new GroupBox();
            eskiDaireNumarasiLabel = new Label();
            eskiDaireNumarasiNumericUpDown = new NumericUpDown();
            daireGuncelleButton = new Button();
            yeniDaireNumarasiNumericUpDown = new NumericUpDown();
            yeniDaireNumarasiLabel = new Label();
            daireEkleSilGroupBox = new GroupBox();
            daireNumarasiNumericUpDown = new NumericUpDown();
            daireNumarasiLabel = new Label();
            daireEkleButton = new Button();
            daireSilButton = new Button();
            mekanlariGoruntuleButton = new Button();
            dairelerListBox = new ListBox();
            mekanIslemleriLabel = new Label();
            daireGuncellemeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eskiDaireNumarasiNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yeniDaireNumarasiNumericUpDown).BeginInit();
            daireEkleSilGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // daireGuncellemeGroupBox
            // 
            daireGuncellemeGroupBox.BackColor = Color.Gainsboro;
            daireGuncellemeGroupBox.Controls.Add(eskiDaireNumarasiLabel);
            daireGuncellemeGroupBox.Controls.Add(eskiDaireNumarasiNumericUpDown);
            daireGuncellemeGroupBox.Controls.Add(daireGuncelleButton);
            daireGuncellemeGroupBox.Controls.Add(yeniDaireNumarasiNumericUpDown);
            daireGuncellemeGroupBox.Controls.Add(yeniDaireNumarasiLabel);
            daireGuncellemeGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            daireGuncellemeGroupBox.Location = new Point(421, 63);
            daireGuncellemeGroupBox.Name = "daireGuncellemeGroupBox";
            daireGuncellemeGroupBox.Size = new Size(620, 130);
            daireGuncellemeGroupBox.TabIndex = 6;
            daireGuncellemeGroupBox.TabStop = false;
            daireGuncellemeGroupBox.Text = "Daire Güncelleme";
            // 
            // eskiDaireNumarasiLabel
            // 
            eskiDaireNumarasiLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eskiDaireNumarasiLabel.Location = new Point(6, 31);
            eskiDaireNumarasiLabel.Name = "eskiDaireNumarasiLabel";
            eskiDaireNumarasiLabel.Size = new Size(231, 37);
            eskiDaireNumarasiLabel.TabIndex = 7;
            eskiDaireNumarasiLabel.Text = "Eski Daire Numarası";
            eskiDaireNumarasiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eskiDaireNumarasiNumericUpDown
            // 
            eskiDaireNumarasiNumericUpDown.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eskiDaireNumarasiNumericUpDown.Location = new Point(243, 31);
            eskiDaireNumarasiNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            eskiDaireNumarasiNumericUpDown.Name = "eskiDaireNumarasiNumericUpDown";
            eskiDaireNumarasiNumericUpDown.Size = new Size(140, 37);
            eskiDaireNumarasiNumericUpDown.TabIndex = 9;
            eskiDaireNumarasiNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // daireGuncelleButton
            // 
            daireGuncelleButton.BackColor = Color.MediumTurquoise;
            daireGuncelleButton.Cursor = Cursors.Hand;
            daireGuncelleButton.Location = new Point(389, 31);
            daireGuncelleButton.Name = "daireGuncelleButton";
            daireGuncelleButton.Size = new Size(225, 83);
            daireGuncelleButton.TabIndex = 11;
            daireGuncelleButton.Text = "Daireyi Güncelle";
            daireGuncelleButton.UseVisualStyleBackColor = false;
            daireGuncelleButton.Click += DaireGuncelleButton_Click;
            // 
            // yeniDaireNumarasiNumericUpDown
            // 
            yeniDaireNumarasiNumericUpDown.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yeniDaireNumarasiNumericUpDown.Location = new Point(243, 77);
            yeniDaireNumarasiNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            yeniDaireNumarasiNumericUpDown.Name = "yeniDaireNumarasiNumericUpDown";
            yeniDaireNumarasiNumericUpDown.Size = new Size(140, 37);
            yeniDaireNumarasiNumericUpDown.TabIndex = 10;
            yeniDaireNumarasiNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // yeniDaireNumarasiLabel
            // 
            yeniDaireNumarasiLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yeniDaireNumarasiLabel.Location = new Point(6, 77);
            yeniDaireNumarasiLabel.Name = "yeniDaireNumarasiLabel";
            yeniDaireNumarasiLabel.Size = new Size(231, 37);
            yeniDaireNumarasiLabel.TabIndex = 8;
            yeniDaireNumarasiLabel.Text = "Yeni Daire Numarası";
            yeniDaireNumarasiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daireEkleSilGroupBox
            // 
            daireEkleSilGroupBox.BackColor = Color.Gainsboro;
            daireEkleSilGroupBox.Controls.Add(daireNumarasiNumericUpDown);
            daireEkleSilGroupBox.Controls.Add(daireNumarasiLabel);
            daireEkleSilGroupBox.Controls.Add(daireEkleButton);
            daireEkleSilGroupBox.Controls.Add(daireSilButton);
            daireEkleSilGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            daireEkleSilGroupBox.Location = new Point(16, 63);
            daireEkleSilGroupBox.Name = "daireEkleSilGroupBox";
            daireEkleSilGroupBox.Size = new Size(385, 130);
            daireEkleSilGroupBox.TabIndex = 1;
            daireEkleSilGroupBox.TabStop = false;
            daireEkleSilGroupBox.Text = "Daire Ekleme-Silme";
            // 
            // daireNumarasiNumericUpDown
            // 
            daireNumarasiNumericUpDown.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiNumericUpDown.Location = new Point(196, 32);
            daireNumarasiNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown.Name = "daireNumarasiNumericUpDown";
            daireNumarasiNumericUpDown.Size = new Size(172, 37);
            daireNumarasiNumericUpDown.TabIndex = 3;
            daireNumarasiNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // daireNumarasiLabel
            // 
            daireNumarasiLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiLabel.Location = new Point(6, 32);
            daireNumarasiLabel.Name = "daireNumarasiLabel";
            daireNumarasiLabel.Size = new Size(184, 37);
            daireNumarasiLabel.TabIndex = 2;
            daireNumarasiLabel.Text = "Daire Numarası";
            daireNumarasiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daireEkleButton
            // 
            daireEkleButton.BackColor = Color.LightGreen;
            daireEkleButton.Cursor = Cursors.Hand;
            daireEkleButton.Location = new Point(196, 77);
            daireEkleButton.Name = "daireEkleButton";
            daireEkleButton.Size = new Size(172, 47);
            daireEkleButton.TabIndex = 5;
            daireEkleButton.Text = "Daireyi Ekle";
            daireEkleButton.UseVisualStyleBackColor = false;
            daireEkleButton.Click += DaireEkleButton_Click;
            // 
            // daireSilButton
            // 
            daireSilButton.BackColor = Color.IndianRed;
            daireSilButton.Cursor = Cursors.Hand;
            daireSilButton.Location = new Point(6, 77);
            daireSilButton.Name = "daireSilButton";
            daireSilButton.Size = new Size(184, 47);
            daireSilButton.TabIndex = 4;
            daireSilButton.Text = "Daireyi Sil";
            daireSilButton.UseVisualStyleBackColor = false;
            daireSilButton.Click += DaireSilButton_Click;
            // 
            // mekanlariGoruntuleButton
            // 
            mekanlariGoruntuleButton.BackColor = Color.Wheat;
            mekanlariGoruntuleButton.Cursor = Cursors.Hand;
            mekanlariGoruntuleButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mekanlariGoruntuleButton.Location = new Point(16, 198);
            mekanlariGoruntuleButton.Name = "mekanlariGoruntuleButton";
            mekanlariGoruntuleButton.Size = new Size(1025, 55);
            mekanlariGoruntuleButton.TabIndex = 12;
            mekanlariGoruntuleButton.Text = "Mekanları Görüntüle";
            mekanlariGoruntuleButton.UseVisualStyleBackColor = false;
            mekanlariGoruntuleButton.Click += MekanlariGoruntuleButton_Click;
            // 
            // dairelerListBox
            // 
            dairelerListBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dairelerListBox.FormattingEnabled = true;
            dairelerListBox.Location = new Point(16, 257);
            dairelerListBox.Name = "dairelerListBox";
            dairelerListBox.Size = new Size(1025, 394);
            dairelerListBox.TabIndex = 13;
            // 
            // mekanIslemleriLabel
            // 
            mekanIslemleriLabel.BackColor = Color.Gainsboro;
            mekanIslemleriLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mekanIslemleriLabel.Location = new Point(16, 8);
            mekanIslemleriLabel.Name = "mekanIslemleriLabel";
            mekanIslemleriLabel.Size = new Size(1025, 44);
            mekanIslemleriLabel.TabIndex = 0;
            mekanIslemleriLabel.Text = "~MEKAN İŞLEMLERİ~";
            mekanIslemleriLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MekanYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 663);
            Controls.Add(mekanIslemleriLabel);
            Controls.Add(dairelerListBox);
            Controls.Add(mekanlariGoruntuleButton);
            Controls.Add(daireEkleSilGroupBox);
            Controls.Add(daireGuncellemeGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MekanYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mekan Yönetim Paneli";
            Load += MekanYonetimForm_Load;
            daireGuncellemeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eskiDaireNumarasiNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yeniDaireNumarasiNumericUpDown).EndInit();
            daireEkleSilGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox daireGuncellemeGroupBox;
        private Label eskiDaireNumarasiLabel;
        private NumericUpDown eskiDaireNumarasiNumericUpDown;
        private Button daireGuncelleButton;
        private NumericUpDown yeniDaireNumarasiNumericUpDown;
        private Label yeniDaireNumarasiLabel;
        private GroupBox daireEkleSilGroupBox;
        private NumericUpDown daireNumarasiNumericUpDown;
        private Label daireNumarasiLabel;
        private Button daireEkleButton;
        private Button daireSilButton;
        private Button mekanlariGoruntuleButton;
        private ListBox dairelerListBox;
        private Label mekanIslemleriLabel;
    }
}