namespace MuellimlerAIS
{
    partial class FormGiris
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
            this.labelNazirlik = new System.Windows.Forms.Label();
            this.buttonGir = new System.Windows.Forms.Button();
            this.labelAIS = new System.Windows.Forms.Label();
            this.comboBoxUniversitet = new System.Windows.Forms.ComboBox();
            this.buttonDuzelt = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonLogoDeyisdir = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNazirlik
            // 
            this.labelNazirlik.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNazirlik.Location = new System.Drawing.Point(202, 12);
            this.labelNazirlik.Name = "labelNazirlik";
            this.labelNazirlik.Size = new System.Drawing.Size(370, 96);
            this.labelNazirlik.TabIndex = 0;
            this.labelNazirlik.Text = "Azərbaycan Respublikası Təhsil Nazirliyi";
            this.labelNazirlik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGir
            // 
            this.buttonGir.Location = new System.Drawing.Point(497, 199);
            this.buttonGir.Name = "buttonGir";
            this.buttonGir.Size = new System.Drawing.Size(75, 23);
            this.buttonGir.TabIndex = 3;
            this.buttonGir.Text = "Gir";
            this.buttonGir.UseVisualStyleBackColor = true;
            this.buttonGir.Click += new System.EventHandler(this.buttonGir_Click);
            // 
            // labelAIS
            // 
            this.labelAIS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAIS.Location = new System.Drawing.Point(204, 160);
            this.labelAIS.Name = "labelAIS";
            this.labelAIS.Size = new System.Drawing.Size(368, 36);
            this.labelAIS.TabIndex = 2;
            this.labelAIS.Text = "Müəllimlər AİS";
            this.labelAIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUniversitet
            // 
            this.comboBoxUniversitet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniversitet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxUniversitet.FormattingEnabled = true;
            this.comboBoxUniversitet.Items.AddRange(new object[] {
            "Azərbaycan Texniki Universiteti"});
            this.comboBoxUniversitet.Location = new System.Drawing.Point(208, 118);
            this.comboBoxUniversitet.Name = "comboBoxUniversitet";
            this.comboBoxUniversitet.Size = new System.Drawing.Size(364, 29);
            this.comboBoxUniversitet.TabIndex = 1;
            this.comboBoxUniversitet.SelectedIndexChanged += new System.EventHandler(this.comboBoxUniversitet_SelectedIndexChanged);
            // 
            // buttonDuzelt
            // 
            this.buttonDuzelt.Location = new System.Drawing.Point(12, 199);
            this.buttonDuzelt.Name = "buttonDuzelt";
            this.buttonDuzelt.Size = new System.Drawing.Size(75, 23);
            this.buttonDuzelt.TabIndex = 4;
            this.buttonDuzelt.Text = "Düzəlt";
            this.buttonDuzelt.UseVisualStyleBackColor = true;
            this.buttonDuzelt.Click += new System.EventHandler(this.buttonDuzelt_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(150, 236);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(179, 20);
            this.textBoxAd.TabIndex = 7;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(118, 239);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 6;
            this.labelAd.Text = "Ad :";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(497, 234);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 23);
            this.buttonSil.TabIndex = 10;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(416, 234);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(75, 23);
            this.buttonSaxla.TabIndex = 9;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(335, 234);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(75, 23);
            this.buttonYeni.TabIndex = 8;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonLogoDeyisdir
            // 
            this.buttonLogoDeyisdir.Location = new System.Drawing.Point(12, 234);
            this.buttonLogoDeyisdir.Name = "buttonLogoDeyisdir";
            this.buttonLogoDeyisdir.Size = new System.Drawing.Size(100, 23);
            this.buttonLogoDeyisdir.TabIndex = 5;
            this.buttonLogoDeyisdir.Text = "Logo Dəyişdir";
            this.buttonLogoDeyisdir.UseVisualStyleBackColor = true;
            this.buttonLogoDeyisdir.Click += new System.EventHandler(this.buttonLogoDeyisdir_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(184, 184);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.Filter = "GIF|*.gif|PNG|*.png|JPG|*.jpg";
            // 
            // FormGiris
            // 
            this.AcceptButton = this.buttonGir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.buttonLogoDeyisdir);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.buttonDuzelt);
            this.Controls.Add(this.comboBoxUniversitet);
            this.Controls.Add(this.labelAIS);
            this.Controls.Add(this.buttonGir);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelNazirlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGiris";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müəllimlər AİS - Giriş";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazirlik;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonGir;
        private System.Windows.Forms.Label labelAIS;
        private System.Windows.Forms.ComboBox comboBoxUniversitet;
        private System.Windows.Forms.Button buttonDuzelt;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonLogoDeyisdir;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
    }
}

