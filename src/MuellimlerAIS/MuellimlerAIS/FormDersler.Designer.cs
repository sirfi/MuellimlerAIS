namespace MuellimlerAIS
{
    partial class FormDersler
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
            this.comboBoxDersler = new System.Windows.Forms.ComboBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDersler
            // 
            this.comboBoxDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDersler.FormattingEnabled = true;
            this.comboBoxDersler.Location = new System.Drawing.Point(13, 13);
            this.comboBoxDersler.Name = "comboBoxDersler";
            this.comboBoxDersler.Size = new System.Drawing.Size(459, 21);
            this.comboBoxDersler.TabIndex = 0;
            this.comboBoxDersler.SelectedIndexChanged += new System.EventHandler(this.comboBoxDersler_SelectedIndexChanged);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(12, 43);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(44, 40);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(428, 20);
            this.textBoxAd.TabIndex = 2;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(322, 66);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(150, 23);
            this.buttonSil.TabIndex = 15;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(171, 66);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(145, 23);
            this.buttonSaxla.TabIndex = 13;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(15, 66);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(150, 23);
            this.buttonYeni.TabIndex = 14;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // FormDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 103);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxDersler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDersler";
            this.ShowIcon = false;
            this.Text = "Dərslər";
            this.Load += new System.EventHandler(this.FormDersler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDersler;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
    }
}