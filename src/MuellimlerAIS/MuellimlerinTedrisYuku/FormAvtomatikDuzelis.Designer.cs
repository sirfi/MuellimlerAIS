namespace MuellimlerinTedrisYuku
{
    partial class FormAvtomatikDuzelis
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
            this.buttonTedrisYukunuAvtomatikHazirla = new System.Windows.Forms.Button();
            this.textBoxGorulenEmeliyyatlar = new System.Windows.Forms.TextBox();
            this.labelTedrisIli = new System.Windows.Forms.Label();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.comboBoxTedrisIli = new System.Windows.Forms.ComboBox();
            this.progressBarEmelliyatVeziyyeti = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // buttonTedrisYukunuAvtomatikHazirla
            // 
            this.buttonTedrisYukunuAvtomatikHazirla.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTedrisYukunuAvtomatikHazirla.Location = new System.Drawing.Point(160, 13);
            this.buttonTedrisYukunuAvtomatikHazirla.Name = "buttonTedrisYukunuAvtomatikHazirla";
            this.buttonTedrisYukunuAvtomatikHazirla.Size = new System.Drawing.Size(323, 54);
            this.buttonTedrisYukunuAvtomatikHazirla.TabIndex = 0;
            this.buttonTedrisYukunuAvtomatikHazirla.Text = "Tədris Yükünü Avtomatik Hazırla";
            this.buttonTedrisYukunuAvtomatikHazirla.UseVisualStyleBackColor = true;
            this.buttonTedrisYukunuAvtomatikHazirla.Click += new System.EventHandler(this.buttonTedrisYukunuAvtomatikHazirla_Click);
            // 
            // textBoxGorulenEmeliyyatlar
            // 
            this.textBoxGorulenEmeliyyatlar.Location = new System.Drawing.Point(12, 78);
            this.textBoxGorulenEmeliyyatlar.Multiline = true;
            this.textBoxGorulenEmeliyyatlar.Name = "textBoxGorulenEmeliyyatlar";
            this.textBoxGorulenEmeliyyatlar.ReadOnly = true;
            this.textBoxGorulenEmeliyyatlar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGorulenEmeliyyatlar.Size = new System.Drawing.Size(560, 379);
            this.textBoxGorulenEmeliyyatlar.TabIndex = 1;
            // 
            // labelTedrisIli
            // 
            this.labelTedrisIli.AutoSize = true;
            this.labelTedrisIli.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTedrisIli.Location = new System.Drawing.Point(8, 13);
            this.labelTedrisIli.Name = "labelTedrisIli";
            this.labelTedrisIli.Size = new System.Drawing.Size(69, 19);
            this.labelTedrisIli.TabIndex = 2;
            this.labelTedrisIli.Text = "Tədris İli :";
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSaxla.Location = new System.Drawing.Point(489, 12);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(83, 54);
            this.buttonSaxla.TabIndex = 4;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // comboBoxTedrisIli
            // 
            this.comboBoxTedrisIli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTedrisIli.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTedrisIli.FormattingEnabled = true;
            this.comboBoxTedrisIli.Location = new System.Drawing.Point(12, 43);
            this.comboBoxTedrisIli.Name = "comboBoxTedrisIli";
            this.comboBoxTedrisIli.Size = new System.Drawing.Size(142, 23);
            this.comboBoxTedrisIli.TabIndex = 8;
            this.comboBoxTedrisIli.SelectedIndexChanged += new System.EventHandler(this.comboBoxTedrisIli_SelectedIndexChanged);
            // 
            // progressBarEmelliyatVeziyyeti
            // 
            this.progressBarEmelliyatVeziyyeti.Location = new System.Drawing.Point(12, 463);
            this.progressBarEmelliyatVeziyyeti.Name = "progressBarEmelliyatVeziyyeti";
            this.progressBarEmelliyatVeziyyeti.Size = new System.Drawing.Size(560, 23);
            this.progressBarEmelliyatVeziyyeti.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarEmelliyatVeziyyeti.TabIndex = 9;
            this.progressBarEmelliyatVeziyyeti.Visible = false;
            // 
            // FormAvtomatikDuzelis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 498);
            this.Controls.Add(this.progressBarEmelliyatVeziyyeti);
            this.Controls.Add(this.comboBoxTedrisIli);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.labelTedrisIli);
            this.Controls.Add(this.textBoxGorulenEmeliyyatlar);
            this.Controls.Add(this.buttonTedrisYukunuAvtomatikHazirla);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAvtomatikDuzelis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müəllimlərin Tədris Yükü - Avtomatik Düzəliş";
            this.Load += new System.EventHandler(this.FormAvtomatikDuzelis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTedrisYukunuAvtomatikHazirla;
        private System.Windows.Forms.TextBox textBoxGorulenEmeliyyatlar;
        private System.Windows.Forms.Label labelTedrisIli;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.ComboBox comboBoxTedrisIli;
        private System.Windows.Forms.ProgressBar progressBarEmelliyatVeziyyeti;
    }
}