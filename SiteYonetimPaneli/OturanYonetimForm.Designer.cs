namespace SiteYonetimPaneli
{
    partial class OturanYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OturanYonetimForm));
            oturanGuncelleGroupBox = new GroupBox();
            label1 = new Label();
            misafirRadioButton2 = new RadioButton();
            aileReisiRadioButton2 = new RadioButton();
            oturanGuncelleButton = new Button();
            daireNumarasiNumericUpDown2 = new NumericUpDown();
            daireNumarasiLabel2 = new Label();
            yeniOturanAdiTextBox = new TextBox();
            yeniOturanAdiLabel = new Label();
            eskiOturanAdiTextBox = new TextBox();
            eskiOturanAdiLabel = new Label();
            oturanEkleSilGroupBox = new GroupBox();
            misafirRadioButton1 = new RadioButton();
            aileReisiRadioButton1 = new RadioButton();
            daireNumarasiNumericUpDown1 = new NumericUpDown();
            oturanEkleButton = new Button();
            oturanSilButton = new Button();
            daireNumarasiLabel1 = new Label();
            oturanAdiTextBox = new TextBox();
            oturanAdiLabel = new Label();
            oturanlariGoruntuleButton = new Button();
            oturanlarListBox = new ListBox();
            oturanIslemleriLabel = new Label();
            oturanGuncelleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown2).BeginInit();
            oturanEkleSilGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // oturanGuncelleGroupBox
            // 
            oturanGuncelleGroupBox.BackColor = Color.Gainsboro;
            oturanGuncelleGroupBox.Controls.Add(label1);
            oturanGuncelleGroupBox.Controls.Add(misafirRadioButton2);
            oturanGuncelleGroupBox.Controls.Add(aileReisiRadioButton2);
            oturanGuncelleGroupBox.Controls.Add(oturanGuncelleButton);
            oturanGuncelleGroupBox.Controls.Add(daireNumarasiNumericUpDown2);
            oturanGuncelleGroupBox.Controls.Add(daireNumarasiLabel2);
            oturanGuncelleGroupBox.Controls.Add(yeniOturanAdiTextBox);
            oturanGuncelleGroupBox.Controls.Add(yeniOturanAdiLabel);
            oturanGuncelleGroupBox.Controls.Add(eskiOturanAdiTextBox);
            oturanGuncelleGroupBox.Controls.Add(eskiOturanAdiLabel);
            oturanGuncelleGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oturanGuncelleGroupBox.Location = new Point(425, 68);
            oturanGuncelleGroupBox.Name = "oturanGuncelleGroupBox";
            oturanGuncelleGroupBox.Size = new Size(618, 223);
            oturanGuncelleGroupBox.TabIndex = 10;
            oturanGuncelleGroupBox.TabStop = false;
            oturanGuncelleGroupBox.Text = "Oturan Güncelleme";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(428, 33);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 20;
            label1.Text = "Eski Oturan Türü";
            // 
            // misafirRadioButton2
            // 
            misafirRadioButton2.Font = new Font("Segoe UI", 13.2000008F);
            misafirRadioButton2.Location = new Point(456, 123);
            misafirRadioButton2.Name = "misafirRadioButton2";
            misafirRadioButton2.Size = new Size(127, 35);
            misafirRadioButton2.TabIndex = 18;
            misafirRadioButton2.TabStop = true;
            misafirRadioButton2.Text = "Misafir";
            misafirRadioButton2.UseVisualStyleBackColor = true;
            // 
            // aileReisiRadioButton2
            // 
            aileReisiRadioButton2.Font = new Font("Segoe UI", 13.2000008F);
            aileReisiRadioButton2.Location = new Point(456, 76);
            aileReisiRadioButton2.Name = "aileReisiRadioButton2";
            aileReisiRadioButton2.Size = new Size(127, 37);
            aileReisiRadioButton2.TabIndex = 17;
            aileReisiRadioButton2.TabStop = true;
            aileReisiRadioButton2.Text = "Aile Reisi";
            aileReisiRadioButton2.UseVisualStyleBackColor = true;
            // 
            // oturanGuncelleButton
            // 
            oturanGuncelleButton.BackColor = Color.MediumTurquoise;
            oturanGuncelleButton.Cursor = Cursors.Hand;
            oturanGuncelleButton.Location = new Point(6, 166);
            oturanGuncelleButton.Name = "oturanGuncelleButton";
            oturanGuncelleButton.Size = new Size(606, 54);
            oturanGuncelleButton.TabIndex = 19;
            oturanGuncelleButton.Text = "Oturanı Güncelle";
            oturanGuncelleButton.UseVisualStyleBackColor = false;
            oturanGuncelleButton.Click += OturanGuncelleButton_Click;
            // 
            // daireNumarasiNumericUpDown2
            // 
            daireNumarasiNumericUpDown2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiNumericUpDown2.Location = new Point(189, 123);
            daireNumarasiNumericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown2.Name = "daireNumarasiNumericUpDown2";
            daireNumarasiNumericUpDown2.Size = new Size(236, 37);
            daireNumarasiNumericUpDown2.TabIndex = 16;
            daireNumarasiNumericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // daireNumarasiLabel2
            // 
            daireNumarasiLabel2.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiLabel2.Location = new Point(6, 123);
            daireNumarasiLabel2.Name = "daireNumarasiLabel2";
            daireNumarasiLabel2.Size = new Size(177, 37);
            daireNumarasiLabel2.TabIndex = 15;
            daireNumarasiLabel2.Text = "Daire Numarası";
            daireNumarasiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yeniOturanAdiTextBox
            // 
            yeniOturanAdiTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yeniOturanAdiTextBox.Location = new Point(189, 76);
            yeniOturanAdiTextBox.Name = "yeniOturanAdiTextBox";
            yeniOturanAdiTextBox.Size = new Size(236, 37);
            yeniOturanAdiTextBox.TabIndex = 14;
            // 
            // yeniOturanAdiLabel
            // 
            yeniOturanAdiLabel.Font = new Font("Segoe UI", 13.2000008F);
            yeniOturanAdiLabel.Location = new Point(6, 76);
            yeniOturanAdiLabel.Name = "yeniOturanAdiLabel";
            yeniOturanAdiLabel.Size = new Size(177, 37);
            yeniOturanAdiLabel.TabIndex = 13;
            yeniOturanAdiLabel.Text = "Yeni Ad-Soyad";
            yeniOturanAdiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eskiOturanAdiTextBox
            // 
            eskiOturanAdiTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            eskiOturanAdiTextBox.Location = new Point(189, 33);
            eskiOturanAdiTextBox.Name = "eskiOturanAdiTextBox";
            eskiOturanAdiTextBox.Size = new Size(236, 37);
            eskiOturanAdiTextBox.TabIndex = 12;
            // 
            // eskiOturanAdiLabel
            // 
            eskiOturanAdiLabel.Font = new Font("Segoe UI", 13.2000008F);
            eskiOturanAdiLabel.Location = new Point(6, 33);
            eskiOturanAdiLabel.Name = "eskiOturanAdiLabel";
            eskiOturanAdiLabel.Size = new Size(177, 37);
            eskiOturanAdiLabel.TabIndex = 11;
            eskiOturanAdiLabel.Text = "Eski Ad-Soyad";
            eskiOturanAdiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oturanEkleSilGroupBox
            // 
            oturanEkleSilGroupBox.BackColor = Color.Gainsboro;
            oturanEkleSilGroupBox.Controls.Add(misafirRadioButton1);
            oturanEkleSilGroupBox.Controls.Add(aileReisiRadioButton1);
            oturanEkleSilGroupBox.Controls.Add(daireNumarasiNumericUpDown1);
            oturanEkleSilGroupBox.Controls.Add(oturanEkleButton);
            oturanEkleSilGroupBox.Controls.Add(oturanSilButton);
            oturanEkleSilGroupBox.Controls.Add(daireNumarasiLabel1);
            oturanEkleSilGroupBox.Controls.Add(oturanAdiTextBox);
            oturanEkleSilGroupBox.Controls.Add(oturanAdiLabel);
            oturanEkleSilGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oturanEkleSilGroupBox.Location = new Point(12, 68);
            oturanEkleSilGroupBox.Name = "oturanEkleSilGroupBox";
            oturanEkleSilGroupBox.Size = new Size(403, 223);
            oturanEkleSilGroupBox.TabIndex = 1;
            oturanEkleSilGroupBox.TabStop = false;
            oturanEkleSilGroupBox.Text = "Oturan Ekleme-Silme";
            // 
            // misafirRadioButton1
            // 
            misafirRadioButton1.AutoSize = true;
            misafirRadioButton1.Font = new Font("Segoe UI", 13.2000008F);
            misafirRadioButton1.Location = new Point(145, 123);
            misafirRadioButton1.Name = "misafirRadioButton1";
            misafirRadioButton1.Size = new Size(105, 35);
            misafirRadioButton1.TabIndex = 7;
            misafirRadioButton1.TabStop = true;
            misafirRadioButton1.Text = "Misafir";
            misafirRadioButton1.UseVisualStyleBackColor = true;
            // 
            // aileReisiRadioButton1
            // 
            aileReisiRadioButton1.AutoSize = true;
            aileReisiRadioButton1.Font = new Font("Segoe UI", 13.2000008F);
            aileReisiRadioButton1.Location = new Point(12, 123);
            aileReisiRadioButton1.Name = "aileReisiRadioButton1";
            aileReisiRadioButton1.Size = new Size(127, 35);
            aileReisiRadioButton1.TabIndex = 6;
            aileReisiRadioButton1.TabStop = true;
            aileReisiRadioButton1.Text = "Aile Reisi";
            aileReisiRadioButton1.UseVisualStyleBackColor = true;
            // 
            // daireNumarasiNumericUpDown1
            // 
            daireNumarasiNumericUpDown1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiNumericUpDown1.Location = new Point(189, 76);
            daireNumarasiNumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown1.Name = "daireNumarasiNumericUpDown1";
            daireNumarasiNumericUpDown1.Size = new Size(202, 37);
            daireNumarasiNumericUpDown1.TabIndex = 5;
            daireNumarasiNumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // oturanEkleButton
            // 
            oturanEkleButton.BackColor = Color.LightGreen;
            oturanEkleButton.Cursor = Cursors.Hand;
            oturanEkleButton.Location = new Point(200, 166);
            oturanEkleButton.Name = "oturanEkleButton";
            oturanEkleButton.Size = new Size(191, 54);
            oturanEkleButton.TabIndex = 9;
            oturanEkleButton.Text = "Oturanı Ekle";
            oturanEkleButton.UseVisualStyleBackColor = false;
            oturanEkleButton.Click += OturanEkleButton_Click;
            // 
            // oturanSilButton
            // 
            oturanSilButton.BackColor = Color.IndianRed;
            oturanSilButton.Cursor = Cursors.Hand;
            oturanSilButton.Location = new Point(6, 166);
            oturanSilButton.Name = "oturanSilButton";
            oturanSilButton.Size = new Size(191, 54);
            oturanSilButton.TabIndex = 8;
            oturanSilButton.Text = "Oturanı Sil";
            oturanSilButton.UseVisualStyleBackColor = false;
            oturanSilButton.Click += OturanSilButton_Click;
            // 
            // daireNumarasiLabel1
            // 
            daireNumarasiLabel1.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiLabel1.Location = new Point(6, 76);
            daireNumarasiLabel1.Name = "daireNumarasiLabel1";
            daireNumarasiLabel1.Size = new Size(177, 37);
            daireNumarasiLabel1.TabIndex = 3;
            daireNumarasiLabel1.Text = "Daire Numarası";
            daireNumarasiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oturanAdiTextBox
            // 
            oturanAdiTextBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            oturanAdiTextBox.Location = new Point(189, 33);
            oturanAdiTextBox.Name = "oturanAdiTextBox";
            oturanAdiTextBox.Size = new Size(202, 37);
            oturanAdiTextBox.TabIndex = 4;
            // 
            // oturanAdiLabel
            // 
            oturanAdiLabel.Font = new Font("Segoe UI", 13.2000008F);
            oturanAdiLabel.Location = new Point(6, 33);
            oturanAdiLabel.Name = "oturanAdiLabel";
            oturanAdiLabel.Size = new Size(177, 37);
            oturanAdiLabel.TabIndex = 2;
            oturanAdiLabel.Text = "Ad-Soyad";
            oturanAdiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oturanlariGoruntuleButton
            // 
            oturanlariGoruntuleButton.BackColor = Color.Wheat;
            oturanlariGoruntuleButton.Cursor = Cursors.Hand;
            oturanlariGoruntuleButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oturanlariGoruntuleButton.Location = new Point(12, 298);
            oturanlariGoruntuleButton.Name = "oturanlariGoruntuleButton";
            oturanlariGoruntuleButton.Size = new Size(1031, 51);
            oturanlariGoruntuleButton.TabIndex = 20;
            oturanlariGoruntuleButton.Text = "Oturanları Görüntüle";
            oturanlariGoruntuleButton.UseVisualStyleBackColor = false;
            oturanlariGoruntuleButton.Click += OturanlariGoruntuleButton_Click;
            // 
            // oturanlarListBox
            // 
            oturanlarListBox.BackColor = SystemColors.Window;
            oturanlarListBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oturanlarListBox.FormattingEnabled = true;
            oturanlarListBox.Location = new Point(12, 353);
            oturanlarListBox.Name = "oturanlarListBox";
            oturanlarListBox.Size = new Size(1031, 304);
            oturanlarListBox.TabIndex = 21;
            // 
            // oturanIslemleriLabel
            // 
            oturanIslemleriLabel.BackColor = Color.Gainsboro;
            oturanIslemleriLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oturanIslemleriLabel.ImageAlign = ContentAlignment.MiddleRight;
            oturanIslemleriLabel.Location = new Point(12, 9);
            oturanIslemleriLabel.Name = "oturanIslemleriLabel";
            oturanIslemleriLabel.Size = new Size(1031, 48);
            oturanIslemleriLabel.TabIndex = 0;
            oturanIslemleriLabel.Text = "~OTURAN İŞLEMLERİ~";
            oturanIslemleriLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OturanYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 663);
            Controls.Add(oturanIslemleriLabel);
            Controls.Add(oturanlarListBox);
            Controls.Add(oturanlariGoruntuleButton);
            Controls.Add(oturanEkleSilGroupBox);
            Controls.Add(oturanGuncelleGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OturanYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oturan Yönetim Paneli";
            oturanGuncelleGroupBox.ResumeLayout(false);
            oturanGuncelleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown2).EndInit();
            oturanEkleSilGroupBox.ResumeLayout(false);
            oturanEkleSilGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox oturanGuncelleGroupBox;
        private RadioButton misafirRadioButton2;
        private RadioButton aileReisiRadioButton2;
        private Button oturanGuncelleButton;
        private NumericUpDown daireNumarasiNumericUpDown2;
        private Label daireNumarasiLabel2;
        private TextBox yeniOturanAdiTextBox;
        private Label yeniOturanAdiLabel;
        private TextBox eskiOturanAdiTextBox;
        private Label eskiOturanAdiLabel;
        private GroupBox oturanEkleSilGroupBox;
        private RadioButton misafirRadioButton1;
        private RadioButton aileReisiRadioButton1;
        private NumericUpDown daireNumarasiNumericUpDown1;
        private Button oturanEkleButton;
        private Button oturanSilButton;
        private Label daireNumarasiLabel1;
        private TextBox oturanAdiTextBox;
        private Label oturanAdiLabel;
        private Button oturanlariGoruntuleButton;
        private ListBox oturanlarListBox;
        private Label oturanIslemleriLabel;
        private Label label1;
    }
}