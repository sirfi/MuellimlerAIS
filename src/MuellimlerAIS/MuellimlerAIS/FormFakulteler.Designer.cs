namespace MuellimlerAIS
{
    partial class FormFakulteler
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
            this.comboBoxFakulteler = new System.Windows.Forms.ComboBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDekan = new System.Windows.Forms.Label();
            this.labelDekanMuavini = new System.Windows.Forms.Label();
            this.comboBoxDekan = new System.Windows.Forms.ComboBox();
            this.comboBoxDekanMuavini = new System.Windows.Forms.ComboBox();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonFakulteKafedralari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFakulteler
            // 
            this.comboBoxFakulteler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFakulteler.FormattingEnabled = true;
            this.comboBoxFakulteler.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFakulteler.Name = "comboBoxFakulteler";
            this.comboBoxFakulteler.Size = new System.Drawing.Size(360, 21);
            this.comboBoxFakulteler.TabIndex = 0;
            this.comboBoxFakulteler.SelectedIndexChanged += new System.EventHandler(this.comboBoxFakulteler_SelectedIndexChanged);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(122, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(250, 20);
            this.textBoxAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad :";
            // 
            // labelDekan
            // 
            this.labelDekan.AutoSize = true;
            this.labelDekan.Location = new System.Drawing.Point(9, 68);
            this.labelDekan.Name = "labelDekan";
            this.labelDekan.Size = new System.Drawing.Size(45, 13);
            this.labelDekan.TabIndex = 5;
            this.labelDekan.Text = "Dekan :";
            // 
            // labelDekanMuavini
            // 
            this.labelDekanMuavini.AutoSize = true;
            this.labelDekanMuavini.Location = new System.Drawing.Point(9, 95);
            this.labelDekanMuavini.Name = "labelDekanMuavini";
            this.labelDekanMuavini.Size = new System.Drawing.Size(85, 13);
            this.labelDekanMuavini.TabIndex = 7;
            this.labelDekanMuavini.Text = "Dekan Müavini :";
            // 
            // comboBoxDekan
            // 
            this.comboBoxDekan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDekan.FormattingEnabled = true;
            this.comboBoxDekan.Location = new System.Drawing.Point(172, 65);
            this.comboBoxDekan.Name = "comboBoxDekan";
            this.comboBoxDekan.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDekan.TabIndex = 6;
            // 
            // comboBoxDekanMuavini
            // 
            this.comboBoxDekanMuavini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDekanMuavini.FormattingEnabled = true;
            this.comboBoxDekanMuavini.Location = new System.Drawing.Point(172, 92);
            this.comboBoxDekanMuavini.Name = "comboBoxDekanMuavini";
            this.comboBoxDekanMuavini.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDekanMuavini.TabIndex = 8;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 119);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(115, 23);
            this.buttonYeni.TabIndex = 9;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(133, 119);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(118, 23);
            this.buttonSaxla.TabIndex = 10;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(257, 119);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(115, 23);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonFakulteKafedralari
            // 
            this.buttonFakulteKafedralari.Location = new System.Drawing.Point(210, 148);
            this.buttonFakulteKafedralari.Name = "buttonFakulteKafedralari";
            this.buttonFakulteKafedralari.Size = new System.Drawing.Size(162, 23);
            this.buttonFakulteKafedralari.TabIndex = 12;
            this.buttonFakulteKafedralari.Text = "Fakültə Kafedraları";
            this.buttonFakulteKafedralari.UseVisualStyleBackColor = true;
            this.buttonFakulteKafedralari.Click += new System.EventHandler(this.buttonFakulteKafedralari_Click);
            // 
            // FormFakulteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 183);
            this.Controls.Add(this.buttonFakulteKafedralari);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.comboBoxDekanMuavini);
            this.Controls.Add(this.comboBoxDekan);
            this.Controls.Add(this.labelDekanMuavini);
            this.Controls.Add(this.labelDekan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.comboBoxFakulteler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFakulteler";
            this.ShowIcon = false;
            this.Text = "Fakültələr";
            this.Load += new System.EventHandler(this.FormFakulteler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFakulteler;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDekan;
        private System.Windows.Forms.Label labelDekanMuavini;
        private System.Windows.Forms.ComboBox comboBoxDekan;
        private System.Windows.Forms.ComboBox comboBoxDekanMuavini;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonFakulteKafedralari;
    }
}