namespace MuellimlerAIS
{
    partial class UserControlMuelliminDeyeBildiyiDers
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
            this.labelDediyiIlSayi = new System.Windows.Forms.Label();
            this.checkBoxDersinAdi = new System.Windows.Forms.CheckBox();
            this.numericUpDownDediyiIlSayi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDediyiIlSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDediyiIlSayi
            // 
            this.labelDediyiIlSayi.AutoSize = true;
            this.labelDediyiIlSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDediyiIlSayi.Location = new System.Drawing.Point(362, 5);
            this.labelDediyiIlSayi.Name = "labelDediyiIlSayi";
            this.labelDediyiIlSayi.Size = new System.Drawing.Size(75, 15);
            this.labelDediyiIlSayi.TabIndex = 4;
            this.labelDediyiIlSayi.Text = "Dediyi İl Sayı :";
            // 
            // checkBoxDersinAdi
            // 
            this.checkBoxDersinAdi.Location = new System.Drawing.Point(3, 0);
            this.checkBoxDersinAdi.Name = "checkBoxDersinAdi";
            this.checkBoxDersinAdi.Size = new System.Drawing.Size(353, 24);
            this.checkBoxDersinAdi.TabIndex = 3;
            this.checkBoxDersinAdi.Text = "Dərsin Adı";
            this.checkBoxDersinAdi.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDediyiIlSayi
            // 
            this.numericUpDownDediyiIlSayi.Location = new System.Drawing.Point(443, 3);
            this.numericUpDownDediyiIlSayi.Name = "numericUpDownDediyiIlSayi";
            this.numericUpDownDediyiIlSayi.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownDediyiIlSayi.TabIndex = 5;
            // 
            // UserControlMuelliminDeyeBildiyiDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.numericUpDownDediyiIlSayi);
            this.Controls.Add(this.labelDediyiIlSayi);
            this.Controls.Add(this.checkBoxDersinAdi);
            this.Name = "UserControlMuelliminDeyeBildiyiDers";
            this.Size = new System.Drawing.Size(498, 25);
            this.Load += new System.EventHandler(this.UserControlMuelliminDeyeBildiyiDers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDediyiIlSayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDediyiIlSayi;
        private System.Windows.Forms.CheckBox checkBoxDersinAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownDediyiIlSayi;
    }
}
