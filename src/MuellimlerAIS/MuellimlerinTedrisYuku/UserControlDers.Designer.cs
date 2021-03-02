namespace MuellimlerinTedrisYuku
{
    partial class UserControlDers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDersAdi = new System.Windows.Forms.Label();
            this.flowLayoutPanelIxtisasQruplari = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelDersAdi
            // 
            this.labelDersAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDersAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDersAdi.Location = new System.Drawing.Point(3, 3);
            this.labelDersAdi.Name = "labelDersAdi";
            this.labelDersAdi.Size = new System.Drawing.Size(354, 61);
            this.labelDersAdi.TabIndex = 0;
            this.labelDersAdi.Text = "Ders Adı";
            this.labelDersAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelIxtisasQruplari
            // 
            this.flowLayoutPanelIxtisasQruplari.AllowDrop = true;
            this.flowLayoutPanelIxtisasQruplari.AutoScroll = true;
            this.flowLayoutPanelIxtisasQruplari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelIxtisasQruplari.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanelIxtisasQruplari.Name = "flowLayoutPanelIxtisasQruplari";
            this.flowLayoutPanelIxtisasQruplari.Size = new System.Drawing.Size(354, 200);
            this.flowLayoutPanelIxtisasQruplari.TabIndex = 1;
            this.flowLayoutPanelIxtisasQruplari.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelIxtisasQruplari_ControlAdded);
            this.flowLayoutPanelIxtisasQruplari.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelIxtisasQruplari_ControlRemoved);
            this.flowLayoutPanelIxtisasQruplari.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanelIxtisasQruplari_DragDrop);
            this.flowLayoutPanelIxtisasQruplari.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanelIxtisasQruplari_DragEnter);
            // 
            // UserControlDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanelIxtisasQruplari);
            this.Controls.Add(this.labelDersAdi);
            this.Name = "UserControlDers";
            this.Size = new System.Drawing.Size(360, 270);
            this.Load += new System.EventHandler(this.UserControlDers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDersAdi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIxtisasQruplari;
    }
}
