namespace MuellimlerAIS
{
    partial class FormIxtisaslar
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
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.comboBoxIxtisaslar = new System.Windows.Forms.ComboBox();
            this.buttonIxtisasDersleri = new System.Windows.Forms.Button();
            this.buttonIxtisasQruplari = new System.Windows.Forms.Button();
            this.labelTur = new System.Windows.Forms.Label();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(322, 93);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(150, 23);
            this.buttonSil.TabIndex = 21;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(171, 93);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(145, 23);
            this.buttonSaxla.TabIndex = 19;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(15, 93);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(150, 23);
            this.buttonYeni.TabIndex = 20;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(44, 40);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(428, 20);
            this.textBoxAd.TabIndex = 18;
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(10, 43);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 17;
            this.labelAd.Text = "Ad :";
            // 
            // comboBoxIxtisaslar
            // 
            this.comboBoxIxtisaslar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIxtisaslar.FormattingEnabled = true;
            this.comboBoxIxtisaslar.Location = new System.Drawing.Point(13, 13);
            this.comboBoxIxtisaslar.Name = "comboBoxIxtisaslar";
            this.comboBoxIxtisaslar.Size = new System.Drawing.Size(459, 21);
            this.comboBoxIxtisaslar.TabIndex = 16;
            this.comboBoxIxtisaslar.SelectedIndexChanged += new System.EventHandler(this.comboBoxIxtisaslar_SelectedIndexChanged);
            // 
            // buttonIxtisasDersleri
            // 
            this.buttonIxtisasDersleri.Location = new System.Drawing.Point(171, 122);
            this.buttonIxtisasDersleri.Name = "buttonIxtisasDersleri";
            this.buttonIxtisasDersleri.Size = new System.Drawing.Size(145, 23);
            this.buttonIxtisasDersleri.TabIndex = 22;
            this.buttonIxtisasDersleri.Text = "İxtisas Dərsləri";
            this.buttonIxtisasDersleri.UseVisualStyleBackColor = true;
            this.buttonIxtisasDersleri.Click += new System.EventHandler(this.buttonIxtisasDersleri_Click);
            // 
            // buttonIxtisasQruplari
            // 
            this.buttonIxtisasQruplari.Location = new System.Drawing.Point(322, 122);
            this.buttonIxtisasQruplari.Name = "buttonIxtisasQruplari";
            this.buttonIxtisasQruplari.Size = new System.Drawing.Size(150, 23);
            this.buttonIxtisasQruplari.TabIndex = 23;
            this.buttonIxtisasQruplari.Text = "İxtisas Qrupları";
            this.buttonIxtisasQruplari.UseVisualStyleBackColor = true;
            this.buttonIxtisasQruplari.Click += new System.EventHandler(this.buttonIxtisasQruplari_Click);
            // 
            // labelTur
            // 
            this.labelTur.AutoSize = true;
            this.labelTur.Location = new System.Drawing.Point(10, 69);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(29, 13);
            this.labelTur.TabIndex = 24;
            this.labelTur.Text = "Tür :";
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Location = new System.Drawing.Point(322, 66);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTur.TabIndex = 25;
            // 
            // FormIxtisaslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 159);
            this.Controls.Add(this.comboBoxTur);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.buttonIxtisasQruplari);
            this.Controls.Add(this.buttonIxtisasDersleri);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxIxtisaslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIxtisaslar";
            this.ShowIcon = false;
            this.Text = "İxtisaslar";
            this.Load += new System.EventHandler(this.FormIxtisaslar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.ComboBox comboBoxIxtisaslar;
        private System.Windows.Forms.Button buttonIxtisasDersleri;
        private System.Windows.Forms.Button buttonIxtisasQruplari;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.ComboBox comboBoxTur;
    }
}