namespace SiteYonetimPaneli
{
    partial class HavuzFitnessYonetimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavuzFitnessYonetimForm));
            daireNumarasiLabel = new Label();
            daireNumarasiNumericUpDown = new NumericUpDown();
            odemeIslemleriLabel = new Label();
            havuzKullanButton = new Button();
            fitnessKullanButton = new Button();
            havuzKullanimiButton = new Button();
            fitnessKullanimiButton = new Button();
            havuzKullanimListBox = new ListBox();
            fitnessKullanimListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // daireNumarasiLabel
            // 
            daireNumarasiLabel.BackColor = Color.Gainsboro;
            daireNumarasiLabel.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiLabel.Location = new Point(12, 64);
            daireNumarasiLabel.Name = "daireNumarasiLabel";
            daireNumarasiLabel.Size = new Size(515, 37);
            daireNumarasiLabel.TabIndex = 1;
            daireNumarasiLabel.Text = "Daire Numarasını Giriniz";
            daireNumarasiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daireNumarasiNumericUpDown
            // 
            daireNumarasiNumericUpDown.Font = new Font("Segoe UI", 13.2000008F);
            daireNumarasiNumericUpDown.Location = new Point(533, 64);
            daireNumarasiNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            daireNumarasiNumericUpDown.Name = "daireNumarasiNumericUpDown";
            daireNumarasiNumericUpDown.Size = new Size(515, 37);
            daireNumarasiNumericUpDown.TabIndex = 2;
            daireNumarasiNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // odemeIslemleriLabel
            // 
            odemeIslemleriLabel.BackColor = Color.Gainsboro;
            odemeIslemleriLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeIslemleriLabel.ImageAlign = ContentAlignment.MiddleRight;
            odemeIslemleriLabel.Location = new Point(12, 6);
            odemeIslemleriLabel.Name = "odemeIslemleriLabel";
            odemeIslemleriLabel.Size = new Size(1036, 49);
            odemeIslemleriLabel.TabIndex = 0;
            odemeIslemleriLabel.Text = "~HAVUZ-FİTNESS İŞLEMLERİ~";
            odemeIslemleriLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // havuzKullanButton
            // 
            havuzKullanButton.BackColor = Color.LightGreen;
            havuzKullanButton.Cursor = Cursors.Hand;
            havuzKullanButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            havuzKullanButton.Location = new Point(12, 108);
            havuzKullanButton.Name = "havuzKullanButton";
            havuzKullanButton.Size = new Size(515, 55);
            havuzKullanButton.TabIndex = 3;
            havuzKullanButton.Text = "Yüzme Havuzunu Kullan";
            havuzKullanButton.UseVisualStyleBackColor = false;
            havuzKullanButton.Click += HavuzKullanButton_Click;
            // 
            // fitnessKullanButton
            // 
            fitnessKullanButton.BackColor = Color.LightGreen;
            fitnessKullanButton.Cursor = Cursors.Hand;
            fitnessKullanButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            fitnessKullanButton.Location = new Point(533, 108);
            fitnessKullanButton.Name = "fitnessKullanButton";
            fitnessKullanButton.Size = new Size(515, 55);
            fitnessKullanButton.TabIndex = 4;
            fitnessKullanButton.Text = "Fitness Salonunu Kullan";
            fitnessKullanButton.UseVisualStyleBackColor = false;
            fitnessKullanButton.Click += FitnessKullanButton_Click;
            // 
            // havuzKullanimiButton
            // 
            havuzKullanimiButton.BackColor = Color.Wheat;
            havuzKullanimiButton.Cursor = Cursors.Hand;
            havuzKullanimiButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            havuzKullanimiButton.Location = new Point(12, 166);
            havuzKullanimiButton.Name = "havuzKullanimiButton";
            havuzKullanimiButton.Size = new Size(515, 55);
            havuzKullanimiButton.TabIndex = 5;
            havuzKullanimiButton.Text = "Havuz Kullanımını Görüntüle";
            havuzKullanimiButton.UseVisualStyleBackColor = false;
            havuzKullanimiButton.Click += HavuzKullanimiButton_Click;
            // 
            // fitnessKullanimiButton
            // 
            fitnessKullanimiButton.BackColor = Color.Wheat;
            fitnessKullanimiButton.Cursor = Cursors.Hand;
            fitnessKullanimiButton.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            fitnessKullanimiButton.Location = new Point(533, 166);
            fitnessKullanimiButton.Name = "fitnessKullanimiButton";
            fitnessKullanimiButton.Size = new Size(515, 55);
            fitnessKullanimiButton.TabIndex = 6;
            fitnessKullanimiButton.Text = "Fitness Kullanımını Görüntüle";
            fitnessKullanimiButton.UseVisualStyleBackColor = false;
            fitnessKullanimiButton.Click += FitnessKullanimiButton_Click;
            // 
            // havuzKullanimListBox
            // 
            havuzKullanimListBox.BackColor = SystemColors.Window;
            havuzKullanimListBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            havuzKullanimListBox.FormattingEnabled = true;
            havuzKullanimListBox.Location = new Point(12, 227);
            havuzKullanimListBox.Name = "havuzKullanimListBox";
            havuzKullanimListBox.Size = new Size(515, 424);
            havuzKullanimListBox.TabIndex = 7;
            // 
            // fitnessKullanimListBox
            // 
            fitnessKullanimListBox.BackColor = SystemColors.Window;
            fitnessKullanimListBox.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fitnessKullanimListBox.FormattingEnabled = true;
            fitnessKullanimListBox.Location = new Point(533, 227);
            fitnessKullanimListBox.Name = "fitnessKullanimListBox";
            fitnessKullanimListBox.Size = new Size(515, 424);
            fitnessKullanimListBox.TabIndex = 8;
            // 
            // HavuzFitnessYonetimForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 663);
            Controls.Add(fitnessKullanimListBox);
            Controls.Add(havuzKullanimListBox);
            Controls.Add(fitnessKullanimiButton);
            Controls.Add(havuzKullanimiButton);
            Controls.Add(fitnessKullanButton);
            Controls.Add(havuzKullanButton);
            Controls.Add(odemeIslemleriLabel);
            Controls.Add(daireNumarasiNumericUpDown);
            Controls.Add(daireNumarasiLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HavuzFitnessYonetimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Havuz-Fitness Yönetim Paneli";
            ((System.ComponentModel.ISupportInitialize)daireNumarasiNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label daireNumarasiLabel;
        private NumericUpDown daireNumarasiNumericUpDown;
        private Label odemeIslemleriLabel;
        private Button havuzKullanButton;
        private Button fitnessKullanButton;
        private Button havuzKullanimiButton;
        private Button fitnessKullanimiButton;
        private ListBox havuzKullanimListBox;
        private ListBox fitnessKullanimListBox;
    }
}