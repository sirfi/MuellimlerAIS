namespace MuellimlerAIS
{
    partial class FormIxtisasQruplari
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
            this.comboBoxIxtisasQruplari = new System.Windows.Forms.ComboBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelTelebeSayi = new System.Windows.Forms.Label();
            this.labelBaslamaIli = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.numericUpDownTelebeSayi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBaslamaIli = new System.Windows.Forms.NumericUpDown();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTelebeSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaslamaIli)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIxtisasQruplari
            // 
            this.comboBoxIxtisasQruplari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIxtisasQruplari.FormattingEnabled = true;
            this.comboBoxIxtisasQruplari.Location = new System.Drawing.Point(12, 12);
            this.comboBoxIxtisasQruplari.Name = "comboBoxIxtisasQruplari";
            this.comboBoxIxtisasQruplari.Size = new System.Drawing.Size(260, 21);
            this.comboBoxIxtisasQruplari.TabIndex = 0;
            this.comboBoxIxtisasQruplari.SelectedIndexChanged += new System.EventHandler(this.comboBoxIxtisasQruplari_SelectedIndexChanged);
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
            // labelTelebeSayi
            // 
            this.labelTelebeSayi.AutoSize = true;
            this.labelTelebeSayi.Location = new System.Drawing.Point(9, 67);
            this.labelTelebeSayi.Name = "labelTelebeSayi";
            this.labelTelebeSayi.Size = new System.Drawing.Size(69, 13);
            this.labelTelebeSayi.TabIndex = 2;
            this.labelTelebeSayi.Text = "Tələbə Sayı :";
            // 
            // labelBaslamaIli
            // 
            this.labelBaslamaIli.AutoSize = true;
            this.labelBaslamaIli.Location = new System.Drawing.Point(9, 93);
            this.labelBaslamaIli.Name = "labelBaslamaIli";
            this.labelBaslamaIli.Size = new System.Drawing.Size(63, 13);
            this.labelBaslamaIli.TabIndex = 3;
            this.labelBaslamaIli.Text = "Başlama İli :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(101, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(171, 20);
            this.textBoxAd.TabIndex = 4;
            // 
            // numericUpDownTelebeSayi
            // 
            this.numericUpDownTelebeSayi.Location = new System.Drawing.Point(217, 65);
            this.numericUpDownTelebeSayi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTelebeSayi.Name = "numericUpDownTelebeSayi";
            this.numericUpDownTelebeSayi.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownTelebeSayi.TabIndex = 5;
            this.numericUpDownTelebeSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownBaslamaIli
            // 
            this.numericUpDownBaslamaIli.Location = new System.Drawing.Point(189, 91);
            this.numericUpDownBaslamaIli.Name = "numericUpDownBaslamaIli";
            this.numericUpDownBaslamaIli.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownBaslamaIli.TabIndex = 6;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(189, 117);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(83, 23);
            this.buttonSil.TabIndex = 42;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(101, 117);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(82, 23);
            this.buttonSaxla.TabIndex = 40;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 117);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(83, 23);
            this.buttonYeni.TabIndex = 41;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // FormIxtisasQruplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.numericUpDownBaslamaIli);
            this.Controls.Add(this.numericUpDownTelebeSayi);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelBaslamaIli);
            this.Controls.Add(this.labelTelebeSayi);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxIxtisasQruplari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIxtisasQruplari";
            this.ShowIcon = false;
            this.Text = "İxtisas Qrupları";
            this.Load += new System.EventHandler(this.FormIxtisasQruplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTelebeSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaslamaIli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIxtisasQruplari;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelTelebeSayi;
        private System.Windows.Forms.Label labelBaslamaIli;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.NumericUpDown numericUpDownTelebeSayi;
        private System.Windows.Forms.NumericUpDown numericUpDownBaslamaIli;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
    }
}