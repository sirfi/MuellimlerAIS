namespace MuellimlerAIS
{
    partial class FormDiller
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
            this.comboBoxDiller = new System.Windows.Forms.ComboBox();
            this.labelAd = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDiller
            // 
            this.comboBoxDiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiller.FormattingEnabled = true;
            this.comboBoxDiller.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDiller.Name = "comboBoxDiller";
            this.comboBoxDiller.Size = new System.Drawing.Size(260, 21);
            this.comboBoxDiller.TabIndex = 0;
            this.comboBoxDiller.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiller_SelectedIndexChanged);
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
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(72, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(200, 20);
            this.textBoxAd.TabIndex = 2;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 69);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(80, 23);
            this.buttonYeni.TabIndex = 3;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(98, 69);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(88, 23);
            this.buttonSaxla.TabIndex = 4;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(192, 69);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 23);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormDiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.comboBoxDiller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDiller";
            this.ShowIcon = false;
            this.Text = "Dillər";
            this.Load += new System.EventHandler(this.FormDiller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiller;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonSil;
    }
}