namespace MuellimlerAIS
{
    partial class FormMuelliminDeyeBildiyiDersler
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
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.flowLayoutPanelDeyeBildiyiDersler = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(461, 293);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(75, 23);
            this.buttonSaxla.TabIndex = 3;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // flowLayoutPanelDeyeBildiyiDersler
            // 
            this.flowLayoutPanelDeyeBildiyiDersler.AutoScroll = true;
            this.flowLayoutPanelDeyeBildiyiDersler.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelDeyeBildiyiDersler.Name = "flowLayoutPanelDeyeBildiyiDersler";
            this.flowLayoutPanelDeyeBildiyiDersler.Size = new System.Drawing.Size(524, 275);
            this.flowLayoutPanelDeyeBildiyiDersler.TabIndex = 2;
            // 
            // FormMuelliminDeyeBildiyiDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 328);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.flowLayoutPanelDeyeBildiyiDersler);
            this.Name = "FormMuelliminDeyeBildiyiDersler";
            this.Text = "Müəllimin Deyə Bildiyi Derslər";
            this.Load += new System.EventHandler(this.FormMuelliminDeyeBildiyiDersler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeyeBildiyiDersler;

    }
}