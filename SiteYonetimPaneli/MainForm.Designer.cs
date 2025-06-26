namespace SiteYonetimPaneli
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            hosgeldinLabel = new Label();
            mekanIslemleriButton = new Button();
            oturanIslemleriButton = new Button();
            odemeIslemleriButton = new Button();
            havuzFitnessIslemleriButton = new Button();
            SuspendLayout();
            // 
            // hosgeldinLabel
            // 
            hosgeldinLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hosgeldinLabel.Location = new Point(12, 9);
            hosgeldinLabel.Name = "hosgeldinLabel";
            hosgeldinLabel.Size = new Size(701, 76);
            hosgeldinLabel.TabIndex = 0;
            hosgeldinLabel.Text = "Site Yönetim Paneline Hoşgeldiniz!";
            hosgeldinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mekanIslemleriButton
            // 
            mekanIslemleriButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            mekanIslemleriButton.Image = Properties.Resources.mekan_islemleri_icon;
            mekanIslemleriButton.ImageAlign = ContentAlignment.MiddleLeft;
            mekanIslemleriButton.Location = new Point(12, 98);
            mekanIslemleriButton.Name = "mekanIslemleriButton";
            mekanIslemleriButton.Size = new Size(701, 70);
            mekanIslemleriButton.TabIndex = 1;
            mekanIslemleriButton.Text = "Mekan İşlemleri";
            mekanIslemleriButton.UseVisualStyleBackColor = true;
            mekanIslemleriButton.Click += MekanIslemleriButton_Click;
            // 
            // oturanIslemleriButton
            // 
            oturanIslemleriButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            oturanIslemleriButton.Image = Properties.Resources.oturan_islemleri_icon;
            oturanIslemleriButton.ImageAlign = ContentAlignment.MiddleLeft;
            oturanIslemleriButton.Location = new Point(12, 174);
            oturanIslemleriButton.Name = "oturanIslemleriButton";
            oturanIslemleriButton.Size = new Size(701, 70);
            oturanIslemleriButton.TabIndex = 2;
            oturanIslemleriButton.Text = "Oturan İşlemleri";
            oturanIslemleriButton.UseVisualStyleBackColor = true;
            oturanIslemleriButton.Click += OturanIslemleriButton_Click;
            // 
            // odemeIslemleriButton
            // 
            odemeIslemleriButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            odemeIslemleriButton.Image = Properties.Resources.odeme_islemleri_icon;
            odemeIslemleriButton.ImageAlign = ContentAlignment.MiddleLeft;
            odemeIslemleriButton.Location = new Point(12, 250);
            odemeIslemleriButton.Name = "odemeIslemleriButton";
            odemeIslemleriButton.Size = new Size(701, 70);
            odemeIslemleriButton.TabIndex = 3;
            odemeIslemleriButton.Text = "Ödeme İşlemleri";
            odemeIslemleriButton.UseVisualStyleBackColor = true;
            odemeIslemleriButton.Click += OdemeIslemleriButton_Click;
            // 
            // havuzFitnessIslemleriButton
            // 
            havuzFitnessIslemleriButton.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            havuzFitnessIslemleriButton.Image = Properties.Resources.yuzme_fitness_islemleri_icon1;
            havuzFitnessIslemleriButton.ImageAlign = ContentAlignment.MiddleLeft;
            havuzFitnessIslemleriButton.Location = new Point(12, 326);
            havuzFitnessIslemleriButton.Name = "havuzFitnessIslemleriButton";
            havuzFitnessIslemleriButton.Size = new Size(701, 70);
            havuzFitnessIslemleriButton.TabIndex = 4;
            havuzFitnessIslemleriButton.Text = "Havuz-Fitness İşlemleri";
            havuzFitnessIslemleriButton.UseVisualStyleBackColor = true;
            havuzFitnessIslemleriButton.Click += HavuzFitnessIslemleriButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 408);
            Controls.Add(havuzFitnessIslemleriButton);
            Controls.Add(odemeIslemleriButton);
            Controls.Add(oturanIslemleriButton);
            Controls.Add(mekanIslemleriButton);
            Controls.Add(hosgeldinLabel);
            Font = new Font("Segoe UI", 15F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Site Yönetim Paneli";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label hosgeldinLabel;
        private Button mekanIslemleriButton;
        private Button oturanIslemleriButton;
        private Button odemeIslemleriButton;
        private Button havuzFitnessIslemleriButton;
    }
}
