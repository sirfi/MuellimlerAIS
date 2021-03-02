namespace MuellimlerAIS
{
    partial class FormMuellimMeqaleleri
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
            this.comboBoxMuellimMeqaleleri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMovzu = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNesrTarixi = new System.Windows.Forms.MaskedTextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMuellimMeqaleleri
            // 
            this.comboBoxMuellimMeqaleleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuellimMeqaleleri.FormattingEnabled = true;
            this.comboBoxMuellimMeqaleleri.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMuellimMeqaleleri.Name = "comboBoxMuellimMeqaleleri";
            this.comboBoxMuellimMeqaleleri.Size = new System.Drawing.Size(510, 21);
            this.comboBoxMuellimMeqaleleri.TabIndex = 0;
            this.comboBoxMuellimMeqaleleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuellimMeqaleleri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mövzu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nəşr Tarixi :";
            // 
            // textBoxMovzu
            // 
            this.textBoxMovzu.Location = new System.Drawing.Point(98, 39);
            this.textBoxMovzu.Name = "textBoxMovzu";
            this.textBoxMovzu.Size = new System.Drawing.Size(418, 20);
            this.textBoxMovzu.TabIndex = 3;
            // 
            // maskedTextBoxNesrTarixi
            // 
            this.maskedTextBoxNesrTarixi.Location = new System.Drawing.Point(453, 65);
            this.maskedTextBoxNesrTarixi.Mask = "00.00.0000";
            this.maskedTextBoxNesrTarixi.Name = "maskedTextBoxNesrTarixi";
            this.maskedTextBoxNesrTarixi.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxNesrTarixi.TabIndex = 17;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(357, 91);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(165, 23);
            this.buttonSil.TabIndex = 20;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(183, 91);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(168, 23);
            this.buttonSaxla.TabIndex = 18;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(12, 91);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(165, 23);
            this.buttonYeni.TabIndex = 19;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // FormMuellimMeqaleleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 122);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.maskedTextBoxNesrTarixi);
            this.Controls.Add(this.textBoxMovzu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMuellimMeqaleleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuellimMeqaleleri";
            this.ShowIcon = false;
            this.Text = "Müəllimin Məqalələri";
            this.Load += new System.EventHandler(this.FormMuellimMeqaleleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMuellimMeqaleleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMovzu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNesrTarixi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonYeni;
    }
}