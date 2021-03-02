namespace MuellimlerinTedrisYuku
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
            this.labelMTY = new System.Windows.Forms.Label();
            this.comboBoxUniversitet = new System.Windows.Forms.ComboBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
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
            // labelMTY
            // 
            this.labelMTY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMTY.Location = new System.Drawing.Point(204, 160);
            this.labelMTY.Name = "labelMTY";
            this.labelMTY.Size = new System.Drawing.Size(368, 36);
            this.labelMTY.TabIndex = 2;
            this.labelMTY.Text = "Müəllimlərin Tədris Yükü";
            this.labelMTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(184, 184);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormGiris
            // 
            this.AcceptButton = this.buttonGir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 233);
            this.Controls.Add(this.comboBoxUniversitet);
            this.Controls.Add(this.labelMTY);
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
            this.Text = "Müəllimlərin Tədris Yükü - Giriş";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNazirlik;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonGir;
        private System.Windows.Forms.Label labelMTY;
        private System.Windows.Forms.ComboBox comboBoxUniversitet;
    }
}

