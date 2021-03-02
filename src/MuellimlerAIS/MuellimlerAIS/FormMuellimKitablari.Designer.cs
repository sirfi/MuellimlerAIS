namespace MuellimlerAIS
{
    partial class FormMuellimKitablari
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
            this.comboBoxMuelliminKitablari = new System.Windows.Forms.ComboBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelMovzu = new System.Windows.Forms.Label();
            this.labelCapIli = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxMovzu = new System.Windows.Forms.TextBox();
            this.numericUpDownCapIli = new System.Windows.Forms.NumericUpDown();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapIli)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMuelliminKitablari
            // 
            this.comboBoxMuelliminKitablari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuelliminKitablari.FormattingEnabled = true;
            this.comboBoxMuelliminKitablari.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMuelliminKitablari.Name = "comboBoxMuelliminKitablari";
            this.comboBoxMuelliminKitablari.Size = new System.Drawing.Size(460, 21);
            this.comboBoxMuelliminKitablari.TabIndex = 0;
            this.comboBoxMuelliminKitablari.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuelliminKitablari_SelectedIndexChanged);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(9, 42);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad :";
            // 
            // labelMovzu
            // 
            this.labelMovzu.AutoSize = true;
            this.labelMovzu.Location = new System.Drawing.Point(9, 68);
            this.labelMovzu.Name = "labelMovzu";
            this.labelMovzu.Size = new System.Drawing.Size(45, 13);
            this.labelMovzu.TabIndex = 2;
            this.labelMovzu.Text = "Mövzu :";
            // 
            // labelCapIli
            // 
            this.labelCapIli.AutoSize = true;
            this.labelCapIli.Location = new System.Drawing.Point(9, 93);
            this.labelCapIli.Name = "labelCapIli";
            this.labelCapIli.Size = new System.Drawing.Size(42, 13);
            this.labelCapIli.TabIndex = 3;
            this.labelCapIli.Text = "Çap Ili :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(177, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(295, 20);
            this.textBoxAd.TabIndex = 4;
            // 
            // textBoxMovzu
            // 
            this.textBoxMovzu.Location = new System.Drawing.Point(177, 65);
            this.textBoxMovzu.Name = "textBoxMovzu";
            this.textBoxMovzu.Size = new System.Drawing.Size(295, 20);
            this.textBoxMovzu.TabIndex = 5;
            // 
            // numericUpDownCapIli
            // 
            this.numericUpDownCapIli.Location = new System.Drawing.Point(415, 91);
            this.numericUpDownCapIli.Maximum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.numericUpDownCapIli.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownCapIli.Name = "numericUpDownCapIli";
            this.numericUpDownCapIli.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownCapIli.TabIndex = 6;
            this.numericUpDownCapIli.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(317, 117);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(155, 23);
            this.buttonSil.TabIndex = 23;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(168, 117);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(143, 23);
            this.buttonSaxla.TabIndex = 21;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 117);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(150, 23);
            this.buttonYeni.TabIndex = 22;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // FormMuellimKitablari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 151);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.numericUpDownCapIli);
            this.Controls.Add(this.textBoxMovzu);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelCapIli);
            this.Controls.Add(this.labelMovzu);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxMuelliminKitablari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuellimKitablari";
            this.ShowIcon = false;
            this.Text = "Müəllimin Kitabları";
            this.Load += new System.EventHandler(this.FormMuellimKitablari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapIli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMuelliminKitablari;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelMovzu;
        private System.Windows.Forms.Label labelCapIli;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxMovzu;
        private System.Windows.Forms.NumericUpDown numericUpDownCapIli;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
    }
}