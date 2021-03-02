namespace MuellimlerAIS
{
    partial class FormKafedralar
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
            this.comboBoxKafedralar = new System.Windows.Forms.ComboBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelMudir = new System.Windows.Forms.Label();
            this.labelMudirMuavini = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.comboBoxMudir = new System.Windows.Forms.ComboBox();
            this.comboBoxMudirMuavini = new System.Windows.Forms.ComboBox();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonKafedraDersleri = new System.Windows.Forms.Button();
            this.buttonKafedraIxtisaslari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxKafedralar
            // 
            this.comboBoxKafedralar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKafedralar.FormattingEnabled = true;
            this.comboBoxKafedralar.Location = new System.Drawing.Point(12, 12);
            this.comboBoxKafedralar.Name = "comboBoxKafedralar";
            this.comboBoxKafedralar.Size = new System.Drawing.Size(360, 21);
            this.comboBoxKafedralar.TabIndex = 0;
            this.comboBoxKafedralar.SelectedIndexChanged += new System.EventHandler(this.comboBoxKafedralar_SelectedIndexChanged);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(9, 42);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 5;
            this.labelAd.Text = "Ad :";
            // 
            // labelMudir
            // 
            this.labelMudir.AutoSize = true;
            this.labelMudir.Location = new System.Drawing.Point(9, 68);
            this.labelMudir.Name = "labelMudir";
            this.labelMudir.Size = new System.Drawing.Size(39, 13);
            this.labelMudir.TabIndex = 7;
            this.labelMudir.Text = "Müdir :";
            // 
            // labelMudirMuavini
            // 
            this.labelMudirMuavini.AutoSize = true;
            this.labelMudirMuavini.Location = new System.Drawing.Point(9, 95);
            this.labelMudirMuavini.Name = "labelMudirMuavini";
            this.labelMudirMuavini.Size = new System.Drawing.Size(79, 13);
            this.labelMudirMuavini.TabIndex = 9;
            this.labelMudirMuavini.Text = "Müdir Muavini :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(172, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(200, 20);
            this.textBoxAd.TabIndex = 6;
            // 
            // comboBoxMudir
            // 
            this.comboBoxMudir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMudir.FormattingEnabled = true;
            this.comboBoxMudir.Location = new System.Drawing.Point(172, 65);
            this.comboBoxMudir.Name = "comboBoxMudir";
            this.comboBoxMudir.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMudir.TabIndex = 8;
            // 
            // comboBoxMudirMuavini
            // 
            this.comboBoxMudirMuavini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMudirMuavini.FormattingEnabled = true;
            this.comboBoxMudirMuavini.Location = new System.Drawing.Point(172, 92);
            this.comboBoxMudirMuavini.Name = "comboBoxMudirMuavini";
            this.comboBoxMudirMuavini.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMudirMuavini.TabIndex = 10;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 119);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(115, 23);
            this.buttonYeni.TabIndex = 11;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(133, 119);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(118, 23);
            this.buttonSaxla.TabIndex = 11;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(257, 119);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(115, 23);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonKafedraDersleri
            // 
            this.buttonKafedraDersleri.Location = new System.Drawing.Point(257, 148);
            this.buttonKafedraDersleri.Name = "buttonKafedraDersleri";
            this.buttonKafedraDersleri.Size = new System.Drawing.Size(115, 23);
            this.buttonKafedraDersleri.TabIndex = 13;
            this.buttonKafedraDersleri.Text = "Kafedra Dərsləri";
            this.buttonKafedraDersleri.UseVisualStyleBackColor = true;
            this.buttonKafedraDersleri.Click += new System.EventHandler(this.buttonKafedraDersleri_Click);
            // 
            // buttonKafedraIxtisaslari
            // 
            this.buttonKafedraIxtisaslari.Location = new System.Drawing.Point(133, 147);
            this.buttonKafedraIxtisaslari.Name = "buttonKafedraIxtisaslari";
            this.buttonKafedraIxtisaslari.Size = new System.Drawing.Size(118, 23);
            this.buttonKafedraIxtisaslari.TabIndex = 14;
            this.buttonKafedraIxtisaslari.Text = "Kafedra İxtisasları";
            this.buttonKafedraIxtisaslari.UseVisualStyleBackColor = true;
            this.buttonKafedraIxtisaslari.Click += new System.EventHandler(this.buttonKafedraIxtisaslari_Click);
            // 
            // FormKafedralar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 182);
            this.Controls.Add(this.buttonKafedraIxtisaslari);
            this.Controls.Add(this.buttonKafedraDersleri);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.comboBoxMudirMuavini);
            this.Controls.Add(this.comboBoxMudir);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelMudirMuavini);
            this.Controls.Add(this.labelMudir);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxKafedralar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKafedralar";
            this.ShowIcon = false;
            this.Text = "Kafedralar";
            this.Load += new System.EventHandler(this.FormKafedralar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKafedralar;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelMudir;
        private System.Windows.Forms.Label labelMudirMuavini;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.ComboBox comboBoxMudir;
        private System.Windows.Forms.ComboBox comboBoxMudirMuavini;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonKafedraDersleri;
        private System.Windows.Forms.Button buttonKafedraIxtisaslari;
    }
}