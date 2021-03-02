namespace MuellimlerAIS
{
    partial class FormMuellimTehsili
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
            this.comboBoxMuellimTehsilleri = new System.Windows.Forms.ComboBox();
            this.labelUniversitet = new System.Windows.Forms.Label();
            this.labelIxtisas = new System.Windows.Forms.Label();
            this.labelMezuniyyetIli = new System.Windows.Forms.Label();
            this.comboBoxUniversitet = new System.Windows.Forms.ComboBox();
            this.textBoxIxtisas = new System.Windows.Forms.TextBox();
            this.numericUpDownMezuniyyetIli = new System.Windows.Forms.NumericUpDown();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMezuniyyetIli)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMuellimTehsilleri
            // 
            this.comboBoxMuellimTehsilleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuellimTehsilleri.FormattingEnabled = true;
            this.comboBoxMuellimTehsilleri.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMuellimTehsilleri.Name = "comboBoxMuellimTehsilleri";
            this.comboBoxMuellimTehsilleri.Size = new System.Drawing.Size(510, 21);
            this.comboBoxMuellimTehsilleri.TabIndex = 0;
            this.comboBoxMuellimTehsilleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuellimTehsilleri_SelectedIndexChanged);
            // 
            // labelUniversitet
            // 
            this.labelUniversitet.AutoSize = true;
            this.labelUniversitet.Location = new System.Drawing.Point(9, 43);
            this.labelUniversitet.Name = "labelUniversitet";
            this.labelUniversitet.Size = new System.Drawing.Size(63, 13);
            this.labelUniversitet.TabIndex = 1;
            this.labelUniversitet.Text = "Universitet :";
            // 
            // labelIxtisas
            // 
            this.labelIxtisas.AutoSize = true;
            this.labelIxtisas.Location = new System.Drawing.Point(9, 70);
            this.labelIxtisas.Name = "labelIxtisas";
            this.labelIxtisas.Size = new System.Drawing.Size(42, 13);
            this.labelIxtisas.TabIndex = 2;
            this.labelIxtisas.Text = "İxtisas :";
            // 
            // labelMezuniyyetIli
            // 
            this.labelMezuniyyetIli.AutoSize = true;
            this.labelMezuniyyetIli.Location = new System.Drawing.Point(9, 96);
            this.labelMezuniyyetIli.Name = "labelMezuniyyetIli";
            this.labelMezuniyyetIli.Size = new System.Drawing.Size(76, 13);
            this.labelMezuniyyetIli.TabIndex = 3;
            this.labelMezuniyyetIli.Text = "Məzuniyyət İli :";
            // 
            // comboBoxUniversitet
            // 
            this.comboBoxUniversitet.FormattingEnabled = true;
            this.comboBoxUniversitet.Location = new System.Drawing.Point(179, 40);
            this.comboBoxUniversitet.Name = "comboBoxUniversitet";
            this.comboBoxUniversitet.Size = new System.Drawing.Size(343, 21);
            this.comboBoxUniversitet.TabIndex = 4;
            // 
            // textBoxIxtisas
            // 
            this.textBoxIxtisas.Location = new System.Drawing.Point(305, 67);
            this.textBoxIxtisas.Name = "textBoxIxtisas";
            this.textBoxIxtisas.Size = new System.Drawing.Size(217, 20);
            this.textBoxIxtisas.TabIndex = 5;
            // 
            // numericUpDownMezuniyyetIli
            // 
            this.numericUpDownMezuniyyetIli.Location = new System.Drawing.Point(456, 94);
            this.numericUpDownMezuniyyetIli.Maximum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.numericUpDownMezuniyyetIli.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownMezuniyyetIli.Name = "numericUpDownMezuniyyetIli";
            this.numericUpDownMezuniyyetIli.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMezuniyyetIli.TabIndex = 6;
            this.numericUpDownMezuniyyetIli.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(357, 120);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(165, 23);
            this.buttonSil.TabIndex = 15;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(183, 120);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(168, 23);
            this.buttonSaxla.TabIndex = 13;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 120);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(165, 23);
            this.buttonYeni.TabIndex = 14;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // FormMuellimTehsili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 156);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.numericUpDownMezuniyyetIli);
            this.Controls.Add(this.textBoxIxtisas);
            this.Controls.Add(this.comboBoxUniversitet);
            this.Controls.Add(this.labelMezuniyyetIli);
            this.Controls.Add(this.labelIxtisas);
            this.Controls.Add(this.labelUniversitet);
            this.Controls.Add(this.comboBoxMuellimTehsilleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuellimTehsili";
            this.ShowIcon = false;
            this.Text = "Müəllimin Təhsili";
            this.Load += new System.EventHandler(this.FormMuellimTehsili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMezuniyyetIli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMuellimTehsilleri;
        private System.Windows.Forms.Label labelUniversitet;
        private System.Windows.Forms.Label labelIxtisas;
        private System.Windows.Forms.Label labelMezuniyyetIli;
        private System.Windows.Forms.ComboBox comboBoxUniversitet;
        private System.Windows.Forms.TextBox textBoxIxtisas;
        private System.Windows.Forms.NumericUpDown numericUpDownMezuniyyetIli;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
    }
}