namespace MuellimlerAIS
{
    partial class FormMuelliminBildiyiDiller
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
            this.flowLayoutPanelBildiyiDiller = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBildiyiDiller
            // 
            this.flowLayoutPanelBildiyiDiller.AutoScroll = true;
            this.flowLayoutPanelBildiyiDiller.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelBildiyiDiller.Name = "flowLayoutPanelBildiyiDiller";
            this.flowLayoutPanelBildiyiDiller.Size = new System.Drawing.Size(320, 200);
            this.flowLayoutPanelBildiyiDiller.TabIndex = 0;
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(257, 218);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(75, 23);
            this.buttonSaxla.TabIndex = 1;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // FormMuelliminBildiyiDiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 253);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.flowLayoutPanelBildiyiDiller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuelliminBildiyiDiller";
            this.ShowIcon = false;
            this.Text = "Bildiyi Dillər";
            this.Load += new System.EventHandler(this.FormMuelliminBildiyiDiller_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBildiyiDiller;
        private System.Windows.Forms.Button buttonSaxla;
    }
}