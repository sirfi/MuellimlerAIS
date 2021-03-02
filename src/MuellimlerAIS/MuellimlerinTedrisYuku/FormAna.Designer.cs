namespace MuellimlerinTedrisYuku
{
    partial class FormAna
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
            this.buttonManualDuzelis = new System.Windows.Forms.Button();
            this.buttonAvtomatikDuzelis = new System.Windows.Forms.Button();
            this.buttonBaxVeCapEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManualDuzelis
            // 
            this.buttonManualDuzelis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonManualDuzelis.Location = new System.Drawing.Point(12, 12);
            this.buttonManualDuzelis.Name = "buttonManualDuzelis";
            this.buttonManualDuzelis.Size = new System.Drawing.Size(460, 60);
            this.buttonManualDuzelis.TabIndex = 0;
            this.buttonManualDuzelis.Text = "Manual Düzəliş";
            this.buttonManualDuzelis.UseVisualStyleBackColor = true;
            this.buttonManualDuzelis.Click += new System.EventHandler(this.buttonManualDuzelis_Click);
            // 
            // buttonAvtomatikDuzelis
            // 
            this.buttonAvtomatikDuzelis.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAvtomatikDuzelis.Location = new System.Drawing.Point(12, 78);
            this.buttonAvtomatikDuzelis.Name = "buttonAvtomatikDuzelis";
            this.buttonAvtomatikDuzelis.Size = new System.Drawing.Size(460, 60);
            this.buttonAvtomatikDuzelis.TabIndex = 1;
            this.buttonAvtomatikDuzelis.Text = "Avtomatik Düzəliş";
            this.buttonAvtomatikDuzelis.UseVisualStyleBackColor = true;
            this.buttonAvtomatikDuzelis.Click += new System.EventHandler(this.buttonAvtomatikDuzelis_Click);
            // 
            // buttonBaxVeCapEt
            // 
            this.buttonBaxVeCapEt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBaxVeCapEt.Location = new System.Drawing.Point(12, 144);
            this.buttonBaxVeCapEt.Name = "buttonBaxVeCapEt";
            this.buttonBaxVeCapEt.Size = new System.Drawing.Size(460, 60);
            this.buttonBaxVeCapEt.TabIndex = 2;
            this.buttonBaxVeCapEt.Text = "Bax Və Çap Et";
            this.buttonBaxVeCapEt.UseVisualStyleBackColor = true;
            this.buttonBaxVeCapEt.Click += new System.EventHandler(this.buttonBaxVeCapEt_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 216);
            this.Controls.Add(this.buttonBaxVeCapEt);
            this.Controls.Add(this.buttonAvtomatikDuzelis);
            this.Controls.Add(this.buttonManualDuzelis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müəllimlərin Tədris Yükü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAna_FormClosed);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManualDuzelis;
        private System.Windows.Forms.Button buttonAvtomatikDuzelis;
        private System.Windows.Forms.Button buttonBaxVeCapEt;
    }
}