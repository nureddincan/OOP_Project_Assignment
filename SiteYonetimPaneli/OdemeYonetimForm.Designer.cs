namespace SiteYonetimPaneli
{
    partial class OdemeYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeYonetimForm));
            odemeEkleSilGroupBox = new GroupBox();
            odemediRadioButton1 = new RadioButton();
            odediRadioButton1 = new RadioButton();
            odemeSilButton = new Button();
            daireNumarasiNumericUpDown1 = new NumericUpDown();
            odemeEkleButton = new Button();
            daireNumarasiLabel1 = new Label();
            odemeGuncelleGroupBox = new GroupBox();
            odemeGuncelleButton = new Button();
            odemediRadioButton2 = new RadioButton();
            odediRadioButton2 = new RadioButton();
            daireNumarasiNumericUpDown2 = new NumericUpDown();
            daireNumarasiLabel2 = new Label();
            odemeGoruntuleButton = new Button();
            odemelerListBox = new ListBox();
            odemeIslemleriLabel = new Label();
            odemeEkleSilGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown1).BeginInit();
            odemeGuncelleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // odemeEkleSilGroupBox
            // 
            odemeEkleSilGroupBox.BackColor = Color.Gainsboro;
            odemeEkleSilGroupBox.Controls.Add(odemediRadioButton1);
            odemeEkleSilGroupBox.Controls.Add(odediRadioButton1);
            odemeEkleSilGroupBox.Controls.Add(odemeSilButton);
            odemeEkleSilGroupBox.Controls.Add(daireNumarasiNumericUpDown1);
            odemeEkleSilGroupBox.Controls.Add(odemeEkleButton);
            odemeEkleSilGroupBox.Controls.Add(daireNumarasiLabel1);
            odemeEkleSilGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeEkleSilGroupBox.Location = new Point(12, 65);
            odemeEkleSilGroupBox.Name = "odemeEkleSilGroupBox";
            odemeEkleSilGroupBox.Size = new Size(502, 165);
            odemeEkleSilGroupBox.TabIndex = 1;
            odemeEkleSilGroupBox.TabStop = false;
            odemeEkleSilGroupBox.Text = "Ödeme Ekleme-Silme";
            // 
            // odemediRadioButton1
            // 
            odemediRadioButton1.AutoSize = true;
            odemediRadioButton1.Font = new Font("Segoe UI", 13.2000008F);
            odemediRadioButton1.Location = new Point(123, 73);
            odemediRadioButton1.Name = "odemediRadioButton1";
            odemediRadioButton1.Size = new Size(130, 35);
            odemediRadioButton1.TabIndex = 5;
            odemediRadioButton1.TabStop = true;
            odemediRadioButton1.Text = "Ödemedi";
            odemediRadioButton1.UseVisualStyleBackColor = true;
            // 
            // odediRadioButton1
            // 
            odediRadioButton1.AutoSize = true;
            odediRadioButton1.Font = new Font("Segoe UI", 13.2000008F);
            odediRadioButton1.Location = new Point(12, 73);
            odediRadioButton1.Name = "odediRadioButton1";
            odediRadioButton1.Size = new Size(98, 35);
            odediRadioButton1.TabIndex = 4;
            odediRadioButton1.TabStop = true;
            odediRadioButton1.Text = "Ödedi";
            odediRadioButton1.UseVisualStyleBackColor = true;
            // 
            // odemeSilButton
            // 
            odemeSilButton.BackColor = Color.IndianRed;
            odemeSilButton.Cursor = Cursors.Hand;
            odemeSilButton.Location = new Point(6, 114);
            odemeSilButton.Name = "odemeSilButton";
            odemeSilButton.Size = new Size(247, 45);
            odemeSilButton.TabIndex = 6;
            odemeSilButton.Text = "Ödemeyi Sil";
            odemeSilButton.UseVisualStyleBackColor = false;
            odemeSilButton.Click += OdemeSilButton_Click;
            // 
            // daireNumarasiNumericUpDown1
            // 
            daireNumarasiNumericUpDown1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiNumericUpDown1.Location = new Point(259, 33);
            daireNumarasiNumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown1.Name = "daireNumarasiNumericUpDown1";
            daireNumarasiNumericUpDown1.Size = new Size(237, 37);
            daireNumarasiNumericUpDown1.TabIndex = 3;
            daireNumarasiNumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // odemeEkleButton
            // 
            odemeEkleButton.BackColor = Color.LightGreen;
            odemeEkleButton.Cursor = Cursors.Hand;
            odemeEkleButton.Location = new Point(259, 114);
            odemeEkleButton.Name = "odemeEkleButton";
            odemeEkleButton.Size = new Size(237, 45);
            odemeEkleButton.TabIndex = 7;
            odemeEkleButton.Text = "Ödemeyi Ekle";
            odemeEkleButton.UseVisualStyleBackColor = false;
            odemeEkleButton.Click += OdemeEkleButton_Click;
            // 
            // daireNumarasiLabel1
            // 
            daireNumarasiLabel1.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiLabel1.Location = new Point(6, 33);
            daireNumarasiLabel1.Name = "daireNumarasiLabel1";
            daireNumarasiLabel1.Size = new Size(247, 37);
            daireNumarasiLabel1.TabIndex = 2;
            daireNumarasiLabel1.Text = "Daire Numarası Giriniz";
            daireNumarasiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // odemeGuncelleGroupBox
            // 
            odemeGuncelleGroupBox.BackColor = Color.Gainsboro;
            odemeGuncelleGroupBox.Controls.Add(odemeGuncelleButton);
            odemeGuncelleGroupBox.Controls.Add(odemediRadioButton2);
            odemeGuncelleGroupBox.Controls.Add(odediRadioButton2);
            odemeGuncelleGroupBox.Controls.Add(daireNumarasiNumericUpDown2);
            odemeGuncelleGroupBox.Controls.Add(daireNumarasiLabel2);
            odemeGuncelleGroupBox.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeGuncelleGroupBox.Location = new Point(541, 64);
            odemeGuncelleGroupBox.Name = "odemeGuncelleGroupBox";
            odemeGuncelleGroupBox.Size = new Size(502, 166);
            odemeGuncelleGroupBox.TabIndex = 8;
            odemeGuncelleGroupBox.TabStop = false;
            odemeGuncelleGroupBox.Text = "Ödeme Güncelleme";
            // 
            // odemeGuncelleButton
            // 
            odemeGuncelleButton.BackColor = Color.MediumTurquoise;
            odemeGuncelleButton.Cursor = Cursors.Hand;
            odemeGuncelleButton.Location = new Point(6, 114);
            odemeGuncelleButton.Name = "odemeGuncelleButton";
            odemeGuncelleButton.Size = new Size(490, 45);
            odemeGuncelleButton.TabIndex = 13;
            odemeGuncelleButton.Text = "Ödemeyi Güncelle";
            odemeGuncelleButton.UseVisualStyleBackColor = false;
            odemeGuncelleButton.Click += OdemeGuncelleButton_Click;
            // 
            // odemediRadioButton2
            // 
            odemediRadioButton2.AutoSize = true;
            odemediRadioButton2.Font = new Font("Segoe UI", 13.2000008F);
            odemediRadioButton2.Location = new Point(123, 73);
            odemediRadioButton2.Name = "odemediRadioButton2";
            odemediRadioButton2.Size = new Size(130, 35);
            odemediRadioButton2.TabIndex = 12;
            odemediRadioButton2.TabStop = true;
            odemediRadioButton2.Text = "Ödemedi";
            odemediRadioButton2.UseVisualStyleBackColor = true;
            // 
            // odediRadioButton2
            // 
            odediRadioButton2.AutoSize = true;
            odediRadioButton2.Font = new Font("Segoe UI", 13.2000008F);
            odediRadioButton2.Location = new Point(12, 73);
            odediRadioButton2.Name = "odediRadioButton2";
            odediRadioButton2.Size = new Size(98, 35);
            odediRadioButton2.TabIndex = 11;
            odediRadioButton2.TabStop = true;
            odediRadioButton2.Text = "Ödedi";
            odediRadioButton2.UseVisualStyleBackColor = true;
            // 
            // daireNumarasiNumericUpDown2
            // 
            daireNumarasiNumericUpDown2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 162);
            daireNumarasiNumericUpDown2.Location = new Point(259, 33);
            daireNumarasiNumericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown2.Name = "daireNumarasiNumericUpDown2";
            daireNumarasiNumericUpDown2.Size = new Size(237, 37);
            daireNumarasiNumericUpDown2.TabIndex = 10;
            daireNumarasiNumericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // daireNumarasiLabel2
            // 
            daireNumarasiLabel2.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiLabel2.Location = new Point(6, 33);
            daireNumarasiLabel2.Name = "daireNumarasiLabel2";
            daireNumarasiLabel2.Size = new Size(247, 37);
            daireNumarasiLabel2.TabIndex = 9;
            daireNumarasiLabel2.Text = "Daire Numarası Giriniz";
            daireNumarasiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // odemeGoruntuleButton
            // 
            odemeGoruntuleButton.BackColor = Color.Wheat;
            odemeGoruntuleButton.Cursor = Cursors.Hand;
            odemeGoruntuleButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeGoruntuleButton.Location = new Point(12, 235);
            odemeGoruntuleButton.Name = "odemeGoruntuleButton";
            odemeGoruntuleButton.Size = new Size(1031, 55);
            odemeGoruntuleButton.TabIndex = 14;
            odemeGoruntuleButton.Text = "Ödemeleri Görüntüle";
            odemeGoruntuleButton.UseVisualStyleBackColor = false;
            odemeGoruntuleButton.Click += OdemeGoruntuleButton_Click;
            // 
            // odemelerListBox
            // 
            odemelerListBox.BackColor = SystemColors.Window;
            odemelerListBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            odemelerListBox.FormattingEnabled = true;
            odemelerListBox.Location = new Point(12, 294);
            odemelerListBox.Name = "odemelerListBox";
            odemelerListBox.Size = new Size(1031, 364);
            odemelerListBox.TabIndex = 15;
            // 
            // odemeIslemleriLabel
            // 
            odemeIslemleriLabel.BackColor = Color.Gainsboro;
            odemeIslemleriLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeIslemleriLabel.ImageAlign = ContentAlignment.MiddleRight;
            odemeIslemleriLabel.Location = new Point(12, 6);
            odemeIslemleriLabel.Name = "odemeIslemleriLabel";
            odemeIslemleriLabel.Size = new Size(1031, 49);
            odemeIslemleriLabel.TabIndex = 0;
            odemeIslemleriLabel.Text = "~ÖDEME İŞLEMLERİ~";
            odemeIslemleriLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OdemeYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 663);
            Controls.Add(odemeIslemleriLabel);
            Controls.Add(odemelerListBox);
            Controls.Add(odemeGoruntuleButton);
            Controls.Add(odemeGuncelleGroupBox);
            Controls.Add(odemeEkleSilGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OdemeYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ödeme Yönetim Paneli";
            odemeEkleSilGroupBox.ResumeLayout(false);
            odemeEkleSilGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown1).EndInit();
            odemeGuncelleGroupBox.ResumeLayout(false);
            odemeGuncelleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox odemeEkleSilGroupBox;
        private RadioButton odemediRadioButton1;
        private RadioButton odediRadioButton1;
        private Button odemeSilButton;
        private NumericUpDown daireNumarasiNumericUpDown1;
        private Button odemeEkleButton;
        private Label daireNumarasiLabel1;
        private GroupBox odemeGuncelleGroupBox;
        private Button odemeGuncelleButton;
        private RadioButton odemediRadioButton2;
        private RadioButton odediRadioButton2;
        private NumericUpDown daireNumarasiNumericUpDown2;
        private Label daireNumarasiLabel2;
        private Button odemeGoruntuleButton;
        private ListBox odemelerListBox;
        private Label odemeIslemleriLabel;
    }
}