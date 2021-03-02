namespace MuellimlerAIS
{
    partial class FormUniversitetRektorVeProrektorleri
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
            this.comboBoxUniversitetProrektorleri = new System.Windows.Forms.ComboBox();
            this.labelVezife = new System.Windows.Forms.Label();
            this.textBoxVezife = new System.Windows.Forms.TextBox();
            this.labelProrektor = new System.Windows.Forms.Label();
            this.comboBoxProrektor = new System.Windows.Forms.ComboBox();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.groupBoxProrektorler = new System.Windows.Forms.GroupBox();
            this.labelRektor = new System.Windows.Forms.Label();
            this.comboBoxRektor = new System.Windows.Forms.ComboBox();
            this.buttonRektorSaxla = new System.Windows.Forms.Button();
            this.groupBoxProrektorler.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxUniversitetProrektorleri
            // 
            this.comboBoxUniversitetProrektorleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniversitetProrektorleri.FormattingEnabled = true;
            this.comboBoxUniversitetProrektorleri.Location = new System.Drawing.Point(6, 19);
            this.comboBoxUniversitetProrektorleri.Name = "comboBoxUniversitetProrektorleri";
            this.comboBoxUniversitetProrektorleri.Size = new System.Drawing.Size(357, 21);
            this.comboBoxUniversitetProrektorleri.TabIndex = 0;
            this.comboBoxUniversitetProrektorleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxUniversitetProrektorleri_SelectedIndexChanged);
            // 
            // labelVezife
            // 
            this.labelVezife.AutoSize = true;
            this.labelVezife.Location = new System.Drawing.Point(3, 49);
            this.labelVezife.Name = "labelVezife";
            this.labelVezife.Size = new System.Drawing.Size(42, 13);
            this.labelVezife.TabIndex = 1;
            this.labelVezife.Text = "Vəzifə :";
            // 
            // textBoxVezife
            // 
            this.textBoxVezife.Location = new System.Drawing.Point(51, 46);
            this.textBoxVezife.Name = "textBoxVezife";
            this.textBoxVezife.Size = new System.Drawing.Size(312, 20);
            this.textBoxVezife.TabIndex = 2;
            // 
            // labelProrektor
            // 
            this.labelProrektor.AutoSize = true;
            this.labelProrektor.Location = new System.Drawing.Point(3, 75);
            this.labelProrektor.Name = "labelProrektor";
            this.labelProrektor.Size = new System.Drawing.Size(56, 13);
            this.labelProrektor.TabIndex = 3;
            this.labelProrektor.Text = "Prorektor :";
            // 
            // comboBoxProrektor
            // 
            this.comboBoxProrektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProrektor.FormattingEnabled = true;
            this.comboBoxProrektor.Location = new System.Drawing.Point(65, 72);
            this.comboBoxProrektor.Name = "comboBoxProrektor";
            this.comboBoxProrektor.Size = new System.Drawing.Size(298, 21);
            this.comboBoxProrektor.TabIndex = 4;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(6, 99);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(115, 23);
            this.buttonYeni.TabIndex = 5;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(127, 99);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(115, 23);
            this.buttonSaxla.TabIndex = 6;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(248, 99);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(115, 23);
            this.buttonSil.TabIndex = 7;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // groupBoxProrektorler
            // 
            this.groupBoxProrektorler.Controls.Add(this.comboBoxUniversitetProrektorleri);
            this.groupBoxProrektorler.Controls.Add(this.buttonSil);
            this.groupBoxProrektorler.Controls.Add(this.labelVezife);
            this.groupBoxProrektorler.Controls.Add(this.buttonSaxla);
            this.groupBoxProrektorler.Controls.Add(this.textBoxVezife);
            this.groupBoxProrektorler.Controls.Add(this.buttonYeni);
            this.groupBoxProrektorler.Controls.Add(this.labelProrektor);
            this.groupBoxProrektorler.Controls.Add(this.comboBoxProrektor);
            this.groupBoxProrektorler.Location = new System.Drawing.Point(15, 37);
            this.groupBoxProrektorler.Name = "groupBoxProrektorler";
            this.groupBoxProrektorler.Size = new System.Drawing.Size(369, 130);
            this.groupBoxProrektorler.TabIndex = 8;
            this.groupBoxProrektorler.TabStop = false;
            this.groupBoxProrektorler.Text = "Prorektorlər";
            // 
            // labelRektor
            // 
            this.labelRektor.AutoSize = true;
            this.labelRektor.Location = new System.Drawing.Point(12, 13);
            this.labelRektor.Name = "labelRektor";
            this.labelRektor.Size = new System.Drawing.Size(45, 13);
            this.labelRektor.TabIndex = 9;
            this.labelRektor.Text = "Rektor :";
            // 
            // comboBoxRektor
            // 
            this.comboBoxRektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRektor.FormattingEnabled = true;
            this.comboBoxRektor.Location = new System.Drawing.Point(63, 10);
            this.comboBoxRektor.Name = "comboBoxRektor";
            this.comboBoxRektor.Size = new System.Drawing.Size(251, 21);
            this.comboBoxRektor.TabIndex = 10;
            // 
            // buttonRektorSaxla
            // 
            this.buttonRektorSaxla.Location = new System.Drawing.Point(320, 8);
            this.buttonRektorSaxla.Name = "buttonRektorSaxla";
            this.buttonRektorSaxla.Size = new System.Drawing.Size(68, 23);
            this.buttonRektorSaxla.TabIndex = 8;
            this.buttonRektorSaxla.Text = "Saxla";
            this.buttonRektorSaxla.UseVisualStyleBackColor = true;
            // 
            // FormUniversitetRektorVeProrektorleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.buttonRektorSaxla);
            this.Controls.Add(this.comboBoxRektor);
            this.Controls.Add(this.labelRektor);
            this.Controls.Add(this.groupBoxProrektorler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUniversitetRektorVeProrektorleri";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormUniversitetProrektorleri_Load);
            this.groupBoxProrektorler.ResumeLayout(false);
            this.groupBoxProrektorler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUniversitetProrektorleri;
        private System.Windows.Forms.Label labelVezife;
        private System.Windows.Forms.TextBox textBoxVezife;
        private System.Windows.Forms.Label labelProrektor;
        private System.Windows.Forms.ComboBox comboBoxProrektor;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.GroupBox groupBoxProrektorler;
        private System.Windows.Forms.Label labelRektor;
        private System.Windows.Forms.ComboBox comboBoxRektor;
        private System.Windows.Forms.Button buttonRektorSaxla;
    }
}